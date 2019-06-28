﻿// <auto-generated />
using CoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreApp.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    [Migration("20190627091326_InitMigration")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreApp.Models.Department", b =>
                {
                    b.Property<int>("DeptRowId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity");

                    b.Property<string>("DeptName")
                        .IsRequired();

                    b.Property<string>("DeptNo")
                        .IsRequired();

                    b.Property<string>("Location")
                        .IsRequired();

                    b.HasKey("DeptRowId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CoreApp.Models.Employee", b =>
                {
                    b.Property<int>("EmpRowId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DeptRowId");

                    b.Property<string>("Designation")
                        .IsRequired();

                    b.Property<string>("EmpName")
                        .IsRequired();

                    b.Property<string>("EmpNo")
                        .IsRequired();

                    b.Property<int>("Salary");

                    b.HasKey("EmpRowId");

                    b.HasIndex("DeptRowId");

                    b.ToTable("Emplopyees");
                });

            modelBuilder.Entity("CoreApp.Models.Employee", b =>
                {
                    b.HasOne("CoreApp.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DeptRowId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
