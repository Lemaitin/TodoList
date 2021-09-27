using Microsoft.EntityFrameworkCore;
using System;
using TodoList.Models;

namespace TodoList.Context
{
    public class TodoDbContext : DbContext, IDisposable
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public TodoDbContext(DbContextOptions<TodoDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>()
                .Property(b => b.Name)
                .IsRequired();
        }
    }
}