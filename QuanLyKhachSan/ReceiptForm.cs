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
    }
}
