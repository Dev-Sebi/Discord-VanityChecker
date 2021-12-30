namespace VanityChecker
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_input = new System.Windows.Forms.GroupBox();
            this.clear_input = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.RichTextBox();
            this.btn_openfile = new System.Windows.Forms.Button();
            this.btn_scan = new System.Windows.Forms.Button();
            this.gb_invalid = new System.Windows.Forms.GroupBox();
            this.clear_invalid = new System.Windows.Forms.Button();
            this.btn_invalid = new System.Windows.Forms.Button();
            this.invalid = new System.Windows.Forms.RichTextBox();
            this.gb_valid = new System.Windows.Forms.GroupBox();
            this.clear_valid = new System.Windows.Forms.Button();
            this.btn_valid = new System.Windows.Forms.Button();
            this.valid = new System.Windows.Forms.RichTextBox();
            this.gb_input.SuspendLayout();
            this.gb_invalid.SuspendLayout();
            this.gb_valid.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_input
            // 
            this.gb_input.Controls.Add(this.clear_input);
            this.gb_input.Controls.Add(this.input);
            this.gb_input.Controls.Add(this.btn_openfile);
            this.gb_input.Controls.Add(this.btn_scan);
            this.gb_input.Location = new System.Drawing.Point(12, 12);
            this.gb_input.Name = "gb_input";
            this.gb_input.Size = new System.Drawing.Size(382, 475);
            this.gb_input.TabIndex = 0;
            this.gb_input.TabStop = false;
            this.gb_input.Text = "Input";
            // 
            // clear_input
            // 
            this.clear_input.Enabled = false;
            this.clear_input.Location = new System.Drawing.Point(169, 446);
            this.clear_input.Name = "clear_input";
            this.clear_input.Size = new System.Drawing.Size(75, 23);
            this.clear_input.TabIndex = 3;
            this.clear_input.Text = "Clear";
            this.clear_input.UseVisualStyleBackColor = true;
            this.clear_input.Click += new System.EventHandler(this.clear_input_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(7, 20);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(369, 420);
            this.input.TabIndex = 0;
            this.input.Text = "";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // btn_openfile
            // 
            this.btn_openfile.Location = new System.Drawing.Point(7, 446);
            this.btn_openfile.Name = "btn_openfile";
            this.btn_openfile.Size = new System.Drawing.Size(75, 23);
            this.btn_openfile.TabIndex = 1;
            this.btn_openfile.Text = "Load File";
            this.btn_openfile.UseVisualStyleBackColor = true;
            this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
            // 
            // btn_scan
            // 
            this.btn_scan.Location = new System.Drawing.Point(88, 446);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(75, 23);
            this.btn_scan.TabIndex = 2;
            this.btn_scan.Text = "Scan Links";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.button2_Click);
            // 
            // gb_invalid
            // 
            this.gb_invalid.Controls.Add(this.clear_invalid);
            this.gb_invalid.Controls.Add(this.btn_invalid);
            this.gb_invalid.Controls.Add(this.invalid);
            this.gb_invalid.Location = new System.Drawing.Point(400, 12);
            this.gb_invalid.Name = "gb_invalid";
            this.gb_invalid.Size = new System.Drawing.Size(382, 475);
            this.gb_invalid.TabIndex = 1;
            this.gb_invalid.TabStop = false;
            this.gb_invalid.Text = "Invalid";
            // 
            // clear_invalid
            // 
            this.clear_invalid.Enabled = false;
            this.clear_invalid.Location = new System.Drawing.Point(88, 446);
            this.clear_invalid.Name = "clear_invalid";
            this.clear_invalid.Size = new System.Drawing.Size(75, 23);
            this.clear_invalid.TabIndex = 4;
            this.clear_invalid.Text = "Clear";
            this.clear_invalid.UseVisualStyleBackColor = true;
            this.clear_invalid.Click += new System.EventHandler(this.clear_invalid_Click);
            // 
            // btn_invalid
            // 
            this.btn_invalid.Location = new System.Drawing.Point(7, 446);
            this.btn_invalid.Name = "btn_invalid";
            this.btn_invalid.Size = new System.Drawing.Size(75, 23);
            this.btn_invalid.TabIndex = 3;
            this.btn_invalid.Text = "Copy Invalid";
            this.btn_invalid.UseVisualStyleBackColor = true;
            this.btn_invalid.Click += new System.EventHandler(this.btn_invalid_Click);
            // 
            // invalid
            // 
            this.invalid.Location = new System.Drawing.Point(7, 20);
            this.invalid.Name = "invalid";
            this.invalid.ReadOnly = true;
            this.invalid.Size = new System.Drawing.Size(369, 420);
            this.invalid.TabIndex = 3;
            this.invalid.Text = "";
            this.invalid.TextChanged += new System.EventHandler(this.invalid_TextChanged);
            // 
            // gb_valid
            // 
            this.gb_valid.Controls.Add(this.clear_valid);
            this.gb_valid.Controls.Add(this.btn_valid);
            this.gb_valid.Controls.Add(this.valid);
            this.gb_valid.Location = new System.Drawing.Point(788, 12);
            this.gb_valid.Name = "gb_valid";
            this.gb_valid.Size = new System.Drawing.Size(382, 475);
            this.gb_valid.TabIndex = 1;
            this.gb_valid.TabStop = false;
            this.gb_valid.Text = "Valid";
            // 
            // clear_valid
            // 
            this.clear_valid.Enabled = false;
            this.clear_valid.Location = new System.Drawing.Point(87, 445);
            this.clear_valid.Name = "clear_valid";
            this.clear_valid.Size = new System.Drawing.Size(75, 23);
            this.clear_valid.TabIndex = 5;
            this.clear_valid.Text = "Clear";
            this.clear_valid.UseVisualStyleBackColor = true;
            this.clear_valid.Click += new System.EventHandler(this.clear_valid_Click);
            // 
            // btn_valid
            // 
            this.btn_valid.Location = new System.Drawing.Point(6, 445);
            this.btn_valid.Name = "btn_valid";
            this.btn_valid.Size = new System.Drawing.Size(75, 23);
            this.btn_valid.TabIndex = 4;
            this.btn_valid.Text = "Copy Valid";
            this.btn_valid.UseVisualStyleBackColor = true;
            this.btn_valid.Click += new System.EventHandler(this.button1_Click);
            // 
            // valid
            // 
            this.valid.Location = new System.Drawing.Point(6, 19);
            this.valid.Name = "valid";
            this.valid.ReadOnly = true;
            this.valid.Size = new System.Drawing.Size(369, 420);
            this.valid.TabIndex = 4;
            this.valid.Text = "";
            this.valid.TextChanged += new System.EventHandler(this.valid_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 494);
            this.Controls.Add(this.gb_valid);
            this.Controls.Add(this.gb_invalid);
            this.Controls.Add(this.gb_input);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Discord Vanity Checker - By Sebi";
            this.gb_input.ResumeLayout(false);
            this.gb_invalid.ResumeLayout(false);
            this.gb_valid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_input;
        private System.Windows.Forms.Button btn_openfile;
        private System.Windows.Forms.Button btn_scan;
        private System.Windows.Forms.GroupBox gb_invalid;
        private System.Windows.Forms.GroupBox gb_valid;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.RichTextBox invalid;
        private System.Windows.Forms.RichTextBox valid;
        private System.Windows.Forms.Button btn_invalid;
        private System.Windows.Forms.Button btn_valid;
        private System.Windows.Forms.Button clear_input;
        private System.Windows.Forms.Button clear_invalid;
        private System.Windows.Forms.Button clear_valid;
    }
}

