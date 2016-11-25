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
        private HotelContext _context;
        public RoomTypeRepository(HotelContext context)
        {
            _context = context;
        }
        public int Create(RoomType item)
        {
            throw new NotImplementedException();
        }

        public int Delete(RoomType item)
        {
            throw new NotImplementedException();
        }

        public List<RoomType> Get()
        {
            throw new NotImplementedException();
        }

        public RoomType Get(int id)
        {
            return _context.RoomTypes.SingleOrDefault(r => r.RoomTypeId == id);
        }

        public int Update(RoomType item)
        {
            throw new NotImplementedException();
        }

        
    }
}
