using Messaging.Domain.Entities.UserPerson;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Infrastracture.Data
{
    public class UserManagementDbContext : DbContext
    {
        public UserManagementDbContext(DbContextOptions<UserManagementDbContext> options) : base(options) { }

        #region PersonUser

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<User> Users { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region PersonUser

            modelBuilder.Entity<Person>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<User>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<User>()
                .HasOne(p => p.Person)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Phone)
                .IsUnique()
                .HasFilter("Phone IS NOT NULL");

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique()
                .HasFilter("Email IS NOT NULL");

            modelBuilder.Entity<Person>().HasQueryFilter(u => u.IsDeleted == false);
            modelBuilder.Entity<User>().HasQueryFilter(u => u.IsDeleted == false);

            modelBuilder.Entity<User>().Property(u => u.Sort).Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore);

            #endregion
        }
    }
}
