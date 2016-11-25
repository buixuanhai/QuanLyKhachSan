using QuanLyKhachSan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Repositories
{
    public class CheckInRepository : IRepository<CheckIn>
    {
        public int Create(CheckIn item)
        {
            throw new NotImplementedException();
        }

        public int Delete(CheckIn item)
        {
            throw new NotImplementedException();
        }

        public List<CheckIn> Get()
        {
            throw new NotImplementedException();
        }


        public int Update(CheckIn item)
        {
            throw new NotImplementedException();
        }

        CheckIn IRepository<CheckIn>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
