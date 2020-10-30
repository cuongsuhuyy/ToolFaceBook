using System;
using DataProvider;

namespace Bridge_DAO
{
    public class PhanTichNewFeeds
    {
        public bool PhanTichGoiTin(String GoiTin, String KeyWord)
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
