using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNangCao
{
    class Paper
    {
        public string GetDuLieu()
        {
            return "Paper A4";
        }
    }

    class Picture
    {
        public string GetDuLieu()
        {
            return "Photophare";
        }
    }

    class Printer
    {
        Paper _paper;
        public Printer()
        {
            _paper = new Paper();
        }

        public void InKetQua()
        {
            Console.WriteLine(_paper.GetDuLieu());
        }
    }

    class Fax
    {
        Picture _picture;
        public Fax(Picture pic)
        {
            _picture = pic;
        }

        public void InKetQua()
        {
            Console.WriteLine(_picture.GetDuLieu());
        }
    }


}
