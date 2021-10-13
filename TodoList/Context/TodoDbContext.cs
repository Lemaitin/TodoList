using Microsoft.EntityFrameworkCore;
using System;
using TodoList.Models;

namespace TodoList.Context
{
    public class TodoDbContext : DbContext, IDisposable
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<DeadlineType> DeadlineTypes { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public TodoDbContext(DbContextOptions<TodoDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>()
                .Property(b => b.CreatedDate)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<TodoItem>()
                .Property(b => b.Name)
                .IsRequired();

            modelBuilder.Entity<DeadlineType>()
                .HasData(
                new DeadlineType { Type = "In this month", Id = 1 });

            modelBuilder.Entity<Status>()
                .HasData(
                new Status { Name = "In progress", Id = 1 });

            modelBuilder.Entity<TodoItem>()
                .HasData(
                new TodoItem { Name = "training", StatusId = 1, Id = 1 });
        }
    }
}