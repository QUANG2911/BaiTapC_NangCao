using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNangCao
{
    class QuanAo
    {
        private string size;
        private int gia;
        private string thuongHieu;

        public QuanAo(string size, int gia, string thuongHieu)
        {
            this.size = size;
            this.gia = gia;
            this.thuongHieu = thuongHieu;
        }


        public string Size { get => size; set => size = value; }
        public int Gia { get => gia; set => gia = value; }
        public string ThuongHieu { get => thuongHieu; set => thuongHieu = value; }
    }

    
}
