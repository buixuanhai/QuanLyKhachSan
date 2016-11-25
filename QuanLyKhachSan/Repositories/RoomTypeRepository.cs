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
            _context.RoomTypes.Add(item);
            return  _context.SaveChanges();
        }

        public int Delete(RoomType item)
        {
            _context.RoomTypes.Attach(item);
            _context.RoomTypes.Remove(item);
            return _context.SaveChanges();
        }

        public List<RoomType> Get()
        {
            return _context.RoomTypes.ToList();
        }

        public RoomType Get(int id)
        {
            return _context.RoomTypes.SingleOrDefault(r => r.RoomTypeId == id);
        }

        public int Update(RoomType item)
        {
            _context.RoomTypes.Attach(item);
            return _context.SaveChanges();
        }

        
    }
}
