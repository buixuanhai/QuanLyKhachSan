using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class RoomForm : Form
    {
        private IRepository<Room> _repo;

        public RoomForm(IRepository<Room> repo)
        {
            InitializeComponent();
            _repo = repo;

            Debug.WriteLine(_repo.get(100).RoomId);

            
        }

        private void donGiacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void luuButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
