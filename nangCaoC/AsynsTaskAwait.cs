using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNangCao
{
    class AsynsTaskAwait
    {
      public async Task<string> GiaLapThoiGianCho1(int thoiGianCho)
      {
            await Task.Delay(thoiGianCho);
            return "End1";
      }

      public async Task GiaLapThoiGianCho2(int thoiGianCho)
      {
            Console.WriteLine("Thời gian chờ 2: " + thoiGianCho / 1000 + "s");
            await Task.Delay(thoiGianCho);
            Console.WriteLine("End2");
      }
    }
}
