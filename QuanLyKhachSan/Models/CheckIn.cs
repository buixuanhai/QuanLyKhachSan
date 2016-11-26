using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{


    public class CheckIn
    {
        public CheckIn()
        {

        }

        public int CheckInId { get; set; }
        public DateTime StartDate { get; set; }
        public int CustomerIdentityNumber { get; set; }
        public virtual Room Room { get; set; }

        public virtual Receipt Receipt { get; set; }

    }
}
