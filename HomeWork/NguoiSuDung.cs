using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS01_Console
{
    internal class NguoiSuDung
    {
        // Using properties for better encapsulation
        protected string Username { get; set; }
        protected string Firstname { get; set; }
        protected string Lastname { get; set; }
        protected string Email { get; set; }
        protected string Phonenumber { get; set; }
        protected string Address { get; set; }

        public NguoiSuDung(string firstname, string lastname, string email, string phonenumber, string address)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = email;
            this.Phonenumber = phonenumber;
            this.Address = address;
        }

        // Virtual method for printing user information
        public virtual void InThongTin()
        {
            Console.WriteLine("Fullname : " + Firstname + " " + Lastname);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("Phonenumber : " + Phonenumber);
            Console.WriteLine("Address : " + Address);
        }
    }

    class SinhVien : NguoiSuDung
    {
        private string Mssv { get; set; }
        private string Lop { get; set; }

        public SinhVien(string firstname, string lastname, string email, string phonenumber, string address, string mssv, string lop)
        : base(firstname, lastname, email, phonenumber, address)
        {
            this.Mssv = mssv;
            this.Lop = lop;
        }

        // Overriding InThongTin to include student-specific information
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine("Ma SV : " + Mssv);
            Console.WriteLine("Lop : " + Lop);
        }
    }

    class GiangVien : NguoiSuDung
    {
        private string Magv { get; set; }
        private string MaThue { get; set; }
        private string Homepage { get; set; }

        public GiangVien(string firstname, string lastname, string email, string phonenumber, string address, string magv, string mathue, string homepage)
        : base(firstname, lastname, email, phonenumber, address)
        {
            this.Magv = magv;
            this.MaThue = mathue;
            this.Homepage = homepage;
        }

        // Overriding InThongTin to include teacher-specific information
        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine("Ma GV : " + Magv);
            Console.WriteLine("Ma so thue : " + MaThue);
            Console.WriteLine("Home page : " + Homepage);
        }
    }

    
}
