using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS01_Console
{
    internal class ThoiGian
    {
        
            int ngay; int thang; int nam;
            int gio; int phut; int giay;
            public int Ngay
            {
                get { return ngay; }
                set { ngay = value; }
            }
            public int Thang
            {
                get { return thang; }
                set { thang = value; }
            }
            public int Nam
            {
                get { return nam; }
                set { nam = value; }
            }

            public ThoiGian(int ngay, int thang, int nam, int gio, int phut,int giay)
            {
                this.ngay = ngay;
                this.thang = thang;
                this.nam = nam;

                this.gio = gio;
                this.phut = phut;
                this.giay = giay;
            }

            public void InThoiGian()
            {
                Console.WriteLine("{0}:{1}:{2} {3}/{4}/{5}", gio, phut, giay,
               ngay, thang, nam);
            }
        }
}
