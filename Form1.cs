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
    public partial class Form1 : Form
    {
        //private bool flag_wait_forresponse = true;
        //private bool flag_Check_thread_is_running_Story = false;
        //private int SoLan_Like = 0;
        //private int SoLan_Tym = 0;
        //private int SoLan_ThuongThuong = 0;
        //private int SoLan_WOW = 0;
        //private int SoLan_HAHA = 0;
        //private int SoLan_Sad = 0;
        //private int SoLan_PhanNo = 0;
        //private int VongLapStory = 0;
        KhoiTao KT;

        ThreadStart ts_fb;
        Thread thrd_fb;
        ThreadStart ts_gmail;
        Thread thrd_gmail;

        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            KT = new KhoiTao();
            lb_CheckStatusStory.Text = KT.Flag_Check_thread_is_running_Story.ToString();
            ts_fb = new ThreadStart(Run);
            thrd_fb = new Thread(ts_fb);

            ts_gmail = new ThreadStart(TaoTKGmail);
            thrd_gmail = new Thread(ts_gmail);
        }

        void Run()
        {
            String chromeDriverPath = @"D:\RAR\ChromeDriver_x86\chromedriver_win32";
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
            }
            KT.Flag_Check_thread_is_running_Story = false;
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
            KT.VongLapStory1 = int.Parse(tb_VongLapStory.Text);
            KT.Flag_Check_thread_is_running_Story = true;
            lb_CheckStatusStory.Text = KT.Flag_Check_thread_is_running_Story.ToString();
            thrd_fb.Start();
        }

        private void btn_StopStory_Click(object sender, EventArgs e)
        {
            thrd_fb.Abort();
            lb_CheckStatusStory.Text = KT.Flag_Check_thread_is_running_Story.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thrd_fb.Abort();
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
    }
}
