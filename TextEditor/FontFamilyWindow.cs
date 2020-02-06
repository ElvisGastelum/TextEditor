using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class FontFamilyWindow : Form
    {
        FontStyle OptionsFontActived;
        TextBox TextBox;
        public FontFamilyWindow(FontStyle OptionsFontActived, TextBox TextBox)
        {
            InitializeComponent();
            this.OptionsFontActived = OptionsFontActived;
            this.TextBox = TextBox;
        }

        public void ChangeFontFamily(TextBox text, FontFamily family)
        {
            text.Font = new Font(family, text.Font.Size, OptionsFontActived);
        }

        public Font ChangeFontFamilyOld(TextBox text, FontFamily family)
        {
            return new Font(family, text.Font.Size, OptionsFontActived);
        }

        private void AcceptButtonClick(object sender, EventArgs e)
        {
            ChangeFontFamily();
            Close();
        }

        private void ChangeFontFamily()
        {
            switch (Fonts.SelectedItem)
            {
                case "Sans Serif":
                    ChangeFontFamily(TextBox, FontFamily.GenericSansSerif);
                    break;
                case "Serif":
                    ChangeFontFamily(TextBox, FontFamily.GenericSerif);
                    break;
                case "Monospace":
                    ChangeFontFamily(TextBox, FontFamily.GenericMonospace);
                    break;
            }
        }

        private void FontFamilyWindow_Load(object sender, EventArgs e)
        {
            switch (TextBox.Font.FontFamily.Name)
            {
                case "Microsoft Sans Serif":
                    Fonts.SelectedIndex = 0;
                    break;
                case "Times New Roman":
                    Fonts.SelectedIndex = 1;
                    break;
                case "Courier New":
                    Fonts.SelectedIndex = 2;
                    break;
                default:
                    Fonts.SelectedIndex = 0;
                    break;
            }
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
