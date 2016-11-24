using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Repositories
{
    public interface IRepository<T>
    {
        List<T> get();
        T get(int id);
        int create(T item);
        int update(T item);
        int delete(T item); 
    }
}
