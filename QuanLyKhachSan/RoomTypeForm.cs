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
    public partial class RoomTypeForm : Form
    {
        private IRepository<RoomType> _repo;
        public RoomTypeForm(IRepository<RoomType> repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            List<RoomType> RoomTypes = _repo.Get();
            loaiPhongGridView.DataSource = RoomTypes;
            loaiPhongGridView.Columns[0].HeaderText = "ID";
            loaiPhongGridView.Columns[0].Width = 40;
            loaiPhongGridView.Columns[1].HeaderText = "Tên";
            loaiPhongGridView.Columns[2].HeaderText = "Giá";
            loaiPhongGridView.Columns[3].Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string RoomTypeName = loaiPhongTextBox.Text;
            decimal Price = Convert.ToDecimal(donGiaTextBox.Text);

            _repo.Create(new RoomType
            {
                Name = RoomTypeName,
                Price = Price,
            });

            LoadData();
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            try
            {
                int RoomTypeId = Convert.ToInt32(loaiPhongGridView.SelectedCells[0].Value);
                _repo.Delete(_repo.Get(RoomTypeId));
                LoadData();
            }
            catch (Exception)
            {
                Debug.Write(e.ToString());
            }
        }
    }
}
