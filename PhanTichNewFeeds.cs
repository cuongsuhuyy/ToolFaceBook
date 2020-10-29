using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolFaceBook02
{
    class PhanTichNewFeeds
    {
        public bool PhanTichGoiTin (String GoiTin, String KeyWord)
        {
            if (KeyWord.Contains(GoiTin) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
