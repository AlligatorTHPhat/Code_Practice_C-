using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruyenDLVaoForm
{
    public partial class FRMXuat : Form
    {
        const int KhoangCachLe = 10;
        const int KhoangCachButton = 10;
        const int Rong = 60;
        const int Cao = 60;

        public FRMXuat(int SoDong = 1, int SoCot = 1)
        {
            InitializeComponent();

            //Sinh động Form có n dòng, m cột button

            Button button;
            for (int i = 0; i < SoDong; i++)
            {
                for (int j = 0; j < SoCot; j++)
                {
                    button = new Button();
                    button.Left = KhoangCachLe + (KhoangCachButton+Rong) * j;
                    button.Top = KhoangCachLe + (KhoangCachButton + Cao) * i;
                    button.Height = Cao;
                    button.Width = Rong;
                    button.Text = $"{i},{j}";

                    //Gắn Sự kiện
                    button.Click += ClickButton;

                    //Thêm button vào form
                    this.Controls.Add(button);

                    //Thêm button vào form
                    this.Controls.Add(button);
                }
            }
            //resize kích thước Form
            this.ClientSize = new Size(
                KhoangCachLe + (KhoangCachButton + Rong) * SoCot,
                KhoangCachLe + (KhoangCachButton + Cao) * SoDong
                );
        }

        protected void ClickButton(object sender, EventArgs e)
        {
            MessageBox.Show("Click lên button: " + (sender as Button).Text);
        }

        private void FRMXuat_Load(object sender, EventArgs e)
        {

        }
    }
}
