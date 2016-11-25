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
    public partial class CheckInForm : Form
    {
        private IRepository<CheckIn> _repo;
        public CheckInForm(IRepository<CheckIn> repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void loaiKhachcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
