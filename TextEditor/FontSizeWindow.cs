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
    public partial class FontSizeWindow : Form
    {
        TextBox TextBox;
        public FontSizeWindow(TextBox TextBox)
        {
            InitializeComponent();
            this.TextBox = TextBox;
        }

        private void ChangeFontSize(TextBox text, float size)
        {
            text.Font = new Font(text.Font.FontFamily, size, FontStyleWindow.OptionsFontActived);
        }

        private void AcceptClick(object sender, EventArgs e)
        {
            ChangeFontSize();
            Close();
        }

        private void ChangeFontSize()
        {
            if (SizeSmall.Checked == true)
                ChangeFontSize(TextBox, 8.0f);
            if (SizeMedium.Checked == true)
                ChangeFontSize(TextBox, 16.0f);
            if (SizeBig.Checked == true)
                ChangeFontSize(TextBox, 26.0f);
        }

        private void CancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void FontSizeWindow_Load(object sender, EventArgs e)
        {
            switch (TextBox.Font.Size)
            {
                case 8.0f:
                    SizeSmall.Checked = true;
                    break;
                case 16.0f:
                    SizeMedium.Checked = true;
                    break;
                case 26.0f:
                    SizeBig.Checked = true;
                    break;
                default:
                    SizeMedium.Checked = true;
                    break;
            }
        }
    }
}
