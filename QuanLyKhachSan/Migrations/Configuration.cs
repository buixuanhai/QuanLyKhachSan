namespace QuanLyKhachSan.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuanLyKhachSan.Models.HotelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        
        
        protected override void Seed(QuanLyKhachSan.Models.HotelContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //context.RoomTypes.AddOrUpdate(new RoomType
            //{
            //    Name = "VIP",
            //    Price = 200000
            //});

            //context.RoomTypes.AddOrUpdate(new RoomType
            //{
            //    Name = "Thường",
            //    Price = 150000
            //});

            context.SaveChanges();
        }
    }
}
