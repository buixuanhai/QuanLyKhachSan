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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void viewButon_Click(object sender, EventArgs e)
        {
            try
            {
                RoomType RoomType = (RoomType)loaiPhongComboBox.SelectedItem;
                int Month = Convert.ToInt32(thangComboBox.Text);
                var context = new HotelContext();
                    var Receipts = context.Receipts
                        .Where(r => r.CheckIn.Room.RoomType.RoomTypeId == RoomType.RoomTypeId
                       && r.CheckIn.CheckInDate.Month == Month )
                       .Select(r => new
                       {
                           r.ReceiptId,
                           r.CheckIn.CheckInDate,
                           r.EndDate,
                           r.Total
                       })
                       .ToList();
                    baoCaoDoanhThuGridView.DataSource = Receipts;
                
            }
            catch (Exception)
            {

            }
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            using (var context = new HotelContext())
            {
                List<RoomType> RoomTypes = context.RoomTypes.ToList();
                loaiPhongComboBox.DataSource = RoomTypes;
                loaiPhongComboBox.DisplayMember = "Name";
                loaiPhongComboBox.ValueMember = "RoomTypeId";
                loaiPhongComboBox.SelectedValue = 1;
            }

            thangComboBox.SelectedIndex = 0;


        }
    }
}
