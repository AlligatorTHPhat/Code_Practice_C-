using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HienThiHoTen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //add the following code
            string first= txtFirstName.Text;
            string title = titleComboBox.Text;
            string last = txtLastName.Text;

            string nameToAdd= title + " " + first + " " + last; 
            namesListBox.Items.Add(nameToAdd);
        }
    }
}
