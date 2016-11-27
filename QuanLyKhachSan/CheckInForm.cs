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
    public partial class CheckInForm : Form
    {
        private IRepository<CheckIn> CheckInRepo;
        private IRepository<Room> RoomRepo;


        public CheckInForm(IRepository<CheckIn> CheckInRepo, IRepository<Room> RoomRepo)
        {
            InitializeComponent();
            this.CheckInRepo = CheckInRepo;
            this.RoomRepo = RoomRepo;
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

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            // Initialize rooms
            List<Room> Rooms = RoomRepo.Get();
            phongComboBox.DataSource = Rooms;
            phongComboBox.DisplayMember = "RoomCode";
            phongComboBox.ValueMember = "RoomId";
            phongComboBox.SelectedIndex = 0;

            // Initilize customer types
            loaiKhachComboBox.DataSource = Enum.GetValues(typeof(CustomerType));

            // Initialize Checkins table

            List<CheckIn> CheckIns = CheckInRepo.Get();
            phieuThuePhongGridView.DataSource = CheckIns;
            phieuThuePhongGridView.Columns[0].HeaderText = "Id";
            phieuThuePhongGridView.Columns[0].Width = 40;
            phieuThuePhongGridView.Columns[1].HeaderText = "Ngày";
            phieuThuePhongGridView.Columns[2].HeaderText = "CMND";
            phieuThuePhongGridView.Columns[3].HeaderText = "Tên khách";
            phieuThuePhongGridView.Columns[4].HeaderText = "Loại khách";
            phieuThuePhongGridView.Columns[5].HeaderText = "Phòng";

            phieuThuePhongGridView.Columns[6].Visible = false;

        }

        private void themButton_Click(object sender, EventArgs e)
        {
            Room Room = RoomRepo.Get(((Room)phongComboBox.SelectedItem).RoomId);
            string CustomerName = khachHangTextBox.Text;
            CustomerType CustomerType = (CustomerType) loaiKhachComboBox.SelectedItem;
            string CustomerIdentityNumber = CMNDTextBox.Text;

            try
            {
                CheckInRepo.Create(new CheckIn
                {
                    Room = Room,
                    CusTomerName = CustomerName,
                    CustomerType = CustomerType,
                    CustomerIdentityNumber = CustomerIdentityNumber,
                    CheckInDate = DateTime.Now
                });
                LoadData();
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            int CheckInId = (int)phieuThuePhongGridView.Rows[phieuThuePhongGridView.CurrentCell.RowIndex].Cells[0].Value;
            CheckIn CheckIn = CheckInRepo.Get(CheckInId);

            try
            {
                CheckInRepo.Delete(CheckIn);
                LoadData();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
