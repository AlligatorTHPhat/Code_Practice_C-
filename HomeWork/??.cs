using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS01_Console
{
    internal class Program
    {
        int cong2so(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            ////BaiTap0
            //Console.WriteLine("Welcome to .Net programmming class");

            ////BaiTap1
            //Console.Write("Chuoi can xuat");
            //Console.WriteLine("Chuoi can xuat");

            ////BaiTap2 
            //Console.Write("Nhap vao ho va ten : ");
            //String fullname = Console.ReadLine();
            //Console.WriteLine("Xin chao " + fullname);

            ////BaiTap3
            //Console.Write("Nhap vao mot so nguyen bat ky : "); 
            //String str = Console.ReadLine();
            //int so = int.Parse(str);
            //if (so > 0)
            //{
            //    Console.WriteLine("Day la so nguyen duong");
            //}
            //else if (so < 0)
            //{
            //    Console.WriteLine("Day la so nguyen am");
            //}
            //else
            //{
            //    Console.WriteLine("Day la so khong");
            //}

            ////BaiTap4
            //Console.Write("Nhap vao mot thang bat ky trong nam : "); String strThang = Console.ReadLine();
            //int thang = int.Parse(strThang);
            //switch (thang)
            //{
            //    case 1:
            //        Console.WriteLine("Thang mot");
            //        break;
            //    case 2:
            //        Console.WriteLine("Thang hai");
            //        break;
            //    case 3:
            //        Console.WriteLine("Thang ba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thang tu");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thang nam");
            //        break;
            //    case 6:
            //        Console.WriteLine("Thang sau");
            //        break;
            //    case 7:
            //        Console.WriteLine("Thang bay");
            //        break;
            //    case 8:
            //        Console.WriteLine("Thang tam");
            //        break;
            //    case 9:
            //        Console.WriteLine("Thang chin");
            //        break;
            //    case 10:
            //        Console.WriteLine("Thang muoi");
            //        break;
            //    case 11:
            //        Console.WriteLine("Thang muoi mot");
            //        break;
            //    case 12:
            //        Console.WriteLine("Thang muoi hai");
            //        break;
            //    default:
            //        Console.WriteLine("Thang khong hop le");
            //        break;
            //}

            ////BaiTap5
            //int[] mang1c = new int[3];
            //mang1c[0] = 10;
            //mang1c[1] = 15;
            //mang1c[2] = 2;
            //for (int i = 0; i < mang1c.Length; i++)
            //{
            //    Console.Write(mang1c[i] + " ");
            //}
            ////Or
            ////int[] mang1c = new int[3] { 10, 15, 2 };
            ////for (int i = 0; i < mang1c.Length; i++)
            ////{
            ////    Console.Write(mang1c[i] + " ");
            ////}

            //BaiTap7
            List<int> lst = new List<int>();
            Console.Write("Nhap so luong phan tu :");

            Random rd = new Random();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)

                lst.Add(rd.Next(0, 100));

            Console.WriteLine(string.Join(",", lst));
            Console.WriteLine("Tong = {0}", lst.Sum());
            Console.WriteLine("Tong = {0}", lst.Where(p => p % 2 == 1).Sum());
            Console.WriteLine("Tong = {0} = ", lst.Where(p => Check_Prime(p)).Sum());
            Console.ReadKey();
        }

        public static bool Check_Prime(int p)
        {
            if (p > 2) return false;
            for(int i = 0; i < Math.Sqrt(p);i++)
            {
                if (p % i == 0) return false;
            }
            return true;
        }

    }
}



//    }
//        }
//        public static bool chk_Prime(int p)
//        {
//            if (p < 2)
//            {
//                return true;
//            }

//            else
//            {
//                for (int i = 2; i < sqrt(p); i++) {
//                    Console.WriteLine();
//                }
//                return false;
//            }
//        }
//    }
//}

//BaiTap3
//using System;
//using System.Collections.Generic;
//using System.Linq;

//4 | P a g e
//using System.Text;
//using System.IO;
//namespace DemoProject
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            File.Open("D:\\my_file.txt", FileMode.Open);
//        }
//    }
//}

//BaiTap6
//using System;
//using System.Drawing; //nhớ import thư viện System.Drawing
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//namespace DemoProject
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Point[] mang1c = new Point[] { new Point(10,20), new
//Point(25,20), new Point(1, 20)};
//            foreach (Point p in mang1c)
//            {
//                Console.Write("(x=" + p.X + ",y=" + p.Y + ") ");
//            }
//        }
//    }
//}
