using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BookStore.lib
{
    public partial class ModelEntity : DbContext
    {
        public ModelEntity()
            : base("name=ModelEntity")
        {
        }

        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.City)
                .IsUnicode(false);
        }
    }
}
