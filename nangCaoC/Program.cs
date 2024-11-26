using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapNangCao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            //************Generic************//
            Console.WriteLine("************Generic************");
            List<int> x = new List<int> { 1, 2, 3 };
            List<string> b = new List<string> { "Quần", "Áo", "Sweeter" };
            Generic item = new Generic();

            item.ItemList(x);
            item.ItemList(b);

        //************Async/ Task/ Await************//

        Console.WriteLine("************Async Task Await************");

        AsynsTaskAwait a = new AsynsTaskAwait();
        int thoiGianCho = 3000;
        Console.WriteLine("Thời gian chờ 1: " + thoiGianCho / 1000 + "s");
        string Y = a.GiaLapThoiGianCho1(thoiGianCho).Result;
        Console.WriteLine(Y);
        a.GiaLapThoiGianCho2(thoiGianCho);

        //************Denpendency Jnjection************//

        Console.WriteLine("************Denpendency Injection************");
        //TH1: Không viết theo phương thức Denpendency Injection
        Console.WriteLine("Không viết theo phương thức Denpendency Injection");
        Printer _printer = new Printer();
        _printer.InKetQua(); // nếu muốn đổi class Paper bằng class Picture thì bắt buộc phải vào class Printer sửa => tệ


        //TH2: Viết theo phương thức Denpendency Injection
        Console.WriteLine("\nViết theo phương thức Denpendency Injection");
        Picture _picture = new Picture();

        Fax _fax = new Fax(_picture);

         _fax.InKetQua();

        //************Lambda************//
        Console.WriteLine("************Lambda************");

        Action sayHello = () => { 
            Console.WriteLine("Helloo");
            Func<int, int, string> add = (w, e) =>
            {
                if (w > e) return "quang";
                else return "minh";
            };
                Console.WriteLine(add(6, 5));
        };
        sayHello();
        
        //************LINQ************//
        Console.WriteLine("************LinQ************");

         List<QuanAo> listAo = new List<QuanAo>()
         {
             new QuanAo("M",100,"NIKE"),
             new QuanAo("L",30,"SSStuter"),
             new QuanAo("XL",400,"UNILO")
         };
         int maxGia = 200;

         var items = listAo.Where(p => p.Gia < maxGia).ToList();

         Console.WriteLine("Số lượng áo có giá nhỏ hơn " + maxGia + ":" + items.Count());
         for(int i = 0; i < items.Count(); i++)
         {
             Console.WriteLine("\nÁo " + (int)(i + 1));
             Console.WriteLine("Size" + items[i].Size);
             Console.WriteLine("Áo " + items[i].Gia);
             Console.WriteLine("Áo " + items[i].ThuongHieu);
         }    

        //************Delegate Predicate************//
         Console.WriteLine("************Delegate Predicate************");
 
         List<String> nameList = new List<String> {"Quang","minh","Bùi","Xinh","Men"};

         Predicate<string> dieuKienChon = P => P.Contains("m");

         List<string> listTmp = nameList.FindAll(dieuKienChon);

         foreach (var i in listTmp)
         {
             Console.WriteLine(i);
         }    


         Console.ReadLine();
        }
}
}
