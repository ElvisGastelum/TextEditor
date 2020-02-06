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
    public partial class App : Form
    {
        FontStyle OptionsFontActived = FontStyle.Regular;

        public App()
        {
            InitializeComponent();
        }

        private void Close(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void App_Load(object sender, EventArgs e)
        {
            TextBox.Font = new Font(TextBox.Font.FontFamily, 16.0f, FontStyleWindow.OptionsFontActived);
        }

        private void FamilyFontWindow(object sender, EventArgs e)
        {
            FontFamilyWindow fm = new FontFamilyWindow(FontStyleWindow.OptionsFontActived, TextBox);
            fm.Show();
        }

        private void NewText(object sender, EventArgs e)
        {
            TextBox.Clear();
        }

        private void Close(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FontStyleWin(object sender, EventArgs e)
        {
            FontStyleWindow fs = new FontStyleWindow(TextBox);
            fs.Show();
        }

        private void SizeFontWin(object sender, EventArgs e)
        {
            FontSizeWindow fs = new FontSizeWindow(TextBox);
            fs.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }
    }
}
