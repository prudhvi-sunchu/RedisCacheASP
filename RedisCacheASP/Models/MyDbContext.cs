using Microsoft.EntityFrameworkCore;
using RedisCacheASP.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace RedisCacheASP.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }
        public DbSet<ArticleMatrix>? ArticleMatrices { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}