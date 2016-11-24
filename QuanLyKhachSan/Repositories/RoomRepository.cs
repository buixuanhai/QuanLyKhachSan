using QuanLyKhachSan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Repositories
{
    public class RoomRepository : IRepository<Room>
    {
        public int create(Room item)
        {
            throw new NotImplementedException();
        }

        public int delete(Room item)
        {
            throw new NotImplementedException();
        }

        public List<Room> get()
        {
            throw new NotImplementedException();
        }

      

        public int update(Room item)
        {
            throw new NotImplementedException();
        }

        Room IRepository<Room>.get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
