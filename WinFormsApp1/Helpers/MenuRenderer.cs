using System.Drawing;
using System.Windows.Forms;

namespace BloodBankApp.Helpers
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        private Color _menuBackGreen = Color.FromArgb(40, 167, 69);
        private Color _itemSelectedGreen = Color.FromArgb(33, 136, 56);

        public MenuRenderer() : base(new MyColors()) { }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.Item.IsOnDropDown)
            {
                e.TextColor = Color.Black;
            }
            else
            {
                e.TextColor = Color.White;
            }
            base.OnRenderItemText(e);
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.Enabled)
            {
                if (e.Item.IsOnDropDown && e.Item.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(_itemSelectedGreen), e.Item.ContentRectangle);
                }
                else if (e.Item.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(_itemSelectedGreen), e.Item.ContentRectangle);
                }
                else if (e.Item.IsOnDropDown)
                {
                    e.Graphics.FillRectangle(Brushes.White, e.Item.ContentRectangle);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(_menuBackGreen), e.Item.ContentRectangle);
                }
            }
        }
    }

    public class MyColors : ProfessionalColorTable
    {
        private Color _menuBackGreen = Color.FromArgb(40, 167, 69);
        private Color _itemSelectedGreen = Color.FromArgb(33, 136, 56);

        public override Color MenuStripGradientBegin => _menuBackGreen;
        public override Color MenuStripGradientEnd => _menuBackGreen;
        public override Color ToolStripDropDownBackground => Color.White;
        public override Color MenuItemSelected => _itemSelectedGreen;
        public override Color MenuItemBorder => _itemSelectedGreen;
        public override Color ImageMarginGradientBegin => Color.White;
        public override Color ImageMarginGradientMiddle => Color.White;
        public override Color ImageMarginGradientEnd => Color.White;
        public override Color SeparatorDark => Color.FromArgb(224, 224, 224);
        public override Color SeparatorLight => Color.FromArgb(224, 224, 224);
    }
}

