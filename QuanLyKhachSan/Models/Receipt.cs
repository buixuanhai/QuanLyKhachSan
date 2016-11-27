using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{
    public class Receipt
    {

        public Receipt()
        {

        }

        public int ReceiptId { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Total { get; set; }

        public virtual CheckIn CheckIn { get; set; }
    }
}
