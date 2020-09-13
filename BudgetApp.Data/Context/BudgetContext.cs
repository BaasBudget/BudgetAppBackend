using BudgetApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetApp.Data.Context
{
    public class BudgetContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<BudgetItem> BudgetItems { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public BudgetContext(DbContextOptions<BudgetContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Should resolve the one to many relationship between users and accounts. Not sure it does though 
            modelBuilder.Entity<Account>()
                .HasOne(a => a.UserName)
                .WithMany()
                .HasForeignKey(u => u.Id)
                .IsRequired();

            // Similar to the statement above should resolve a one to many relationships one account can have many transactions 
            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.TransactionAccount)
                .WithMany()
                .HasForeignKey(a => a.Id)
                .IsRequired();

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Catagory)
                .WithMany()
                .HasForeignKey(c => c.Id);
        }
    }
}
