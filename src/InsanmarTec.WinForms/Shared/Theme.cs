using MaterialSkin;
using MaterialSkin.Controls;

namespace InsanmarTec.WinForms.Shared
{
    public class Theme
    {
        public static readonly Color SpaceCadet = Color.FromArgb(20, 45, 85);
        public static readonly Color Blueberry = Color.FromArgb(75, 146, 255);
        public static readonly Color Diamond = Color.FromArgb(183, 227, 255);
        public static readonly Color Sapphire = Color.FromArgb(8, 86, 207);

        private static readonly MaterialSkinManager _materialSkinManager;

        static Theme()
        {
            _materialSkinManager = MaterialSkinManager.Instance;
            _materialSkinManager.EnforceBackcolorOnAllComponents = true;
        }

        public static void ApplyColorSchemeToForm(MaterialForm form)
        {
            _materialSkinManager.AddFormToManage(form);
            _materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            _materialSkinManager.ColorScheme = new ColorScheme(
                SpaceCadet,
                SpaceCadet,
                Diamond,
                Color.Blue,
                TextShade.WHITE
            );
        }
    }
}
