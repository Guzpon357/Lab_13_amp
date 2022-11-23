using Lab_13.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13.DataContext
{
    public class AppDbContext : DbContext
    {
        string DbPath = string.Empty;

        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }

        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Album> Albumes { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");

        }
    }
}
