namespace TextEditor
{
    partial class FontFamilyWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.FontTypes = new System.Windows.Forms.GroupBox();
            this.Fonts = new System.Windows.Forms.ListBox();
            this.FontTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(50, 135);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 0;
            this.Accept.Text = "Aceptar";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.AcceptButtonClick);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(131, 135);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // FontTypes
            // 
            this.FontTypes.Controls.Add(this.Fonts);
            this.FontTypes.Location = new System.Drawing.Point(12, 12);
            this.FontTypes.Name = "FontTypes";
            this.FontTypes.Size = new System.Drawing.Size(194, 112);
            this.FontTypes.TabIndex = 11;
            this.FontTypes.TabStop = false;
            this.FontTypes.Text = "Tipos De Letra";
            // 
            // Fonts
            // 
            this.Fonts.FormattingEnabled = true;
            this.Fonts.Items.AddRange(new object[] {
            "Sans Serif",
            "Serif",
            "Monospace",
            "Papyrus",
            "Ravie"});
            this.Fonts.Location = new System.Drawing.Point(6, 19);
            this.Fonts.Name = "Fonts";
            this.Fonts.Size = new System.Drawing.Size(177, 82);
            this.Fonts.TabIndex = 1;
            // 
            // FontFamilyWindow
            // 
            this.AcceptButton = this.Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(218, 170);
            this.Controls.Add(this.FontTypes);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontFamilyWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FontFamilyWindow_Load);
            this.FontTypes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox FontTypes;
        private System.Windows.Forms.ListBox Fonts;
    }
}