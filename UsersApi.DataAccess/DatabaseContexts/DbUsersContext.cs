using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using UsersApi.Common;

namespace UsersApi.DataAccess.DatabaseContexts
{
    public class DbUsersContext : DbContext
    {
        public DbSet<User> UsersTable { get; set; }

        public DbUsersContext(DbContextOptions<DbUsersContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("tblUsers");
        }
    }
}