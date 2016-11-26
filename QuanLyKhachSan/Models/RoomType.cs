using System.Collections.Generic;

namespace QuanLyKhachSan.Models
{
    public class RoomType
    {

        public RoomType()
        {

        }

        public int RoomTypeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }



}