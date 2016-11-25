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
        public int Create(Receipt item)
        {
            throw new NotImplementedException();
        }

        public int Delete(Receipt item)
        {
            throw new NotImplementedException();
        }

        public List<Receipt> Get()
        {
            throw new NotImplementedException();
        }

        public int Update(Receipt item)
        {
            throw new NotImplementedException();
        }

        Receipt IRepository<Receipt>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
