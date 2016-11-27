using QuanLyKhachSan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Repositories
{
    public class ReceiptRepository : IRepository<Receipt>
    {
        private HotelContext _context;
        public ReceiptRepository(HotelContext context)
        {
            _context = context;
        }

        public int Create(Receipt item)
        {
            _context.Receipts.Add(item);
            return _context.SaveChanges();
        }

        public int Delete(Receipt item)
        {
            _context.Receipts.Remove(item);
            return _context.SaveChanges();

        }

        public List<Receipt> Get()
        {
            return _context.Receipts.ToList();
        }

        public int Update(Receipt item)
        {
            _context.Receipts.Attach(item);
            return _context.SaveChanges();

        }

        Receipt IRepository<Receipt>.Get(int id)
        {
            return _context.Receipts.Find(id);
        }
    }
}
