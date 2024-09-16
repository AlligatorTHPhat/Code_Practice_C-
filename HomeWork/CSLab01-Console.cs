// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaiTap1
            //Console.WriteLine("Nhap vao ten ban: ");
            //string ten = Console.ReadLine();
            //Console.WriteLine("Xin chao " + ten);

            ////BaiTap2
            //Console.WriteLine("Nhap tham so a:");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Nhap tham so b:");
            //double b = double.Parse(Console.ReadLine());

            //if (a == 0)
            //{
            //    if (b == 0)
            //        Console.WriteLine("Phuong trinh co vo so nghiem");
            //    else
            //        Console.WriteLine("Phuong trinh vo nghiem");
            //}
            //else
            //{
            //    double x = -b / a;
            //    Console.WriteLine("Phuong trinh co nghiem x = " + x.ToString());
            //}

            //BaiTap3
            //Console.Write("Nhap so luong phan tu : ");
            //int n = int.Parse(Console.ReadLine());
            //int[] mang = new int[n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Nhap phan tu " + i.ToString() + " : ");
            //    mang[i] = int.Parse(Console.ReadLine());
            //}
            //int tong = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    tong += mang[i];
            //}
            //Console.WriteLine("Tong cua mang cong la : " + tong);

            //BaiTap4.1
            //Console.WriteLine("Nhap ho, ten lot va ten. Xuat ra ho ten day du.");
            //Console.WriteLine();

            //Console.Write("Nhap ho : ");
            //string ho = Console.ReadLine();


            //Console.Write("Nhap ten lot : ");
            //string tenlot = Console.ReadLine();

            //Console.Write("Nhap ten : ");
            //string ten = Console.ReadLine();

            //Console.WriteLine("Ho va ten day du : {0} {1} {2}", ho, tenlot, ten);

            //Console.ReadKey(true);

            //BaiTap4.2
            //Console.WriteLine("Nhap ho ten day du. Xuat ra tung phan.");
            //Console.WriteLine();

            //Console.Write("Nhap ho ten : ");
            //string fullname = Console.ReadLine();

            //string Space = " ";
            //string[] parts = fullname.Split(new string[] {Space}, StringSplitOptions.None);

            //Console.WriteLine("Ho : {0}, ten lot : {1}, ten : {2}", parts[0], parts[1], parts[2]);

            //Console.ReadKey(true);

            //BaiTap5
            Console.WriteLine("Nhap ho ten khong theo chuan. Chinh lai theo chuan va xuat ra");
            Console.WriteLine();

            Console.Write("Nhap ho ten (khong can theo chuan) : ");
            string fullname = Console.ReadLine();

            string SEPERAPTOR =" ";

            string[] parts = fullname.Split(new string[] { SEPERAPTOR }, StringSplitOptions.RemoveEmptyEntries);
                
            string ho = parts[0].Substring(0, 1).ToUpper() + 
                parts[0].Substring(1, parts[0].Length - 1).ToLower();

            string tenlot = parts[1].Substring(0,1).ToUpper() +
                parts[1].Substring(1, parts[1].Length - 1).ToLower();

            string ten = parts[2].Substring(0, 1).ToUpper() +
                parts[2].Substring(1, parts[2].Length - 1).ToLower();


            Console.WriteLine("Ten theo dung chuan la : {0} {1} {2}",ho,tenlot,ten);

            Console.ReadKey(true);
        }
    }
}
