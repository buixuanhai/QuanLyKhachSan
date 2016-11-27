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

        private HotelContext _context;

        public CheckInRepository(HotelContext context)
        {
            _context = context;
        }

        public int Create(CheckIn item)
        {
            _context.CheckIns.Add(item);
            return _context.SaveChanges();
        }

        public int Delete(CheckIn item)
        {
            _context.CheckIns.Remove(item);
            return _context.SaveChanges();
        }

        public List<CheckIn> Get()
        {
            return _context.CheckIns.ToList();
        }


        public int Update(CheckIn item)
        {
            _context.CheckIns.Attach(item);
            return _context.SaveChanges();
        }

        CheckIn IRepository<CheckIn>.Get(int id)
        {
            return _context.CheckIns.Find(id);
        }
    }
}
