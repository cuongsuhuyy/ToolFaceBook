namespace ToolFaceBook02
{
    partial class FromCauHinh
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
            this.btn_ChromeDriver = new System.Windows.Forms.Button();
            this.tb_ChromeDriver = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ChromeDriver
            // 
            this.btn_ChromeDriver.Location = new System.Drawing.Point(12, 12);
            this.btn_ChromeDriver.Name = "btn_ChromeDriver";
            this.btn_ChromeDriver.Size = new System.Drawing.Size(132, 57);
            this.btn_ChromeDriver.TabIndex = 1;
            this.btn_ChromeDriver.Text = "Đường dẫn\r\nchrome driver\r\n";
            this.btn_ChromeDriver.UseVisualStyleBackColor = true;
            this.btn_ChromeDriver.Click += new System.EventHandler(this.btn_ChromeDriver_Click);
            // 
            // tb_ChromeDriver
            // 
            this.tb_ChromeDriver.Location = new System.Drawing.Point(150, 29);
            this.tb_ChromeDriver.Name = "tb_ChromeDriver";
            this.tb_ChromeDriver.ReadOnly = true;
            this.tb_ChromeDriver.Size = new System.Drawing.Size(357, 22);
            this.tb_ChromeDriver.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(319, 380);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // FromCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_ChromeDriver);
            this.Controls.Add(this.btn_ChromeDriver);
            this.Name = "FromCauHinh";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FromCauHinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ChromeDriver;
        private System.Windows.Forms.TextBox tb_ChromeDriver;
        private System.Windows.Forms.Button btn_save;
    }
}