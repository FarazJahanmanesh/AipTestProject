using Common.Utilities;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        #region add tables

            public DbSet<User> Users { get; set; }
            public DbSet<Post> Posts { get; set; }
            public DbSet<Role> Roles { get; set; }
            public DbSet<Category> Categories { get; set; }

        #endregion
        //create our models
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    var entitiesAssembly = typeof(IEntity).Assembly;
        //    modelBuilder.RegisterAllEntities<IEntity>(entitiesAssembly);
        //    modelBuilder.RegisterEntityTypeConfiguration(entitiesAssembly);
        //    modelBuilder.AddSequentialGuidForIdConvention();
        //    modelBuilder.AddPluralizingTableNameConvention();
        //}
    }
}
