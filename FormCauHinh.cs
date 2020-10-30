using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolFaceBook02
{
    public partial class FormCauHinh : Form
    {
        KhoiTao KT;
        public FormCauHinh()
        {
            KT = new KhoiTao();
            InitializeComponent();
        }

        private void btn_Path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            DialogResult result = folder.ShowDialog();
            tb_Path.Text = result.ToString();
            if (result == DialogResult.OK)
            {
                tb_Path.Text = folder.SelectedPath;
                KT.Path = tb_Path.Text;
            }
        }
    }
}
