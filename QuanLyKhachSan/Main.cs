using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form3 = new DanhSachPhong();
            form3.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                Form form2 = new DanhMucPhong();
                form2.Show();
            }
            //this.Close();


        }

        private void danhSachPhongButton_Click(object sender, EventArgs e)
        {
            new DanhSachPhong().Show();
        }
    }

    }
