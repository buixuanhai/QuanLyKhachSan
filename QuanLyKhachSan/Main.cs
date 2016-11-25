using Ninject;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories;
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
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            Injection.Initialize();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Injection.kernel.Get<CheckInForm>().Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Injection.kernel.Get<RoomTypeForm>().Show();
        }

        private void danhSachPhongButton_Click(object sender, EventArgs e)
        {
            Injection.kernel.Get<RoomForm>().Show();
        }

        private void btnLapHoaDon_Click(object sender, EventArgs e)
        {
            Injection.kernel.Get<ReceiptForm>().Show();
        }

        private void btnLapBaoCaoThang_Click(object sender, EventArgs e)
        {
            new ReportForm().Show();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            new TraCuu().Show();
        }
    }

    }
