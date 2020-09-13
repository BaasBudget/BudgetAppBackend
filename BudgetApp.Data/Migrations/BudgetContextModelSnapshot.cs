﻿// <auto-generated />
using System;
using BudgetApp.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BudgetApp.Data.Migrations
{
    [DbContext(typeof(BudgetContext))]
    partial class BudgetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("BudgetApp.Data.Models.Account", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("AccountBalance")
                        .HasColumnType("TEXT");

                    b.Property<string>("AccountName")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccountType")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BudgetApp.Data.Models.BudgetItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("AllottedBalance")
                        .HasColumnType("TEXT");

                    b.Property<long?>("CatagoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Month")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CatagoryId");

                    b.HasIndex("UserId");

                    b.ToTable("BudgetItems");
                });

            modelBuilder.Entity("BudgetApp.Data.Models.Catagory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CatagoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Catagories");
                });

            modelBuilder.Entity("BudgetApp.Data.Models.Transaction", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.Property<long?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("BudgetApp.Data.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TotalBalance")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BudgetApp.Data.Models.Account", b =>
                {
                    b.HasOne("BudgetApp.Data.Models.User", "UserName")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BudgetApp.Data.Models.User", null)
                        .WithMany("UserAccounts")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BudgetApp.Data.Models.BudgetItem", b =>
                {
                    b.HasOne("BudgetApp.Data.Models.Catagory", "Catagory")
                        .WithMany()
                        .HasForeignKey("CatagoryId");

                    b.HasOne("BudgetApp.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BudgetApp.Data.Models.Transaction", b =>
                {
                    b.HasOne("BudgetApp.Data.Models.Account", "TransactionAccount")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BudgetApp.Data.Models.Catagory", "Catagory")
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BudgetApp.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
