using InsanmarTec.Application.Brands.Dtos;
using InsanmarTec.Application.Brands.Features;
using InsanmarTec.Application.Shared.Dtos;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.WinForms.Shared;
using Microsoft.Extensions.DependencyInjection;

namespace InsanmarTec.WinForms.Brands
{
    public partial class BrandsView : Form, ITransientDependency
    {
        private readonly BindingSource _brandsListBindingSource;
        private readonly BrandsGetter _brandsGetter;
        private readonly BrandActivator _brandActivator;
        private readonly BrandDeactivator _brandDeactivator;
        private readonly IServiceProvider _container;
        private readonly string _btnToggleState = "btnToggleState";
        private readonly string _btnEdit = "btnEdit";

        public BrandsView(
            IServiceProvider container,
            BrandsGetter brandsGetter,
            BrandActivator brandActivator,
            BrandDeactivator brandDeactivator
        )
        {
            InitializeComponent();
            _container = container;
            _brandActivator = brandActivator;
            _brandDeactivator = brandDeactivator;
            _brandsGetter = brandsGetter;
            _brandsListBindingSource = new BindingSource();

            InitializeDataGridView();
        }

        private async void InitializeDataGridView()
        {
            await LoadBrands();
            ConfigureDataGridView();
        }

        private async Task LoadBrands()
        {
            var result = await GetBrands();
            if (!result.IsSuccess)
                return;

            _brandsListBindingSource.DataSource = result.Value!;
        }

        private async Task<Result<IEnumerable<BrandDto>>> GetBrands()
        {
            var result = await _brandsGetter.Execute();
            if (!result.IsSuccess)
            {
                ViewHelper.ShowErrorMessage(result.ErrorMessage?.Split(",")[0]);
                return Result<IEnumerable<BrandDto>>.Failure(string.Empty);
            }

            return Result<IEnumerable<BrandDto>>.Success(result.Value!);
        }

        private void ConfigureDataGridView()
        {
            var idColumnName = "Id";
            var nameColumnName = "Name";
            var descriptionColumnName = "Description";
            var categoryColumnName = "Category";

            dgvBrands.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = idColumnName,
                    HeaderText = "ID",
                    Name = idColumnName
                }
            );

            dgvBrands.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = nameColumnName,
                    HeaderText = "Nombre",
                    Name = nameColumnName
                }
            );

            dgvBrands.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = descriptionColumnName,
                    HeaderText = "Descripción",
                    Name = descriptionColumnName
                }
            );

            dgvBrands.Columns.Add(
                new DataGridViewTextBoxColumn
                {
                    DataPropertyName = categoryColumnName,
                    HeaderText = "Categoría",
                    Name = categoryColumnName
                }
            );

            dgvBrands.Columns.Add(
                new DataGridViewButtonColumn { HeaderText = "Estado", Name = _btnToggleState, }
            );

            dgvBrands.Columns.Add(
                new DataGridViewButtonColumn
                {
                    HeaderText = string.Empty,
                    UseColumnTextForButtonValue = true,
                    Text = "Editar",
                    Name = _btnEdit,
                }
            );

            dgvBrands.AutoGenerateColumns = false;
            dgvBrands.DataSource = _brandsListBindingSource;
            dgvBrands.CellFormatting += DataGridViewOnCellFormatting;
            dgvBrands.CellClick += DataGridViewOnCellClick;
        }

        private async void SearchBrand()
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                await LoadBrands();
                return;
            }

            var result = await GetBrands();
            if (!result.IsSuccess)
                return;

            var brand = result.Value?.FirstOrDefault(b =>
                string.Equals(b.Name, txtSearch.Text.Trim(), StringComparison.OrdinalIgnoreCase)
            );

            _brandsListBindingSource.DataSource = brand is not null
                ? new List<BrandDto> { brand }
                : [];
        }

        private void SearchOnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchBrand();
        }

        private void SeachOnClick(object sender, EventArgs e) => SearchBrand();

        private async void AddOnClick(object sender, EventArgs e)
        {
            _container.GetRequiredService<BrandsDetailsView>().ShowDialog();
            await LoadBrands();
        }

        private async void DataGridViewOnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var brand = (BrandDto)_brandsListBindingSource[e.RowIndex];

                if (e.ColumnIndex == dgvBrands.Columns[_btnEdit].Index)
                {
                    var brandsDetailsView = _container.GetRequiredService<BrandsDetailsView>();
                    brandsDetailsView.IsUpdate = true;
                    brandsDetailsView.Brand = brand;
                    brandsDetailsView.ShowDialog();
                    await LoadBrands();
                    return;
                }

                if (e.ColumnIndex == dgvBrands.Columns[_btnToggleState].Index)
                {
                    var id = new EntityDto { Id = brand.Id };
                    var result = brand.IsActive
                        ? await _brandDeactivator.Execute(id)
                        : await _brandActivator.Execute(id);
                    if (!result.IsSuccess)
                    {
                        ViewHelper.ShowErrorMessage(result.ErrorMessage?.Split(",")[0]);
                        return;
                    }

                    brand.IsActive = !brand.IsActive;
                    dgvBrands.Refresh();
                }
            }
        }

        private void DataGridViewOnCellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e
        )
        {
            if (dgvBrands.Columns[e.ColumnIndex].Name == _btnToggleState && e.RowIndex >= 0)
            {
                var brand = (BrandDto)_brandsListBindingSource[e.RowIndex];
                if (brand is not null)
                    e.Value = brand.IsActive ? "Inhabilitar" : "Habilitar";
            }
        }
    }
}
