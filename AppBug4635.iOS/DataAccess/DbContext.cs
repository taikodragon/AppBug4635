using Microsoft.EntityFrameworkCore;
using System;
using System.IO;

namespace AppBug4635
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public string DatabasePath { get; private set; }
        public DbSet<Model.BuggedLargerNullableEntity> BuggedLargerNullableEntities { get; set; }
        public DbSet<Model.BuggedNullableEntity> BuggedNullableEntities { get; set; }
        public DbSet<Model.OkNullableEntity> OkNullableEntities { get; set; }
        public DbSet<Model.BuggedNotNullbaleEntity> BuggedNotNullableEntities { get; set; }
        public DbSet<Model.OkNotNullableEntity> OkNotNullableEntities { get; set; }

        public DbContext() : base()
        {
            DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "appbug59184.db");
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Filename={DatabasePath}");
        }
    }
}
