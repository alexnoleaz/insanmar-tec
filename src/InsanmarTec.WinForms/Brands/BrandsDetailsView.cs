using InsanmarTec.Application.Brands.Dtos;
using InsanmarTec.Application.Brands.Features;
using InsanmarTec.Application.Shared.Results;
using InsanmarTec.Domain.Brands;
using InsanmarTec.Domain.Shared.Dependency;
using InsanmarTec.WinForms.Shared;

namespace InsanmarTec.WinForms.Brands
{
    public partial class BrandsDetailsView : Form, ITransientDependency
    {
        private bool _isUpdate = false;
        private BrandDto _brand = null!;
        private readonly BrandUpdater _brandUpdater;
        private readonly BrandCreator _brandCreator;

        public BrandsDetailsView(BrandUpdater brandUpdater, BrandCreator brandCreator)
        {
            InitializeComponent();
            _brandUpdater = brandUpdater;
            _brandCreator = brandCreator;
        }

        public bool IsUpdate
        {
            set => _isUpdate = value;
        }

        public BrandDto Brand
        {
            set => _brand = value;
        }

        private void BrandsDateilsOnLoad(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                lblTitle.Text = "Actualizar marca";
                txtName.AnimateReadOnly = true;
                txtName.ReadOnly = true;
                txtName.Text = _brand.Name;
                txtDescription.Text = _brand.Description;
                txtCategory.Text = _brand.Category;
                return;
            }
            lblTitle.Text = "Agregar marca";
        }

        private async void SaveOnClick(object sender, EventArgs e)
        {
            ViewHelper.ClearInputs(errorProvider);

            if (_isUpdate)
            {
                var result = ValidateCommonFields();
                if (!result.IsSuccess)
                    return;

                var updateBrandDto = new UpdateBrandDto
                {
                    Id = _brand.Id,
                    Description = txtDescription.Text.Trim(),
                    Category = txtCategory.Text.Trim()
                };

                var brandUpdaterResult = await _brandUpdater.Execute(updateBrandDto);
                if (!brandUpdaterResult.IsSuccess)
                {
                    ViewHelper.ShowErrorMessage(result.ErrorMessage?.Split(",")[0]);
                    txtDescription.Focus();
                    return;
                }

                MessageBox.Show("Marca actualizada con éxito.");
            }
            else
            {
                if (txtName.Text == string.Empty || string.IsNullOrWhiteSpace(txtName.Text))
                {
                    ViewHelper.ShowErrorMessage(txtName, errorProvider);
                    return;
                }

                var result = ValidateCommonFields();
                if (!result.IsSuccess)
                    return;

                var createBrandDto = new CreateBrandDto
                {
                    Name = txtName.Text.Trim(),
                    Description = txtDescription.Text.Trim(),
                    Category = txtCategory.Text.Trim(),
                };

                var brandCreatorResult = await _brandCreator.Execute(createBrandDto);
                if (!brandCreatorResult.IsSuccess)
                {
                    ViewHelper.ShowErrorMessage(result.ErrorMessage?.Split(",")[0]);
                    txtName.Focus();
                    return;
                }

                MessageBox.Show("Marca agregada con éxito.");
            }

            Close();
        }

        private void CancelOnClick(object sender, EventArgs e) => Close();

        private Result ValidateCommonFields()
        {
            if (
                txtDescription.Text == string.Empty
                || string.IsNullOrWhiteSpace(txtDescription.Text)
            )
            {
                ViewHelper.ShowErrorMessage(txtDescription, errorProvider);
                return Result.Failure(string.Empty);
            }

            if (txtCategory.Text == string.Empty || string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                ViewHelper.ShowErrorMessage(txtCategory, errorProvider);
                return Result.Failure(string.Empty);
            }

            return Result.Success();
        }
    }
}
