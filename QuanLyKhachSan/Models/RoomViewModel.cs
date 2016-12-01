using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{
    public class RoomViewModel
    {
        public int RoomId { set; get; }
        public int RoomCode { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }

        public string DisplayName {
            get
            {
                return RoomCode + " (" + RoomType + " - " + Price + ")";
            }
        }
    }
}
