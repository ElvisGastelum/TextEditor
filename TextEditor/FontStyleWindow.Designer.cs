namespace TextEditor
{
    partial class FontStyleWindow
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
            this.Options = new System.Windows.Forms.GroupBox();
            this.Subrayado = new System.Windows.Forms.CheckBox();
            this.Negrita = new System.Windows.Forms.CheckBox();
            this.Cursiva = new System.Windows.Forms.CheckBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Accept = new System.Windows.Forms.Button();
            this.Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // Options
            // 
            this.Options.Controls.Add(this.Subrayado);
            this.Options.Controls.Add(this.Negrita);
            this.Options.Controls.Add(this.Cursiva);
            this.Options.Location = new System.Drawing.Point(12, 12);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(189, 117);
            this.Options.TabIndex = 10;
            this.Options.TabStop = false;
            this.Options.Text = "Opciones De Letra";
            // 
            // Subrayado
            // 
            this.Subrayado.AutoSize = true;
            this.Subrayado.Location = new System.Drawing.Point(27, 42);
            this.Subrayado.Name = "Subrayado";
            this.Subrayado.Size = new System.Drawing.Size(77, 17);
            this.Subrayado.TabIndex = 3;
            this.Subrayado.Text = "Subrayada";
            this.Subrayado.UseVisualStyleBackColor = true;
            // 
            // Negrita
            // 
            this.Negrita.AutoSize = true;
            this.Negrita.Location = new System.Drawing.Point(28, 19);
            this.Negrita.Name = "Negrita";
            this.Negrita.Size = new System.Drawing.Size(60, 17);
            this.Negrita.TabIndex = 2;
            this.Negrita.Text = "Negrita";
            this.Negrita.UseVisualStyleBackColor = true;
            // 
            // Cursiva
            // 
            this.Cursiva.AutoSize = true;
            this.Cursiva.Location = new System.Drawing.Point(27, 65);
            this.Cursiva.Name = "Cursiva";
            this.Cursiva.Size = new System.Drawing.Size(61, 17);
            this.Cursiva.TabIndex = 4;
            this.Cursiva.Text = "Cursiva";
            this.Cursiva.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(141, 145);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelClick);
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(60, 145);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 11;
            this.Accept.Text = "Aceptar";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.AcceptClick);
            // 
            // FontStyleWindow
            // 
            this.AcceptButton = this.Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(226, 179);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Controls.Add(this.Options);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontStyleWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FontStyleWindow_Load);
            this.Options.ResumeLayout(false);
            this.Options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Options;
        private System.Windows.Forms.CheckBox Subrayado;
        private System.Windows.Forms.CheckBox Negrita;
        private System.Windows.Forms.CheckBox Cursiva;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Accept;
    }
}