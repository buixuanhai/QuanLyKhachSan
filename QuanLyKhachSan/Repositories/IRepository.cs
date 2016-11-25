using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Repositories
{
    public interface IRepository<T>
    {
        List<T> Get();
        T Get(int id);
        int Create(T item);
        int Update(T item);
        int Delete(T item); 
    }
}
