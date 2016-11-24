using QuanLyKhachSan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Repositories
{
    public class RoomTypeRepository : IRepository<RoomType>
    {
        public int create(RoomType item)
        {
            throw new NotImplementedException();
        }

        public int delete(RoomType item)
        {
            throw new NotImplementedException();
        }

        public List<RoomType> get()
        {
            throw new NotImplementedException();
        }

        public int update(RoomType item)
        {
            throw new NotImplementedException();
        }

        RoomType IRepository<RoomType>.get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
