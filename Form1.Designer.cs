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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_UserName = new System.Windows.Forms.Label();
            this.tb_UserName = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.lb_CountLoop = new System.Windows.Forms.Label();
            this.lb_CheckStatusStory = new System.Windows.Forms.Label();
            this.btn_StopStory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Like = new System.Windows.Forms.PictureBox();
            this.Heart = new System.Windows.Forms.PictureBox();
            this.ThuongThuong = new System.Windows.Forms.PictureBox();
            this.Haha = new System.Windows.Forms.PictureBox();
            this.WOW = new System.Windows.Forms.PictureBox();
            this.SAD = new System.Windows.Forms.PictureBox();
            this.Angry = new System.Windows.Forms.PictureBox();
            this.chbtn_Like = new System.Windows.Forms.CheckBox();
            this.chbtn_Tym = new System.Windows.Forms.CheckBox();
            this.chbtn_ThuongThuong = new System.Windows.Forms.CheckBox();
            this.chbtn_HAHA = new System.Windows.Forms.CheckBox();
            this.chbtn_WOW = new System.Windows.Forms.CheckBox();
            this.chbtn_Sad = new System.Windows.Forms.CheckBox();
            this.chbtn_Angry = new System.Windows.Forms.CheckBox();
            this.tb_Like = new System.Windows.Forms.TextBox();
            this.tb_Tym = new System.Windows.Forms.TextBox();
            this.tb_ThuongThuong = new System.Windows.Forms.TextBox();
            this.tb_HAHA = new System.Windows.Forms.TextBox();
            this.tb_WOW = new System.Windows.Forms.TextBox();
            this.tb_Sad = new System.Windows.Forms.TextBox();
            this.tb_Angry = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuongThuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Haha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WOW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angry)).BeginInit();
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
            this.groupBox1.Controls.Add(this.tb_Angry);
            this.groupBox1.Controls.Add(this.tb_Sad);
            this.groupBox1.Controls.Add(this.tb_WOW);
            this.groupBox1.Controls.Add(this.tb_HAHA);
            this.groupBox1.Controls.Add(this.tb_ThuongThuong);
            this.groupBox1.Controls.Add(this.tb_Tym);
            this.groupBox1.Controls.Add(this.tb_Like);
            this.groupBox1.Controls.Add(this.chbtn_Angry);
            this.groupBox1.Controls.Add(this.chbtn_Sad);
            this.groupBox1.Controls.Add(this.chbtn_WOW);
            this.groupBox1.Controls.Add(this.chbtn_HAHA);
            this.groupBox1.Controls.Add(this.chbtn_ThuongThuong);
            this.groupBox1.Controls.Add(this.chbtn_Tym);
            this.groupBox1.Controls.Add(this.chbtn_Like);
            this.groupBox1.Controls.Add(this.Angry);
            this.groupBox1.Controls.Add(this.SAD);
            this.groupBox1.Controls.Add(this.WOW);
            this.groupBox1.Controls.Add(this.Haha);
            this.groupBox1.Controls.Add(this.ThuongThuong);
            this.groupBox1.Controls.Add(this.Heart);
            this.groupBox1.Controls.Add(this.Like);
            this.groupBox1.Location = new System.Drawing.Point(497, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 285);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thả Story";
            // 
            // Like
            // 
            this.Like.Image = ((System.Drawing.Image)(resources.GetObject("Like.Image")));
            this.Like.Location = new System.Drawing.Point(29, 33);
            this.Like.Name = "Like";
            this.Like.Size = new System.Drawing.Size(27, 27);
            this.Like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Like.TabIndex = 0;
            this.Like.TabStop = false;
            // 
            // Heart
            // 
            this.Heart.Image = ((System.Drawing.Image)(resources.GetObject("Heart.Image")));
            this.Heart.Location = new System.Drawing.Point(29, 66);
            this.Heart.Name = "Heart";
            this.Heart.Size = new System.Drawing.Size(27, 27);
            this.Heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Heart.TabIndex = 1;
            this.Heart.TabStop = false;
            // 
            // ThuongThuong
            // 
            this.ThuongThuong.Image = ((System.Drawing.Image)(resources.GetObject("ThuongThuong.Image")));
            this.ThuongThuong.Location = new System.Drawing.Point(29, 99);
            this.ThuongThuong.Name = "ThuongThuong";
            this.ThuongThuong.Size = new System.Drawing.Size(27, 27);
            this.ThuongThuong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ThuongThuong.TabIndex = 2;
            this.ThuongThuong.TabStop = false;
            // 
            // Haha
            // 
            this.Haha.Image = ((System.Drawing.Image)(resources.GetObject("Haha.Image")));
            this.Haha.Location = new System.Drawing.Point(29, 132);
            this.Haha.Name = "Haha";
            this.Haha.Size = new System.Drawing.Size(27, 27);
            this.Haha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Haha.TabIndex = 3;
            this.Haha.TabStop = false;
            // 
            // WOW
            // 
            this.WOW.Image = ((System.Drawing.Image)(resources.GetObject("WOW.Image")));
            this.WOW.Location = new System.Drawing.Point(29, 165);
            this.WOW.Name = "WOW";
            this.WOW.Size = new System.Drawing.Size(27, 27);
            this.WOW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WOW.TabIndex = 4;
            this.WOW.TabStop = false;
            // 
            // SAD
            // 
            this.SAD.Image = ((System.Drawing.Image)(resources.GetObject("SAD.Image")));
            this.SAD.Location = new System.Drawing.Point(29, 198);
            this.SAD.Name = "SAD";
            this.SAD.Size = new System.Drawing.Size(27, 27);
            this.SAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SAD.TabIndex = 5;
            this.SAD.TabStop = false;
            // 
            // Angry
            // 
            this.Angry.Image = ((System.Drawing.Image)(resources.GetObject("Angry.Image")));
            this.Angry.Location = new System.Drawing.Point(29, 231);
            this.Angry.Name = "Angry";
            this.Angry.Size = new System.Drawing.Size(27, 27);
            this.Angry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Angry.TabIndex = 6;
            this.Angry.TabStop = false;
            // 
            // chbtn_Like
            // 
            this.chbtn_Like.AutoSize = true;
            this.chbtn_Like.Location = new System.Drawing.Point(62, 39);
            this.chbtn_Like.Name = "chbtn_Like";
            this.chbtn_Like.Size = new System.Drawing.Size(65, 21);
            this.chbtn_Like.TabIndex = 7;
            this.chbtn_Like.Text = "Thích";
            this.chbtn_Like.UseVisualStyleBackColor = true;
            // 
            // chbtn_Tym
            // 
            this.chbtn_Tym.AutoSize = true;
            this.chbtn_Tym.Location = new System.Drawing.Point(62, 71);
            this.chbtn_Tym.Name = "chbtn_Tym";
            this.chbtn_Tym.Size = new System.Drawing.Size(82, 21);
            this.chbtn_Tym.TabIndex = 8;
            this.chbtn_Tym.Text = "Thả Tim";
            this.chbtn_Tym.UseVisualStyleBackColor = true;
            // 
            // chbtn_ThuongThuong
            // 
            this.chbtn_ThuongThuong.AutoSize = true;
            this.chbtn_ThuongThuong.Location = new System.Drawing.Point(62, 104);
            this.chbtn_ThuongThuong.Name = "chbtn_ThuongThuong";
            this.chbtn_ThuongThuong.Size = new System.Drawing.Size(132, 21);
            this.chbtn_ThuongThuong.TabIndex = 9;
            this.chbtn_ThuongThuong.Text = "Thương Thương";
            this.chbtn_ThuongThuong.UseVisualStyleBackColor = true;
            // 
            // chbtn_HAHA
            // 
            this.chbtn_HAHA.AutoSize = true;
            this.chbtn_HAHA.Location = new System.Drawing.Point(63, 137);
            this.chbtn_HAHA.Name = "chbtn_HAHA";
            this.chbtn_HAHA.Size = new System.Drawing.Size(68, 21);
            this.chbtn_HAHA.TabIndex = 10;
            this.chbtn_HAHA.Text = "HAHA";
            this.chbtn_HAHA.UseVisualStyleBackColor = true;
            // 
            // chbtn_WOW
            // 
            this.chbtn_WOW.AutoSize = true;
            this.chbtn_WOW.Location = new System.Drawing.Point(63, 170);
            this.chbtn_WOW.Name = "chbtn_WOW";
            this.chbtn_WOW.Size = new System.Drawing.Size(67, 21);
            this.chbtn_WOW.TabIndex = 11;
            this.chbtn_WOW.Text = "WOW";
            this.chbtn_WOW.UseVisualStyleBackColor = true;
            // 
            // chbtn_Sad
            // 
            this.chbtn_Sad.AutoSize = true;
            this.chbtn_Sad.Location = new System.Drawing.Point(63, 204);
            this.chbtn_Sad.Name = "chbtn_Sad";
            this.chbtn_Sad.Size = new System.Drawing.Size(58, 21);
            this.chbtn_Sad.TabIndex = 12;
            this.chbtn_Sad.Text = "SAD";
            this.chbtn_Sad.UseVisualStyleBackColor = true;
            // 
            // chbtn_Angry
            // 
            this.chbtn_Angry.AutoSize = true;
            this.chbtn_Angry.Location = new System.Drawing.Point(63, 236);
            this.chbtn_Angry.Name = "chbtn_Angry";
            this.chbtn_Angry.Size = new System.Drawing.Size(67, 21);
            this.chbtn_Angry.TabIndex = 13;
            this.chbtn_Angry.Text = "Angry";
            this.chbtn_Angry.UseVisualStyleBackColor = true;
            // 
            // tb_Like
            // 
            this.tb_Like.Location = new System.Drawing.Point(201, 37);
            this.tb_Like.Name = "tb_Like";
            this.tb_Like.Size = new System.Drawing.Size(100, 22);
            this.tb_Like.TabIndex = 14;
            this.tb_Like.Text = "Số Lần thả";
            // 
            // tb_Tym
            // 
            this.tb_Tym.Location = new System.Drawing.Point(201, 71);
            this.tb_Tym.Name = "tb_Tym";
            this.tb_Tym.Size = new System.Drawing.Size(100, 22);
            this.tb_Tym.TabIndex = 15;
            this.tb_Tym.Text = "Số Lần thả";
            // 
            // tb_ThuongThuong
            // 
            this.tb_ThuongThuong.Location = new System.Drawing.Point(200, 104);
            this.tb_ThuongThuong.Name = "tb_ThuongThuong";
            this.tb_ThuongThuong.Size = new System.Drawing.Size(100, 22);
            this.tb_ThuongThuong.TabIndex = 16;
            this.tb_ThuongThuong.Text = "Số Lần thả";
            // 
            // tb_HAHA
            // 
            this.tb_HAHA.Location = new System.Drawing.Point(200, 137);
            this.tb_HAHA.Name = "tb_HAHA";
            this.tb_HAHA.Size = new System.Drawing.Size(100, 22);
            this.tb_HAHA.TabIndex = 17;
            this.tb_HAHA.Text = "Số Lần thả";
            // 
            // tb_WOW
            // 
            this.tb_WOW.Location = new System.Drawing.Point(200, 170);
            this.tb_WOW.Name = "tb_WOW";
            this.tb_WOW.Size = new System.Drawing.Size(100, 22);
            this.tb_WOW.TabIndex = 18;
            this.tb_WOW.Text = "Số Lần thả";
            // 
            // tb_Sad
            // 
            this.tb_Sad.Location = new System.Drawing.Point(200, 202);
            this.tb_Sad.Name = "tb_Sad";
            this.tb_Sad.Size = new System.Drawing.Size(100, 22);
            this.tb_Sad.TabIndex = 19;
            this.tb_Sad.Text = "Số Lần thả";
            // 
            // tb_Angry
            // 
            this.tb_Angry.Location = new System.Drawing.Point(200, 236);
            this.tb_Angry.Name = "tb_Angry";
            this.tb_Angry.Size = new System.Drawing.Size(100, 22);
            this.tb_Angry.TabIndex = 20;
            this.tb_Angry.Text = "Số Lần thả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 553);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThuongThuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Haha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WOW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Angry)).EndInit();
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
        private System.Windows.Forms.PictureBox Like;
        private System.Windows.Forms.TextBox tb_Angry;
        private System.Windows.Forms.TextBox tb_Sad;
        private System.Windows.Forms.TextBox tb_WOW;
        private System.Windows.Forms.TextBox tb_HAHA;
        private System.Windows.Forms.TextBox tb_ThuongThuong;
        private System.Windows.Forms.TextBox tb_Tym;
        private System.Windows.Forms.TextBox tb_Like;
        private System.Windows.Forms.CheckBox chbtn_Angry;
        private System.Windows.Forms.CheckBox chbtn_Sad;
        private System.Windows.Forms.CheckBox chbtn_WOW;
        private System.Windows.Forms.CheckBox chbtn_HAHA;
        private System.Windows.Forms.CheckBox chbtn_ThuongThuong;
        private System.Windows.Forms.CheckBox chbtn_Tym;
        private System.Windows.Forms.CheckBox chbtn_Like;
        private System.Windows.Forms.PictureBox Angry;
        private System.Windows.Forms.PictureBox SAD;
        private System.Windows.Forms.PictureBox WOW;
        private System.Windows.Forms.PictureBox Haha;
        private System.Windows.Forms.PictureBox ThuongThuong;
        private System.Windows.Forms.PictureBox Heart;
    }
}

