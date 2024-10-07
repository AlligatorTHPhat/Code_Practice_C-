using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Baitap 6
using System.Drawing;

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
            //BaiTap 1
            //Console.Write("Chuoi can xuat");
            //Console.WriteLine("Chuoi can xuat");

            //Baitap2
            //Console.Write("Nhap ho va ten : ");
            //String fullname = Console.ReadLine();
            //Console.WriteLine("Xin chao " + fullname);

            //BaiTap3
            //File.Open("D:\\my_file.txt"., FileMode.Open);

            //Baitap4
            //Console.Write("Nhap vao mot thang bat ky trong nam : ");
            //String strThang = Console.ReadLine();

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

            //Baitap5
            //int[] mang1c = new int[3];
            //mang1c[0] = 10;
            //mang1c [1] = 20;
            //mang1c [2] = 30;

            //for(int i = 0; i < mang1c.Length; i++)
            //{
            //    Console.Write(mang1c[i]);
            //}

            //// or

            //int[] a_mang1c = new int[3] { 10, 20, 30 };
            //for(int i = 0;  i <a_mang1c.Length;i++)
            //{
            //    Console.WriteLine(a_mang1c[i]);
            //}

            //Baitap6
            //int[] mang1c = new Point[] {new Point(10,20)},new Point(25,29), new Point(1, 20);
            //foreach (Point p in mang1c) {
            //    Console.Write("(x="+p.X+",y="+p.Y+") ");
            //}

            //Baitap7
            //string[,] mangnc = new string[2, 3];
            //int bound0 = mangnc.GetUpperBound(0);
            //int bound1 = mangnc.GetUpperBound(1);

            //for (int i = 0; i <= bound0; i++)
            //{
            //    for (int j = 0; j <= bound1; j++)
            //    {
            //        Console.Write("Nhap vao phan tu a[" + i + "," + j + "] =");
            //        mangnc[i, j] = Console.ReadLine();
            //    }
            //}

            //xuat mang
            //for (int i = 0; i <= bound0; i++)
            //{
            //    for (int j = 0; j <= bound1; j++)
            //    {
            //        Console.Write(mangnc[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Baitap 8
            //int[][] mangnc = new int[4][];
            //mangnc[0] = new int[] { 1, 5, 7, 9, 0 };
            //mangnc[1] = new int[] { 2, 5, 9, 3 };
            //mangnc[2] = new int[] { 8 };
            //mangnc[3] = new int[] { 4, 6, 8, 2, 9, 11 };
            //for (int i = 0; i < mangnc.Length; i++)
            //{
            //    for (int j = 0; j < mangnc[i].Length; j++)
            //    {
            //           Console.Write(mangnc[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //baitap9
            ThoiGian tg = new ThoiGian(24, 2, 2010, 12, 30, 20);
            tg.InThoiGian();
            Console.WriteLine(tg.Nam);

            //Baitap10
            SinhVien sv = new SinhVien("Nguyen", "Teo","nguyenteo@gmail.com", "0900999099", "Quang Ngai", "sv12345", "09050302");
            sv.InThongTin();
            GiangVien gv = new GiangVien("Cristial", "Ronaldo", "ronaldo@gmail.com", "0900999099", "US", "gv12345", "mt2345",
           "http://ronaldo.com");
            gv.InThongTin();
        }

        
    }
}

