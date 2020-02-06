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
    public partial class FontStyleWindow : Form
    {
        public static FontStyle OptionsFontActived = FontStyle.Regular;
        TextBox TextBox;
        public FontStyleWindow(TextBox TextBox)
        {
            InitializeComponent();
            this.TextBox = TextBox;
        }

        private void ChangeOptionFont(FontStyle fontStyle, TextBox text, bool b)
        {
            if (b == false)
            {
                if ((OptionsFontActived.HasFlag(fontStyle)))
                {
                    OptionsFontActived -= fontStyle;
                }
            }
            else
            {
                if (!(OptionsFontActived.HasFlag(fontStyle)))
                {
                    OptionsFontActived |= fontStyle;
                }
            }
            text.Font = new Font(text.Font.FontFamily, text.Font.Size, OptionsFontActived);
        }

        private void CancelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void AcceptClick(object sender, EventArgs e)
        {
            ChangeFontStyle();
            Close();
        }

        private void ChangeFontStyle()
        {
            ChangeOptionFont(FontStyle.Bold, TextBox, Negrita.Checked);
            ChangeOptionFont(FontStyle.Italic, TextBox, Cursiva.Checked);
            ChangeOptionFont(FontStyle.Underline, TextBox, Subrayado.Checked);
        }

        private void FontStyleWindow_Load(object sender, EventArgs e)
        {
            if (TextBox.Font.Bold)
                Negrita.Checked = true;
            if (TextBox.Font.Italic)
                Cursiva.Checked = true;
            if (TextBox.Font.Underline)
                Subrayado.Checked = true;
        }
    }
}
