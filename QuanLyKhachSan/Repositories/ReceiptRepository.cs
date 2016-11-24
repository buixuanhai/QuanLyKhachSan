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
        public int create(Receipt item)
        {
            throw new NotImplementedException();
        }

        public int delete(Receipt item)
        {
            throw new NotImplementedException();
        }

        public List<Receipt> get()
        {
            throw new NotImplementedException();
        }

        public int update(Receipt item)
        {
            throw new NotImplementedException();
        }

        Receipt IRepository<Receipt>.get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
