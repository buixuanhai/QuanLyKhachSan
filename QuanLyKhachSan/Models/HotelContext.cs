using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Models
{
    public class HotelContext : DbContext
    {
        public HotelContext() : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Room>()
                .HasMany(r => r.CheckIns)
                .WithRequired(c => c.Room)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CheckIn>()
                .HasOptional(c => c.Receipt)
                .WithRequired(r => r.CheckIn)
                .WillCascadeOnDelete();

        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<CheckIn> CheckIns { get; set; }
    }
}
