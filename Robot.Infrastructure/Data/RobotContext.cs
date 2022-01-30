using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Robot.Infrastructure.Data
{
    public class RobotContext : DbContext
    {

        public RobotContext(DbContextOptions<RobotContext> options) : base(options)
        {

        }

        public DbSet<Robot.Core.Entities.RobotEntity> Robots { get; set; }
        public DbSet<Robot.Core.Entities.TroubleEntity> Troubles { get; set; }
        public DbSet<Robot.Core.Entities.CoordinatesEntity> Coordinates { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Robot.Core.Entities.RobotEntity>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Robot.Core.Entities.TroubleEntity>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Robot.Core.Entities.CoordinatesEntity>().Property(x => x.Id).HasDefaultValueSql("NEWID()");


        }
    }
}
