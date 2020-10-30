using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ToolFaceBook02
{
    public partial class FormMain : Form
    {
        DataProvider.KhoiTao KT;
        

        ThreadStart ts_gmail;
        Thread thrd_gmail;

        
        public FormMain()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            KT = new DataProvider.KhoiTao();
            lb_CheckStatusStory.Text = KT.Flag_Check_thread_is_running_Story.ToString();

            ts_gmail = new ThreadStart(TaoTKGmail);
            thrd_gmail = new Thread(ts_gmail);

            //Disable Story
            #region "Disable Story"
            tb_VongLapStory.Enabled = false;
            tb_Like.Enabled = false;
            tb_Tym.Enabled = false;
            tb_ThuongThuong.Enabled = false;
            tb_Sad.Enabled = false;
            tb_HAHA.Enabled = false;
            tb_WOW.Enabled = false;
            tb_Angry.Enabled = false;
            btn_StopStory.Enabled = false;
            chbtn_Like.Enabled = false;
            chbtn_HAHA.Enabled = false;
            chbtn_Sad.Enabled = false;
            chbtn_ThuongThuong.Enabled = false;
            chbtn_Tym.Enabled = false;
            chbtn_Angry.Enabled = false;
            chbtn_WOW.Enabled = false;
            label6.Enabled = false;
            lb_CheckStatusStory.Enabled = false;
            lb_CountLoop.Enabled = false;
            #endregion

            //Disable NewFeeds
            #region "Disable NewFeeds"
            tb_SoLanLuotNF.Enabled = false;
            label7.Enabled = false;
            lb_soLanLuotNF.Enabled = false;
            #endregion
        }

        void Run()
        {
            String chromeDriverPath = KT.Path;
            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            options.AddArguments("--disable-notifications");

            var driver = new ChromeDriver(chromeDriverPath, options, TimeSpan.FromDays(20));
            string url = "https://www.facebook.com/";
            driver.Url = url;
            driver.Navigate().GoToUrl(url);

            //Khoi Tao
            while (KT.Flag_wait_forresponse == true)
            {
                try
                {
                    IWebElement UserName = driver.FindElement(By.CssSelector("input[type='text']"));
                    UserName.SendKeys(tb_UserName.Text);

                    IWebElement Password = driver.FindElement(By.CssSelector("input[type='password']"));
                    Password.SendKeys(tb_Password.Text);

                    IWebElement sign_in = driver.FindElement(By.CssSelector("button[name='login']"));
                    sign_in.Click();

                    KT.Flag_wait_forresponse = false;
                }
                catch
                {
                    break;
                }
            }
            KT.Flag_wait_forresponse = true;

            ////Trang chu
            //while (flag_wait_forresponse == true)
            //{
            //    try
            //    {
            //        IWebElement TrangChu = driver.FindElement(By.CssSelector("div[id='u_0_c']"));
            //        TrangChu.Click();
            //        flag_wait_forresponse = false;
            //    }
            //    catch
            //    {
            //    }
            //}
            //flag_wait_forresponse = true;

            ////Messenger
            //while (flag_wait_forresponse == true)
            //{
            //    try
            //    {
            //        IWebElement Mess = driver.FindElement(By.CssSelector("a[data-testid='left_nav_item_Messenger']"));
            //        Mess.Click();
            //        flag_wait_forresponse = false;
            //    }
            //    catch
            //    { }
            //}
            //flag_wait_forresponse = true;

            ////HoangTrong
            //while (flag_wait_forresponse == true)
            //{
            //    try
            //    {
            //        IWebElement ClickChon = driver.FindElement(By.CssSelector("div[data-tooltip-content='Hoàng Trọng']"));
            //        ClickChon.Click();
            //        flag_wait_forresponse = false;
            //    }
            //    catch
            //    { }
            //}
            //flag_wait_forresponse = true;

            ////SendMess
            //for (int u = 0; u < 100; u++)
            //{
            //    while (flag_wait_forresponse == true)
            //    {
            //        try
            //        {
            //            IWebElement SendMess = driver.FindElement(By.CssSelector("div[aria-label='Nhập tin nhắn...']"));
            //            SendMess.SendKeys("SendMess.SendKeys(######### (Đây là tin nhắn trả lời tự động));");
            //            flag_wait_forresponse = false;
            //        }
            //        catch
            //        { }
            //    }
            //    flag_wait_forresponse = true;


            //    //EnterMess
            //    while (flag_wait_forresponse == true)
            //    {
            //        try
            //        {
            //            IWebElement EnterMess = driver.FindElement(By.CssSelector("a[aria-label='Gửi']"));
            //            EnterMess.Click();
            //            flag_wait_forresponse = false;
            //        }
            //        catch
            //        { }
            //    }
            //    flag_wait_forresponse = true;
            //}

            //flag_wait_forresponse = false;

            //Kt watchStory co duoc check hay khong
            if(chbtn_EnableStory.Checked)
            {
                //Watch Story
                while (KT.Flag_wait_forresponse == true)
                {
                    try
                    {
                        IWebElement WatchStory = driver.FindElement(By.CssSelector("div[aria-label='Tin']"));
                        WatchStory.Click();
                        KT.Flag_wait_forresponse = false;
                    }
                    catch
                    {
                        try
                        {
                            IWebElement WatchStory02 = driver.FindElement(By.CssSelector("div[id='js_u']"));
                            WatchStory02.Click();
                        }
                        catch { }
                    }
                }
                KT.Flag_wait_forresponse = true;

                //Pause Story
                while (KT.Flag_wait_forresponse == true)
                {
                    try
                    {
                        IWebElement PauseStory = driver.FindElement(By.CssSelector("div[aria-label='Phát']"));
                        PauseStory.Click();
                        KT.Flag_wait_forresponse = false;
                    }
                    catch
                    {
                        try
                        {
                            IWebElement PauseStory = driver.FindElement(By.CssSelector("div[aria-label='Tạm dừng']"));
                            PauseStory.Click();
                            KT.Flag_wait_forresponse = false;
                        }
                        catch
                        {
                        }
                    }
                }
                KT.Flag_wait_forresponse = true;

                try
                {
                    try
                    {
                        for (KT.SoLan_Like1 = 0; KT.SoLan_Like1 < int.Parse(tb_Like.Text); KT.SoLan_Like1++)
                        {
                            if (chbtn_Like.Checked)
                            {
                                IWebElement Thich = driver.FindElement(By.CssSelector("span[aria-label='Thích']"));
                                Thich.Click();
                                Thread.Sleep(500);
                            }
                        }
                    }
                    catch { } //Like
                    try
                    {
                        for (KT.SoLan_Tym1 = 0; KT.SoLan_Tym1 < int.Parse(tb_Tym.Text); KT.SoLan_Tym1++)
                        {
                            if (chbtn_Tym.Checked)
                            {
                                IWebElement Yeu_Thich = driver.FindElement(By.CssSelector("span[aria-label='Yêu thích']"));
                                Yeu_Thich.Click();
                                Thread.Sleep(500);
                            }
                        }
                    }
                    catch { } //Tym
                    try
                    {
                        for (KT.SoLan_ThuongThuong1 = 0; KT.SoLan_ThuongThuong1 < int.Parse(tb_ThuongThuong.Text); KT.SoLan_ThuongThuong1++)
                        {
                            if (chbtn_ThuongThuong.Checked)
                            {
                                IWebElement ThuongThuong = driver.FindElement(By.CssSelector("span[aria-label='Thương thương']"));
                                ThuongThuong.Click();
                                Thread.Sleep(500);
                            }
                        }
                    }
                    catch { } //ThuongThuong
                    try
                    {
                        for (KT.SoLan_HAHA1 = 0; KT.SoLan_HAHA1 < int.Parse(tb_HAHA.Text); KT.SoLan_HAHA1++)
                        {
                            if (chbtn_HAHA.Checked)
                            {
                                IWebElement HAHA = driver.FindElement(By.CssSelector("span[aria-label='Haha']"));
                                HAHA.Click();
                                Thread.Sleep(500);
                            }
                        }
                    }
                    catch { } //HAHA
                    try
                    {
                        for (KT.SoLan_WOW1 = 0; KT.SoLan_WOW1 < int.Parse(tb_WOW.Text); KT.SoLan_WOW1++)
                        {
                            if (chbtn_WOW.Checked)
                            {
                                IWebElement WOW = driver.FindElement(By.CssSelector("span[aria-label='Wow']"));
                                WOW.Click();
                                Thread.Sleep(500);
                            }
                        }
                    }
                    catch { } //WOW
                    try
                    {
                        for (KT.SoLan_Sad1 = 0; KT.SoLan_Sad1 < int.Parse(tb_Sad.Text); KT.SoLan_Sad1++)
                        {
                            if (chbtn_Sad.Checked)
                            {
                                IWebElement SAD = driver.FindElement(By.CssSelector("span[aria-label='Buồn']"));
                                SAD.Click();
                                Thread.Sleep(500);
                            }
                        }
                    }
                    catch { } //Sad
                    try
                    {
                        for (KT.SoLan_PhanNo1 = 0; KT.SoLan_PhanNo1 < int.Parse(tb_Angry.Text); KT.SoLan_PhanNo1++)
                        {
                            if (chbtn_Angry.Checked)
                            {
                                IWebElement Angry = driver.FindElement(By.CssSelector("span[aria-label='Phẫn nộ']"));
                                Angry.Click();
                                Thread.Sleep(500);
                            }
                        }
                    }
                    catch { } //Angry
                }
                catch { } //Tha Status Story      

                for (int i = 0; i < KT.VongLapStory1; i++)
                {
                    while (KT.Flag_wait_forresponse == true)
                    {
                        try
                        {
                            IWebElement NextStory = driver.FindElement(By.CssSelector("div[aria-label='Nút Tin tiếp theo']"));
                            NextStory.Click();
                            KT.Flag_wait_forresponse = false;
                        }
                        catch
                        {
                            try
                            {
                                IWebElement NextStory = driver.FindElement(By.CssSelector("div[aria-label='Nút thẻ tiếp theo']"));
                                NextStory.Click();
                                KT.Flag_wait_forresponse = false;
                            }
                            catch
                            { }
                        }
                    } //Nut tin tiep theo
                    KT.Flag_wait_forresponse = true;

                    while (KT.Flag_wait_forresponse == true)
                    {
                        try
                        {
                            IWebElement PauseStory = driver.FindElement(By.CssSelector("div[aria-label='Phát']"));
                            PauseStory.Click();
                            Thread.Sleep(1000);
                            KT.Flag_wait_forresponse = false;
                        }
                        catch
                        {
                            try
                            {
                                IWebElement PauseStory = driver.FindElement(By.CssSelector("div[aria-label='Tạm dừng']"));
                                PauseStory.Click();
                                KT.Flag_wait_forresponse = false;
                            }
                            catch { }
                        }
                    } //Phat/tam dung story
                    KT.Flag_wait_forresponse = true;

                    try
                    {
                        try
                        {
                            for (KT.SoLan_Like1 = 0; KT.SoLan_Like1 < int.Parse(tb_Like.Text); KT.SoLan_Like1++)
                            {
                                if (chbtn_Like.Checked)
                                {
                                    IWebElement Thich = driver.FindElement(By.CssSelector("span[aria-label='Thích']"));
                                    Thich.Click();
                                    Thread.Sleep(500);
                                }
                            }
                        }
                        catch { } //Like
                        try
                        {
                            for (KT.SoLan_Tym1 = 0; KT.SoLan_Tym1 < int.Parse(tb_Tym.Text); KT.SoLan_Tym1++)
                            {
                                if (chbtn_Tym.Checked)
                                {
                                    IWebElement Yeu_Thich = driver.FindElement(By.CssSelector("span[aria-label='Yêu thích']"));
                                    Yeu_Thich.Click();
                                    Thread.Sleep(500);
                                }
                            }
                        }
                        catch { } //Tym
                        try
                        {
                            for (KT.SoLan_ThuongThuong1 = 0; KT.SoLan_ThuongThuong1 < int.Parse(tb_ThuongThuong.Text); KT.SoLan_ThuongThuong1++)
                            {
                                if (chbtn_ThuongThuong.Checked)
                                {
                                    IWebElement ThuongThuong = driver.FindElement(By.CssSelector("span[aria-label='Thương thương']"));
                                    ThuongThuong.Click();
                                    Thread.Sleep(500);
                                }
                            }
                        }
                        catch { } //ThuongThuong
                        try
                        {
                            for (KT.SoLan_HAHA1 = 0; KT.SoLan_HAHA1 < int.Parse(tb_HAHA.Text); KT.SoLan_HAHA1++)
                            {
                                if (chbtn_HAHA.Checked)
                                {
                                    IWebElement HAHA = driver.FindElement(By.CssSelector("span[aria-label='Haha']"));
                                    HAHA.Click();
                                    Thread.Sleep(500);
                                }
                            }
                        }
                        catch { } //HAHA
                        try
                        {
                            for (KT.SoLan_WOW1 = 0; KT.SoLan_WOW1 < int.Parse(tb_WOW.Text); KT.SoLan_WOW1++)
                            {
                                if (chbtn_WOW.Checked)
                                {
                                    IWebElement WOW = driver.FindElement(By.CssSelector("span[aria-label='Wow']"));
                                    WOW.Click();
                                    Thread.Sleep(500);
                                }
                            }
                        }
                        catch { } //WOW
                        try
                        {
                            for (KT.SoLan_Sad1 = 0; KT.SoLan_Sad1 < int.Parse(tb_Sad.Text); KT.SoLan_Sad1++)
                            {
                                if (chbtn_Sad.Checked)
                                {
                                    IWebElement SAD = driver.FindElement(By.CssSelector("span[aria-label='Buồn']"));
                                    SAD.Click();
                                    Thread.Sleep(500);
                                }
                            }
                        }
                        catch { } //Sad
                        try
                        {
                            for (KT.SoLan_PhanNo1 = 0; KT.SoLan_PhanNo1 < int.Parse(tb_Angry.Text); KT.SoLan_PhanNo1++)
                            {
                                if (chbtn_Angry.Checked)
                                {
                                    IWebElement Angry = driver.FindElement(By.CssSelector("span[aria-label='Phẫn nộ']"));
                                    Angry.Click();
                                    Thread.Sleep(500);
                                }
                            }
                        }
                        catch { } //Angry
                    }
                    catch { } //Tha Status Story    
                    lb_CountLoop.Text = i.ToString();
                } //Vong lap Story
                KT.Flag_Check_thread_is_running_Story = true;

                //Close Story
                while (KT.Flag_wait_forresponse == true)
                {
                    try
                    {
                        IWebElement CloseStory = driver.FindElement(By.CssSelector("div[aria-label='Đóng']"));
                        CloseStory.Click();
                        KT.Flag_wait_forresponse = false;
                    }
                    catch { }
                }
                KT.Flag_wait_forresponse = true;
            }
            

            //KT luot NewFeeds co duoc check hay khong
            if (chbtn_newFeeds.Checked)
            {
                //Scorll NewFeeds
                int dataPafelet = 1;
                int demNF = 0;
                //int soLanLuotNewFeeds = 0;
                for (int soLanLuotNewFeeds = 0; soLanLuotNewFeeds <= int.Parse(tb_SoLanLuotNF.Text); soLanLuotNewFeeds++)
                {
                    while (KT.Flag_wait_forresponse == true)
                    {
                        try
                        {
                            Thread.Sleep(3000);
                            //IWebElement ScrollNewFeeds = driver.FindElement(By.CssSelector("div[data-pagelet='FeedUnit_" + dataPafelet + "']"));
                            IWebElement ScrollNewFeeds = driver.FindElement(By.CssSelector("div[aria-posinset='" + dataPafelet + "']"));
                            Thread.Sleep(500);
                            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();", ScrollNewFeeds);
                            dataPafelet++;
                            lb_soLanLuotNF.Text = demNF.ToString();
                            if (demNF == int.Parse(tb_SoLanLuotNF.Text))
                            {
                                KT.Flag_wait_forresponse = false;
                            }
                            demNF++;
                        }
                        catch
                        {
                            MessageBox.Show("Loi");
                            KT.Flag_wait_forresponse = false;
                        }
                    }
                }
            }
            
            lb_CheckStatusStory.Text = KT.Flag_Check_thread_is_running_Story.ToString();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            if (tb_Like.Text == "Số Lần thả")
            {
                tb_Like.Text = "0";
            }
            if (tb_Tym.Text == "Số Lần thả")
            {
                tb_Tym.Text = "0";
            }
            if (tb_ThuongThuong.Text == "Số Lần thả")
            {
                tb_ThuongThuong.Text = "0";
            }
            if (tb_Sad.Text == "Số Lần thả")
            {
                tb_Sad.Text = "0";
            }
            if (tb_HAHA.Text == "Số Lần thả")
            {
                tb_HAHA.Text = "0";
            }
            if (tb_WOW.Text == "Số Lần thả")
            {
                tb_WOW.Text = "0";
            }
            if (tb_Angry.Text == "Số Lần thả")
            {
                tb_Angry.Text = "0";
            }
            if (tb_VongLapStory.Text != "")
            {
                KT.VongLapStory1 = int.Parse(tb_VongLapStory.Text);
            }
            KT.Flag_Check_thread_is_running_Story = true;
            lb_CheckStatusStory.Text = KT.Flag_Check_thread_is_running_Story.ToString();
            ThreadStart ts_fb = new ThreadStart(Run);
            Thread thrd_fb = new Thread(ts_fb);
            thrd_fb.Start();
        }

        private void btn_StopStory_Click(object sender, EventArgs e)
        {
            lb_CheckStatusStory.Text = KT.Flag_Check_thread_is_running_Story.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thrd_gmail.Abort();
            Application.Exit();
        }

        void TaoTKGmail()
        {
            String chromeDriverPath = @"D:\RAR\ChromeDriver_x86\chromedriver_win32";
            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");

            options.AddArguments("--disable-notifications");

            var driver = new ChromeDriver(chromeDriverPath, options, TimeSpan.FromDays(20));
            string url = "https://accounts.google.com/signup/v2/webcreateaccount?service=mail&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&flowName=GlifWebSignIn&flowEntry=SignUp";
            driver.Url = url;
            driver.Navigate().GoToUrl(url);

            //Thread.Sleep(5000);
            //while (flag_wait_forresponse == true)
            //{
            //    try
            //    {
            //        IWebElement TaoGm = driver.FindElement(By.CssSelector("a[title='Tạo tài khoản']"));
            //        flag_wait_forresponse = false;
            //        TaoGm.Click();
            //    }
            //    catch { }
            //}
            //flag_wait_forresponse = true;

            //Thread.Sleep(5000);
            //Khoi Tao
            while (KT.Flag_wait_forresponse == true)
            {
                try
                {
                    IWebElement Ho = driver.FindElement(By.CssSelector("input[id='lastName']")); 
                    Ho.SendKeys(tb_Ho.Text);

                    IWebElement Ten = driver.FindElement(By.CssSelector("input[id='firstName']"));
                    Ten.SendKeys(tb_Ten.Text);

                    IWebElement TenNguoiDung = driver.FindElement(By.CssSelector("input[id='username']"));
                    TenNguoiDung.SendKeys("");
                    TenNguoiDung.SendKeys(tb_TenNguoiDung.Text);

                    IWebElement Pass = driver.FindElement(By.CssSelector("input[aria-label='Mật khẩu']"));
                    Pass.SendKeys(tb_MK.Text);

                    IWebElement XacThuc = driver.FindElement(By.CssSelector("input[aria-label='Xác nhận']"));
                    XacThuc.SendKeys(tb_XacnhanMK.Text);

                    IWebElement TiepTheo = driver.FindElement(By.CssSelector("div[id='accountDetailsNext']"));
                    //TiepTheo.Click();

                    KT.Flag_wait_forresponse = false;
                }
                catch
                {
                }
            }
            KT.Flag_wait_forresponse = true;

        }

        private void btn_TaoTKGmail_Click(object sender, EventArgs e)
        {
            thrd_gmail.Start();
        }

        private void chbtn_EnableStory_CheckedChanged(object sender, EventArgs e)
        {
            if (chbtn_EnableStory.Checked)
            {
                tb_VongLapStory.Enabled = true;
                tb_Like.Enabled = true;
                tb_Tym.Enabled = true;
                tb_ThuongThuong.Enabled = true;
                tb_Sad.Enabled = true;
                tb_HAHA.Enabled = true;
                tb_WOW.Enabled = true;
                tb_Angry.Enabled = true;
                btn_StopStory.Enabled = true;
                chbtn_Like.Enabled = true;
                chbtn_HAHA.Enabled = true;
                chbtn_Sad.Enabled = true;
                chbtn_ThuongThuong.Enabled = true;
                chbtn_Tym.Enabled = true;
                chbtn_Angry.Enabled = true;
                chbtn_WOW.Enabled = true;
                label6.Enabled = true;
                lb_CheckStatusStory.Enabled = true;
                lb_CountLoop.Enabled = true;
            }
            else
            {
                tb_VongLapStory.Enabled = false;
                tb_Like.Enabled = false;
                tb_Tym.Enabled = false;
                tb_ThuongThuong.Enabled = false;
                tb_Sad.Enabled = false;
                tb_HAHA.Enabled = false;
                tb_WOW.Enabled = false;
                tb_Angry.Enabled = false;
                btn_StopStory.Enabled = false;
                chbtn_Like.Enabled = false;
                chbtn_HAHA.Enabled = false;
                chbtn_Sad.Enabled = false;
                chbtn_ThuongThuong.Enabled = false;
                chbtn_Tym.Enabled = false;
                chbtn_Angry.Enabled = false;
                chbtn_WOW.Enabled = false;
                label6.Enabled = false;
                lb_CheckStatusStory.Enabled = false;
                lb_CountLoop.Enabled = false;
            }
        }

        private void chbtn_newFeeds_CheckedChanged(object sender, EventArgs e)
        {
            if(chbtn_newFeeds.Checked)
            {
                tb_SoLanLuotNF.Enabled = true;
                label7.Enabled = true;
                lb_soLanLuotNF.Enabled = true;
            }
            else
            {
                tb_SoLanLuotNF.Enabled = false;
                label7.Enabled = false;
                lb_soLanLuotNF.Enabled = false;
            }
        }

        private void btn_CauHinh_Click(object sender, EventArgs e)
        {
            FormCauHinh CH = new FormCauHinh();
            CH.ShowDialog();
        }
    }
}
