namespace ToolFaceBook02
{
    partial class FormCauHinh
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
            this.btn_Path = new System.Windows.Forms.Button();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lb_statusSave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Path
            // 
            this.btn_Path.Location = new System.Drawing.Point(36, 32);
            this.btn_Path.Name = "btn_Path";
            this.btn_Path.Size = new System.Drawing.Size(75, 23);
            this.btn_Path.TabIndex = 0;
            this.btn_Path.Text = "Path:";
            this.btn_Path.UseVisualStyleBackColor = true;
            this.btn_Path.Click += new System.EventHandler(this.btn_Path_Click);
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(129, 32);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.Size = new System.Drawing.Size(320, 22);
            this.tb_Path.TabIndex = 1;
            this.tb_Path.Text = "D:\\RAR\\ChromeDriver_x86\\chromedriver_win32";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(374, 385);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "SAVE";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lb_statusSave
            // 
            this.lb_statusSave.AutoSize = true;
            this.lb_statusSave.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_statusSave.Location = new System.Drawing.Point(293, 411);
            this.lb_statusSave.Name = "lb_statusSave";
            this.lb_statusSave.Size = new System.Drawing.Size(0, 17);
            this.lb_statusSave.TabIndex = 3;
            // 
            // FormCauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_statusSave);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Path);
            this.Controls.Add(this.btn_Path);
            this.Name = "FormCauHinh";
            this.Text = "FormCauHinh";
            this.Load += new System.EventHandler(this.FormCauHinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Path;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lb_statusSave;
    }
}