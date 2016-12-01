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
    public partial class ReceiptForm : Form
    {
        private IRepository<Receipt> _repo;
        public ReceiptForm(IRepository<Receipt> repo)
        {
            InitializeComponent();
            _repo = repo;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchReceiptButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ReceiptId = Convert.ToInt32(receiptIdTextBox.Text);
                Debug.Write(ReceiptId);

                using (var context = new HotelContext())
                {
                    var Receipts = context.Receipts.Where(r => r.ReceiptId == ReceiptId).Select(r =>
                           new
                           {
                               r.ReceiptId,
                               r.CheckIn.CheckInDate,
                               r.EndDate,
                               r.Total
                           }).ToList();
                    hoaDonGridView.DataSource = Receipts;
                };
            }
            catch (Exception)
            {
                using (var context = new HotelContext())
                {
                    var Receipts = context.Receipts.Select(r =>
                           new
                           {
                               r.ReceiptId,
                               r.CheckIn.CheckInDate,
                               r.EndDate,
                               r.Total
                           }).ToList();
                    hoaDonGridView.DataSource = Receipts;
                };
            }
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            using (var context = new HotelContext())
            {
                var Receipts = context.Receipts.Select(r =>
                       new
                       {
                           r.ReceiptId,
                           r.CheckIn.CheckInDate,
                           r.EndDate,
                           r.Total
                       }).ToList();
                hoaDonGridView.DataSource = Receipts;
            };


        }
    }
}
