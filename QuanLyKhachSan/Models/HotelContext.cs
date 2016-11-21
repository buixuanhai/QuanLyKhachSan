using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{
    class HotelContext : DbContext
    {
        public HotelContext(): base("DefaultConnection")
        {

        }

       
    }
}
