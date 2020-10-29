using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ToolFaceBook02
{
    public partial class FromCauHinh : Form
    {
        XmlDocument doc = new XmlDocument();
        KhoiTao KT;
        public FromCauHinh()
        {
            KT = new KhoiTao();
            InitializeComponent();
        }

        public String SendPath()
        {
            return KT.Path;
        }

        private void FromCauHinh_Load(object sender, EventArgs e)
        {

        }

        private void btn_ChromeDriver_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
            tb_ChromeDriver.Text = result.ToString();
            if (result == DialogResult.OK)
            {
                tb_ChromeDriver.Text = folder.SelectedPath;
                KT.Path = tb_ChromeDriver.Text;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            doc.LoadXml("File_Config");
            //doc = new 
        }
    }
}
