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
        private IRepository<Room> RoomRepo;
        private IRepository<RoomType> RoomTypeRepo;

        public RoomForm(IRepository<Room> RoomRepo, IRepository<RoomType> RoomTypeRepo)
        {
            InitializeComponent();
            this.RoomRepo = RoomRepo;
            this.RoomTypeRepo = RoomTypeRepo;

        }

        private void donGiacomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void luuButton_Click(object sender, EventArgs e)
        {
            if (!IsDataValid()) return;

            int intRoomId = Convert.ToInt32(danhSachPhongGridView.SelectedCells[0].Value);
            int RoomCode = Convert.ToInt32(soPhongTextBox.Text.Trim());
            RoomType RoomType = (RoomType)loaiPhongComboBox.SelectedItem;
            RoomStatus RoomStatus = (RoomStatus)Enum.Parse(typeof(RoomStatus), tinhTrangPhongComboBox.Text);

            Room Room = RoomRepo.Get(intRoomId);

            if (Room != null)
            {
                Room.RoomCode = RoomCode;
                Room.RoomType = RoomType;
                Room.RoomStatus = RoomStatus;
                try
                {
                    RoomRepo.Update(Room);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                };
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachPhong_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCombo();
        }

        private DataTable DefaultValueRoomType()
        {
            DataColumn col;
            DataTable dtbRoomType = new DataTable();
            col = new DataColumn("RoomTypeId", typeof(int));
            dtbRoomType.Columns.Add(col);
            col = new DataColumn("Name", typeof(string));
            dtbRoomType.Columns.Add(col);
            col = new DataColumn("Price", typeof(decimal));
            dtbRoomType.Columns.Add(col);

            dtbRoomType.Rows.Add(0, "-- Chọn loại phòng --", 0);
            dtbRoomType.Rows.Add(1, "VIP", 20000);
            dtbRoomType.Rows.Add(2, "NORMAL", 15000);
            return dtbRoomType;


        }


        private void LoadCombo()
        {
            #region RoomType
            List<RoomType> RoomTypes = RoomTypeRepo.Get();
            //loaiPhongComboBox.DataSource = DefaultValueRoomType();
            loaiPhongComboBox.DataSource = RoomTypes;
            loaiPhongComboBox.DisplayMember = "Name";
            loaiPhongComboBox.ValueMember = "RoomTypeId";
            loaiPhongComboBox.SelectedValue = 1;
            #endregion

            #region RoomStatus
            tinhTrangPhongComboBox.DataSource = Enum.GetValues(typeof(RoomStatus));
            #endregion
        }

        private void LoadData()
        {
            List<Room> lstData = RoomRepo.Get();
            if (lstData != null)
            {
                danhSachPhongGridView.DataSource = lstData;
                danhSachPhongGridView.Columns[4].Visible = false;

                danhSachPhongGridView.Columns[0].HeaderText = "Id";
                danhSachPhongGridView.Columns[0].Width = 40;
                danhSachPhongGridView.Columns[1].HeaderText = "Mã phòng";
                danhSachPhongGridView.Columns[2].HeaderText = "Tình trạng phòng";
                danhSachPhongGridView.Columns[2].Width = 150;
                danhSachPhongGridView.Columns[3].HeaderText = "Loại phòng";
            }

        }

        private void themButton_Click(object sender, EventArgs e)
        {
            if (!IsDataValid()) return;

            int RoomCode = Convert.ToInt32(soPhongTextBox.Text.Trim());
            RoomType RoomType = (RoomType)loaiPhongComboBox.SelectedItem;

            RoomRepo.Create(new Room
            {
                RoomCode = RoomCode,
                RoomType = RoomType,
                RoomStatus = RoomStatus.Empty
            });

            LoadData();
        }

        private bool IsDataValid()
        {
            if (string.IsNullOrEmpty(soPhongTextBox.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập Số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                soPhongTextBox.Focus();
                return false;
            }

            if (Convert.ToInt32(loaiPhongComboBox.SelectedValue) == 0)
            {
                MessageBox.Show("Vui lòng nhập Loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loaiPhongComboBox.Focus();
                SendKeys.Send("{F4}");
                return false;
            }
            return true;
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            int intRoomId = Convert.ToInt32(danhSachPhongGridView.SelectedCells[0].Value);

            Room room = RoomRepo.Get(intRoomId);
            if (room != null)
            {
                try
                {
                    RoomRepo.Delete(room);
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                };
            }

        }

        private void suaButton_Click(object sender, EventArgs e)
        {
            int RoomId = Convert.ToInt32(danhSachPhongGridView.SelectedCells[0].Value);
            Room Room = RoomRepo.Get(RoomId);
            soPhongTextBox.Text = Room.RoomCode.ToString();
            loaiPhongComboBox.SelectedValue = Room.RoomType.RoomTypeId;
            tinhTrangPhongComboBox.SelectedItem = Room.RoomStatus;
        }
    }
}
