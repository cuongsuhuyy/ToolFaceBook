using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ToolFaceBook02
{
    class KhoiTao
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
        private int VongLapStory = 0;

        public bool Flag_wait_forresponse { get => flag_wait_forresponse; set => flag_wait_forresponse = true; }
        public bool Flag_Check_thread_is_running_Story { get => flag_Check_thread_is_running_Story; set => flag_Check_thread_is_running_Story = false; }
        public int SoLan_Like1 { get => SoLan_Like; set => SoLan_Like = value; }
        public int SoLan_Tym1 { get => SoLan_Tym; set => SoLan_Tym = value; }
        public int SoLan_ThuongThuong1 { get => SoLan_ThuongThuong; set => SoLan_ThuongThuong = value; }
        public int SoLan_WOW1 { get => SoLan_WOW; set => SoLan_WOW = value; }
        public int SoLan_HAHA1 { get => SoLan_HAHA; set => SoLan_HAHA = value; }
        public int SoLan_Sad1 { get => SoLan_Sad; set => SoLan_Sad = value; }
        public int SoLan_PhanNo1 { get => SoLan_PhanNo; set => SoLan_PhanNo = value; }
        public int VongLapStory1 { get => VongLapStory; set => VongLapStory = value; }
    }
}
