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


namespace ToolFaceBook02
{
    public partial class FormCauHinh : Form
    {
        DataProvider.KhoiTao KT;
        private int DemClosing;
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

        void Closing()
        {
            KT.Flag_wait_forresponse = true;
            DemClosing = 3;
            while (KT.Flag_wait_forresponse == true)
            {
                lb_statusSave.Text = "Cấu hình đã được lưu, đóng sau " + DemClosing + " s";
                DemClosing--;
                Thread.Sleep(1000);
                if (DemClosing == -1)
                    KT.Flag_wait_forresponse = false;
            }
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            ThreadStart ts_Clsave = new ThreadStart(Closing);
            Thread thrd_Clsave = new Thread(ts_Clsave);
            thrd_Clsave.Start();
            //thrd_Clsave.Abort();
        }

        private void FormCauHinh_Load(object sender, EventArgs e)
        {

        }
    }
}
