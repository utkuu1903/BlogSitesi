using BlogSitesi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSitesi.context
{
    public class BlogDbContext : DbContext
    {
   public DbSet<Post> Posts { get; set; }
   public  DbSet<User> Users { get; set; }

 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   => optionsBuilder.UseSqlServer("server=DESKTOP-GHLRNIQ\\MSSQLSERVER01;database=BlogSiteDB;uid=sa;pwd=123;trustservercertificate=true");


    }
}
