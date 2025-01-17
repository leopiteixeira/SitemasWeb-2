﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi.Context;

#nullable disable

namespace WebApi.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("WebApi.Model.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUserId");

                    b.HasIndex("UpdatedByUserId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WebApi.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("WebApi.Model.Product", b =>
                {
                    b.HasOne("WebApi.Model.User", "CreatedByUser")
                        .WithMany("CreatedByUser")
                        .HasForeignKey("CreatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("WebApi.Model.User", "UpdatedByUser")
                        .WithMany("UpdatedByUser")
                        .HasForeignKey("UpdatedByUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");
                });

            modelBuilder.Entity("WebApi.Model.User", b =>
                {
                    b.Navigation("CreatedByUser");

                    b.Navigation("UpdatedByUser");
                });
#pragma warning restore 612, 618
        }
    }
}
