using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNangCao
{
    class Generic
    {
        public void ItemList<T>(List<T> items)
        {
            foreach (var i in items)
                Console.WriteLine(i);
        }    
    }
}
