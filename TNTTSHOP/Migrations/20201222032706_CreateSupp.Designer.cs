﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TNTTSHOP.Areas.Admin.Data;

namespace TNTTSHOP.Migrations
{
    [DbContext(typeof(DPContext))]
    [Migration("20201222032706_CreateSupp")]
    partial class CreateSupp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("TNTTSHOP.Areas.Admin.Models.CategoryModel", b =>
                {
                    b.Property<int>("MaCate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("MaCate");

                    b.ToTable("CategoryModel");
                });

            modelBuilder.Entity("TNTTSHOP.Areas.Admin.Models.ProductModel", b =>
                {
                    b.Property<int>("MaPro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("quantity")
                        .HasColumnType("float");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("MaPro");

                    b.HasIndex("Category");

                    b.ToTable("ProductModels");
                });

            modelBuilder.Entity("TNTTSHOP.Areas.Admin.Models.SupplientModel", b =>
                {
                    b.Property<int>("MaSupp")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("MaSupp");

                    b.ToTable("SupplientModel");
                });

            modelBuilder.Entity("TNTTSHOP.Areas.Admin.Models.UserModel", b =>
                {
                    b.Property<int>("maUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sdt")
                        .HasColumnType("int");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("maUser");

                    b.ToTable("UserModels");
                });

            modelBuilder.Entity("TNTTSHOP.Areas.Admin.Models.ProductModel", b =>
                {
                    b.HasOne("TNTTSHOP.Areas.Admin.Models.CategoryModel", "CategoryModel")
                        .WithMany("sltPro")
                        .HasForeignKey("Category")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoryModel");
                });

            modelBuilder.Entity("TNTTSHOP.Areas.Admin.Models.CategoryModel", b =>
                {
                    b.Navigation("sltPro");
                });
#pragma warning restore 612, 618
        }
    }
}
