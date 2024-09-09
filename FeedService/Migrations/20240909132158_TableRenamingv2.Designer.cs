﻿// <auto-generated />
using System;
using FeedService.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FeedService.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240909132158_TableRenamingv2")]
    partial class TableRenamingv2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FeedService.DataLayer.DataModels.Column", b =>
                {
                    b.Property<int>("ColumnId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColumnId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColumnId");

                    b.ToTable("Columns");
                });

            modelBuilder.Entity("FeedService.DataLayer.DataModels.Day", b =>
                {
                    b.Property<int>("DayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DayId"));

                    b.Property<int>("ColumnId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.HasKey("DayId");

                    b.HasIndex("ColumnId")
                        .IsUnique();

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("Days");
                });

            modelBuilder.Entity("FeedService.DataLayer.DataModels.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemId"));

                    b.Property<double>("Cost")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("FeedService.DataLayer.DataModels.Day", b =>
                {
                    b.HasOne("FeedService.DataLayer.DataModels.Column", "Column")
                        .WithOne("Table")
                        .HasForeignKey("FeedService.DataLayer.DataModels.Day", "ColumnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FeedService.DataLayer.DataModels.Item", "Item")
                        .WithOne("Table")
                        .HasForeignKey("FeedService.DataLayer.DataModels.Day", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Column");

                    b.Navigation("Item");
                });

            modelBuilder.Entity("FeedService.DataLayer.DataModels.Column", b =>
                {
                    b.Navigation("Table")
                        .IsRequired();
                });

            modelBuilder.Entity("FeedService.DataLayer.DataModels.Item", b =>
                {
                    b.Navigation("Table")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
