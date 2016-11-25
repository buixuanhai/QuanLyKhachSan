using Ninject;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    public class Injection
    {
        public  static IKernel kernel = new StandardKernel();

        public static void Initialize()
        {
            kernel.Bind<HotelContext>().To<HotelContext>();
            kernel.Bind<IRepository<Receipt>>().To<ReceiptRepository>();
            kernel.Bind<IRepository<CheckIn>>().To<CheckInRepository>();
            kernel.Bind<IRepository<Room>>().To<RoomRepository>();
            kernel.Bind<IRepository<RoomType>>().To<RoomTypeRepository>();
        }
    }
}
