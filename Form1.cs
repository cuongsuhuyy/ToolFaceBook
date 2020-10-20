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
        private bool flag_wait_forresponse = true;
        private bool flag_Check_thread_is_running_Story = false;
        private int SoLan_Like = 0;
        private int SoLan_Tym = 0;
        private int SoLan_ThuongThuong = 0;
        private int SoLan_WOW = 0;
        private int SoLan_HAHA = 0;
        private int SoLan_Sad = 0;
        private int SoLan_PhanNo = 0;
        private int Tong_SoLan_Tha = 0;

        ThreadStart ts;
        Thread thrd;

        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ts = new ThreadStart(Run);
            thrd = new Thread(ts);
        }


        public void kt_Tha_Story()
        {
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
            while (flag_wait_forresponse == true)
            {
                try
                {
                    IWebElement UserName = driver.FindElement(By.CssSelector("input[type='text']"));
                    UserName.SendKeys(tb_UserName.Text);

                    IWebElement Password = driver.FindElement(By.CssSelector("input[type='password']"));
                    Password.SendKeys(tb_Password.Text);

                    IWebElement sign_in = driver.FindElement(By.CssSelector("button[name='login']"));
                    sign_in.Click();

                    flag_wait_forresponse = false;
                }
                catch
                {
                }
            }
            flag_wait_forresponse = true;

            //Watch Story
            while (flag_wait_forresponse == true)
            {
                try
                {
                    IWebElement WatchStory = driver.FindElement(By.CssSelector("div[aria-label='Tin']"));
                    WatchStory.Click();

                    flag_wait_forresponse = false;
                }
                catch
                {
                }
            }
            flag_wait_forresponse = true;

            //Pause Story
            while (flag_wait_forresponse == true)
            {
                try
                {
                    IWebElement PauseStory = driver.FindElement(By.CssSelector("div[aria-label='Phát']"));
                    PauseStory.Click();
                    flag_wait_forresponse = false;
                }
                catch
                {
                    try 
                    {
                        IWebElement PauseStory = driver.FindElement(By.CssSelector("div[aria-label='Tạm dừng']"));
                        PauseStory.Click();
                        flag_wait_forresponse = false;
                    }
                    catch
                    {
                    }
                }
            }
            flag_wait_forresponse = true;

            //Tha Status Story
            //for (int z = 0; z < Tong_SoLan_Tha + 5; z++)
            //{
                try
                {
                    try
                    {
                        for (SoLan_Like = 0; SoLan_Like < int.Parse(tb_Like.Text); SoLan_Like++)
                        {
                            if (chbtn_Like.Checked)
                            {
                                IWebElement Thich = driver.FindElement(By.CssSelector("span[aria-label='Thích']"));
                                Thich.Click();
                            }
                        }
                    }
                    catch { } //Like
                    //Thread.Sleep(1000);
                    try
                    {
                        for (SoLan_Tym = 0; SoLan_Tym < int.Parse(tb_Tym.Text); SoLan_Tym++)
                        {
                            if (chbtn_Tym.Checked)
                            {
                                IWebElement Yeu_Thich = driver.FindElement(By.CssSelector("span[aria-label='Yêu thích']"));
                                Yeu_Thich.Click();
                            }
                        }
                    }
                    catch { } //Tym
                    //Thread.Sleep(1000);
                    try
                    {
                        for (SoLan_ThuongThuong = 0; SoLan_ThuongThuong < int.Parse(tb_ThuongThuong.Text); SoLan_ThuongThuong++)
                        {
                            if (chbtn_ThuongThuong.Checked)
                            {
                                IWebElement ThuongThuong = driver.FindElement(By.CssSelector("span[aria-label='Thương thương']"));
                                ThuongThuong.Click();
                            }
                        }
                    }
                    catch { } //ThuongThuong
                    //Thread.Sleep(1000);
                    try
                    {
                        for (SoLan_HAHA = 0; SoLan_HAHA < int.Parse(tb_HAHA.Text); SoLan_HAHA++)
                        {
                            if (chbtn_HAHA.Checked)
                            {
                                IWebElement HAHA = driver.FindElement(By.CssSelector("span[aria-label='Haha']"));
                                HAHA.Click();
                            }
                        }
                    }
                    catch { } //HAHA
                    //Thread.Sleep(1000);
                    try
                    {
                        for (SoLan_WOW = 0; SoLan_WOW < int.Parse(tb_WOW.Text); SoLan_WOW++)
                        {
                            if (chbtn_WOW.Checked)
                            {
                                IWebElement WOW = driver.FindElement(By.CssSelector("span[aria-label='Wow']"));
                                WOW.Click();
                            }
                        }
                    }
                    catch { } //WOW
                    //Thread.Sleep(1000);
                    try
                    {
                        for (SoLan_Sad = 0; SoLan_Sad < int.Parse(tb_Sad.Text); SoLan_Sad++)
                        {
                            if (chbtn_Sad.Checked)
                            {
                                IWebElement SAD = driver.FindElement(By.CssSelector("span[aria-label='Buồn']"));
                                SAD.Click();
                            }
                        }
                    }
                    catch { } //Sad
                    //Thread.Sleep(1000);
                    try
                    {
                        for (SoLan_PhanNo = 0; SoLan_PhanNo < int.Parse(tb_Angry.Text); SoLan_PhanNo++)
                        {
                            if (chbtn_Angry.Checked)
                            {
                                IWebElement Angry = driver.FindElement(By.CssSelector("span[aria-label='Phẫn nộ']"));
                                Angry.Click();
                            }
                        }
                    }
                    catch { } //Angry
                    //Thread.Sleep(1000);
                }
                catch { }
            //}
            

            int i;
            for (i = 0; i < 100; i++)
            {
                while (flag_wait_forresponse == true)
                {
                    try
                    {
                        IWebElement NextStory = driver.FindElement(By.CssSelector("div[aria-label='Nút Tin tiếp theo']"));
                        NextStory.Click();
                        flag_wait_forresponse = false;
                    }
                    catch
                    {
                        try
                        {
                            IWebElement NextStory = driver.FindElement(By.CssSelector("div[aria-label='Nút thẻ tiếp theo']"));
                            NextStory.Click();
                            flag_wait_forresponse = false;
                        }
                        catch
                        { }
                    }
                }
                flag_wait_forresponse = true;

                while (flag_wait_forresponse == true)
                {
                    try
                    {
                        IWebElement PauseStory = driver.FindElement(By.CssSelector("div[aria-label='Phát']"));
                        PauseStory.Click();
                        flag_wait_forresponse = false;
                    }
                    catch
                    {
                        //try
                        //{
                        //    IWebElement PauseStory = driver.FindElement(By.CssSelector("div[aria-label='Tạm dừng']"));
                        //    PauseStory.Click();
                        //    flag_wait_forresponse = false;
                        //}
                        //catch { }
                    }
                }
                flag_wait_forresponse = true;

                //for (int z = 0; z < Tong_SoLan_Tha + 5; z++)
                //{
                    try
                    {
                        try
                        {
                            for (SoLan_Like = 0; SoLan_Like < int.Parse(tb_Like.Text); SoLan_Like++)
                            {
                                if (chbtn_Like.Checked)
                                {
                                    IWebElement Thich = driver.FindElement(By.CssSelector("span[aria-label='Thích']"));
                                    Thich.Click();
                                }
                            }
                        }
                        catch { } //Like
                        //Thread.Sleep(1000);
                        try
                        {
                            for (SoLan_Tym = 0; SoLan_Tym < int.Parse(tb_Tym.Text); SoLan_Tym++)
                            {
                                if (chbtn_Tym.Checked)
                                {
                                    IWebElement Yeu_Thich = driver.FindElement(By.CssSelector("span[aria-label='Yêu thích']"));
                                    Yeu_Thich.Click();
                                }
                            }
                        }
                        catch { } //Tym
                        //Thread.Sleep(1000);
                        try
                        {
                            for (SoLan_ThuongThuong = 0; SoLan_ThuongThuong < int.Parse(tb_ThuongThuong.Text); SoLan_ThuongThuong++)
                            {
                                if (chbtn_ThuongThuong.Checked)
                                {
                                    IWebElement ThuongThuong = driver.FindElement(By.CssSelector("span[aria-label='Thương thương']"));
                                    ThuongThuong.Click();
                                }
                            }
                        }
                        catch { } //ThuongThuong
                        //Thread.Sleep(1000);
                        try
                        {
                            for (SoLan_HAHA = 0; SoLan_HAHA < int.Parse(tb_HAHA.Text); SoLan_HAHA++)
                            {
                                if (chbtn_HAHA.Checked)
                                {
                                    IWebElement HAHA = driver.FindElement(By.CssSelector("span[aria-label='Haha']"));
                                    HAHA.Click();
                                }
                            }
                        }
                        catch { } //HAHA
                        //Thread.Sleep(1000);
                        try
                        {
                            for (SoLan_WOW = 0; SoLan_WOW < int.Parse(tb_WOW.Text); SoLan_WOW++)
                            {
                                if (chbtn_WOW.Checked)
                                {
                                    IWebElement WOW = driver.FindElement(By.CssSelector("span[aria-label='Wow']"));
                                    WOW.Click();
                                }
                            }
                        }
                        catch { } //WOW
                        //Thread.Sleep(1000);
                        try
                        {
                            for (SoLan_Sad = 0; SoLan_Sad < int.Parse(tb_Sad.Text); SoLan_Sad++)
                            {
                                if (chbtn_Sad.Checked)
                                {
                                    IWebElement SAD = driver.FindElement(By.CssSelector("span[aria-label='Buồn']"));
                                    SAD.Click();
                                }
                            }
                        }
                        catch { } //Sad
                        //Thread.Sleep(1000);
                        try
                        {
                            for (SoLan_PhanNo = 0; SoLan_PhanNo < int.Parse(tb_Angry.Text); SoLan_PhanNo++)
                            {
                                if (chbtn_Angry.Checked)
                                {
                                    IWebElement Angry = driver.FindElement(By.CssSelector("span[aria-label='Phẫn nộ']"));
                                    Angry.Click();
                                }
                            }
                        }
                        catch { } //Angry
                        //Thread.Sleep(1000);
                    }
                    catch { }
                //}
                lb_CountLoop.Text = i.ToString();
            }
            flag_Check_thread_is_running_Story = false;
            lb_CheckStatusStory.Text = flag_Check_thread_is_running_Story.ToString();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            Tong_SoLan_Tha = int.Parse(tb_Like.Text) + int.Parse(tb_Tym.Text) + int.Parse(tb_ThuongThuong.Text)
                + int.Parse(tb_WOW.Text) + int.Parse(tb_HAHA.Text) + int.Parse(tb_Sad.Text) + int.Parse(tb_Angry.Text);
            flag_Check_thread_is_running_Story = true;
            lb_CheckStatusStory.Text = flag_Check_thread_is_running_Story.ToString();
            thrd.Start();
        }

        private void btn_StopStory_Click(object sender, EventArgs e)
        {
            thrd.Abort();
            lb_CheckStatusStory.Text = flag_Check_thread_is_running_Story.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thrd.Abort();
            Application.Exit();
        }
    }
}
