using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int N;
            double X;

            if (!int.TryParse(txtN.Text, out N) || (N <= 0))
            {
                MessageBox.Show("Gía trị N không hợp lệ");
                txtN.Focus();
                return;
            }

            if (!double.TryParse(txtX.Text, out X))
            {
                MessageBox.Show("Gía trị X không hợp lệ");
                txtN.Focus();
                return;
            }

            double S4 = 0;
            string S1 = string.Empty;
            string S2 = string.Empty;
            string S3 = string.Empty;

            for (int i = 1; i <= N; i++)
            {
                S1 += $"X" + (i > 1 ? $"^{i}" : "") +"+";
                //S2 += $"{X}^{i}+";
                S2 += $"{X}{(i > 1 ? ($"^{i}").ToString() : "")}+";
                S4 += Math.Pow(X, i);
                S3 += $"{Math.Pow(X, i)}+";
            }

            txtS1.Text = S1.Substring(0, S1.Length-1);
            txtS2.Text = S2.Substring(0, S2.Length - 1);
            txtS3.Text = S3.Substring(0, S3.Length - 1);
            txtS4.Text = S4.ToString();
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtN.Text = string.Empty;
            txtX.Text = string.Empty;
            txtS1.Text = string.Empty;
            txtS2.Text = string.Empty;
            txtS3.Text = string.Empty;
            txtS4.Text = string.Empty;
            txtN.Focus(); // Đặt con trỏ vào ô nhập N sau khi nhấn Nhập lại
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
