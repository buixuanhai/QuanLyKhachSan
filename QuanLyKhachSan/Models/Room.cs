using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{

    public enum RoomStatus
    {
        Empty,
        Ocuppied,
        Unavailable
    }
    public class Room
    {
        public Room()
        {

        }

        public int RoomId { set; get; }
        public int RoomCode { get; set; }
        public RoomStatus RoomStatus { get; set; }

        public virtual RoomType RoomType { get;set;}
        public virtual ICollection<CheckIn> CheckIns { get; set; }


}
}
