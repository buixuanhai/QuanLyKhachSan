using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{

    public enum CustomerType
    {
        Domestic, 
        International
    }

    public class CheckIn
    {
        public CheckIn()
        {

        }

        public int CheckInId { get; set; }
        public DateTime CheckInDate { get; set; }
        public string CustomerIdentityNumber { get; set; }
        public string CusTomerName { get; set; }
        public CustomerType CustomerType { get; set; }
        public virtual Room Room { get; set; }

        public virtual Receipt Receipt { get; set; }

    }
}
