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
        private HotelContext _context;

        public RoomRepository(HotelContext context)
        {
            _context = context;
        }
        public int Create(Room item)
        {
            _context.Rooms.Add(item);
            return _context.SaveChanges();
        }

        public int Delete(Room item)
        {
            //_context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            Room r = Get(item.RoomId);
            //_context.Rooms.Attach(r);
            _context.Rooms.Remove( r);

            return _context.SaveChanges();
        }

        public List<Room> Get()
        {
            return _context.Rooms.ToList();
        }

        public int Update(Room item)
        {
            _context.Rooms.Attach(item);
            return _context.SaveChanges();

        }

        public Room Get(int id)
        {
            return _context.Rooms.Find(id);
        }
    }
}
