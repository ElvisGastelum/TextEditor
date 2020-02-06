namespace TextEditor
{
    partial class FontSizeWindow
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
            this.FontSize = new System.Windows.Forms.GroupBox();
            this.SizeSmall = new System.Windows.Forms.RadioButton();
            this.SizeBig = new System.Windows.Forms.RadioButton();
            this.SizeMedium = new System.Windows.Forms.RadioButton();
            this.Cancel = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.FontSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // FontSize
            // 
            this.FontSize.Controls.Add(this.SizeSmall);
            this.FontSize.Controls.Add(this.SizeBig);
            this.FontSize.Controls.Add(this.SizeMedium);
            this.FontSize.Location = new System.Drawing.Point(12, 12);
            this.FontSize.Name = "FontSize";
            this.FontSize.Size = new System.Drawing.Size(194, 109);
            this.FontSize.TabIndex = 9;
            this.FontSize.TabStop = false;
            this.FontSize.Text = "Tamaños De Letra";
            // 
            // SizeSmall
            // 
            this.SizeSmall.AutoSize = true;
            this.SizeSmall.Location = new System.Drawing.Point(28, 20);
            this.SizeSmall.Name = "SizeSmall";
            this.SizeSmall.Size = new System.Drawing.Size(79, 17);
            this.SizeSmall.TabIndex = 5;
            this.SizeSmall.Text = "Letra Chica";
            this.SizeSmall.UseVisualStyleBackColor = true;
            // 
            // SizeBig
            // 
            this.SizeBig.AutoSize = true;
            this.SizeBig.Location = new System.Drawing.Point(28, 66);
            this.SizeBig.Name = "SizeBig";
            this.SizeBig.Size = new System.Drawing.Size(87, 17);
            this.SizeBig.TabIndex = 7;
            this.SizeBig.TabStop = true;
            this.SizeBig.Text = "Letra Grande";
            this.SizeBig.UseVisualStyleBackColor = true;
            // 
            // SizeMedium
            // 
            this.SizeMedium.AutoSize = true;
            this.SizeMedium.Location = new System.Drawing.Point(28, 43);
            this.SizeMedium.Name = "SizeMedium";
            this.SizeMedium.Size = new System.Drawing.Size(93, 17);
            this.SizeMedium.TabIndex = 6;
            this.SizeMedium.Text = "Letra Mediana";
            this.SizeMedium.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(139, 137);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(58, 137);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 13;
            this.Accept.Text = "Aceptar";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.AcceptClick);
            // 
            // FontSizeWindow
            // 
            this.AcceptButton = this.Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(226, 172);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.FontSize);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontSizeWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FontSizeWindow_Load);
            this.FontSize.ResumeLayout(false);
            this.FontSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FontSize;
        private System.Windows.Forms.RadioButton SizeSmall;
        private System.Windows.Forms.RadioButton SizeBig;
        private System.Windows.Forms.RadioButton SizeMedium;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Accept;
    }
}