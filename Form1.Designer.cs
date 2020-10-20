namespace ToolFaceBook02
{
    partial class Form1
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
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.lb_CountLoop = new System.Windows.Forms.Label();
            this.lb_CheckStatusStory = new System.Windows.Forms.Label();
            this.btn_StopStory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(21, 54);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(73, 17);
            this.lb_Password.TabIndex = 0;
            this.lb_Password.Text = "Password:";
            // 
            // lb_UserName
            // 
            this.lb_UserName.AutoSize = true;
            this.lb_UserName.Location = new System.Drawing.Point(21, 18);
            this.lb_UserName.Name = "lb_UserName";
            this.lb_UserName.Size = new System.Drawing.Size(79, 17);
            this.lb_UserName.TabIndex = 1;
            this.lb_UserName.Text = "UserName:";
            // 
            // tb_UserName
            // 
            this.tb_UserName.Location = new System.Drawing.Point(107, 12);
            this.tb_UserName.Name = "tb_UserName";
            this.tb_UserName.Size = new System.Drawing.Size(100, 22);
            this.tb_UserName.TabIndex = 2;
            this.tb_UserName.Text = "cuongsu0072013@yahoo.com";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(107, 48);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(100, 22);
            this.tb_Password.TabIndex = 3;
            this.tb_Password.Text = "khongbiet";
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Location = new System.Drawing.Point(24, 89);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(136, 47);
            this.btn_SignIn.TabIndex = 4;
            this.btn_SignIn.Text = "Đăng Nhập";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // lb_CountLoop
            // 
            this.lb_CountLoop.AutoSize = true;
            this.lb_CountLoop.Location = new System.Drawing.Point(298, 54);
            this.lb_CountLoop.Name = "lb_CountLoop";
            this.lb_CountLoop.Size = new System.Drawing.Size(46, 17);
            this.lb_CountLoop.TabIndex = 5;
            this.lb_CountLoop.Text = "label1";
            // 
            // lb_CheckStatusStory
            // 
            this.lb_CheckStatusStory.AutoSize = true;
            this.lb_CheckStatusStory.Location = new System.Drawing.Point(381, 18);
            this.lb_CheckStatusStory.Name = "lb_CheckStatusStory";
            this.lb_CheckStatusStory.Size = new System.Drawing.Size(110, 17);
            this.lb_CheckStatusStory.TabIndex = 6;
            this.lb_CheckStatusStory.Text = "Running Story...";
            // 
            // btn_StopStory
            // 
            this.btn_StopStory.Location = new System.Drawing.Point(251, 113);
            this.btn_StopStory.Name = "btn_StopStory";
            this.btn_StopStory.Size = new System.Drawing.Size(136, 44);
            this.btn_StopStory.TabIndex = 7;
            this.btn_StopStory.Text = "Stop Run Story";
            this.btn_StopStory.UseVisualStyleBackColor = true;
            this.btn_StopStory.Click += new System.EventHandler(this.btn_StopStory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(443, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(17, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_StopStory);
            this.Controls.Add(this.lb_CheckStatusStory);
            this.Controls.Add(this.lb_CountLoop);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_UserName);
            this.Controls.Add(this.lb_UserName);
            this.Controls.Add(this.lb_Password);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_UserName;
        private System.Windows.Forms.TextBox tb_UserName;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Label lb_CountLoop;
        private System.Windows.Forms.Label lb_CheckStatusStory;
        private System.Windows.Forms.Button btn_StopStory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

