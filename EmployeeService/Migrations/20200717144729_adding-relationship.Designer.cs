﻿// <auto-generated />
using System;
using EmployeeService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmployeeService.Migrations
{
    [DbContext(typeof(EmployeeAppDbContext))]
    [Migration("20200717144729_adding-relationship")]
    partial class addingrelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmployeeService.Models.CompanyProject", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Pname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pid");

                    b.ToTable("CompanyProjects");
                });

            modelBuilder.Entity("EmployeeService.Models.Employee", b =>
                {
                    b.Property<int>("Eid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DOJ")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ename")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectPid")
                        .HasColumnType("int");

                    b.HasKey("Eid");

                    b.HasIndex("ProjectPid");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("EmployeeService.Models.Employee", b =>
                {
                    b.HasOne("EmployeeService.Models.CompanyProject", "Project")
                        .WithMany("Employees")
                        .HasForeignKey("ProjectPid");
                });
#pragma warning restore 612, 618
        }
    }
}
