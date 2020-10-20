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

            try
            {
                //for (int y = 0; y < 5; y++)
                //{
                    IWebElement Yeu_Thich = driver.FindElement(By.CssSelector("span[aria-label='Yêu thích']"));
                    Yeu_Thich.Click();
                //}
            }
            catch
            {

            }

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
                        try
                        {
                            IWebElement PauseStory = driver.FindElement(By.CssSelector("div[aria-label='Tạm dừng']"));
                            PauseStory.Click();
                            flag_wait_forresponse = false;
                        }
                        catch { }
                    }
                }
                flag_wait_forresponse = true;

                try
                {
                    //for (int y = 0; y < 5; y++)
                    //{
                        IWebElement Yeu_Thich = driver.FindElement(By.CssSelector("span[aria-label='Yêu thích']"));
                        Yeu_Thich.Click();
                    //}
                }
                catch
                {

                }
                lb_CountLoop.Text = i.ToString();
            }
            flag_Check_thread_is_running_Story = false;
            lb_CheckStatusStory.Text = flag_Check_thread_is_running_Story.ToString();
        }

        void Run_run()
        {
            ThreadStart ts2 = new ThreadStart(Run);
            Thread thrd2 = new Thread(ts2);
            while(flag_Check_thread_is_running_Story == true)
            {
                thrd2.Start();
            }
            thrd2.Abort();
        }

        

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            flag_Check_thread_is_running_Story = true;
            lb_CheckStatusStory.Text = flag_Check_thread_is_running_Story.ToString();
            thrd.Start();
        }

        private void btn_StopStory_Click(object sender, EventArgs e)
        {
            thrd.Abort();
            lb_CheckStatusStory.Text = flag_Check_thread_is_running_Story.ToString();
        }
    }
}
