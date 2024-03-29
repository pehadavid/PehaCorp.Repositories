﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PehaCorp.Repositories.Abstractions.Tests.Repos;

namespace PehaCorp.Repositories.Abstractions.Tests.Migrations
{
    [DbContext(typeof(FakeDbContext))]
    partial class FakeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("PehaCorp.Repositories.Abstractions.Tests.Repos.Departement", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departements");
                });

            modelBuilder.Entity("PehaCorp.Repositories.Abstractions.Tests.Repos.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<double>("Salary")
                        .HasColumnType("REAL");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("PehaCorp.Repositories.Abstractions.Tests.Repos.Employee", b =>
                {
                    b.HasOne("PehaCorp.Repositories.Abstractions.Tests.Repos.Departement", "Departement")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("Departement");
                });

            modelBuilder.Entity("PehaCorp.Repositories.Abstractions.Tests.Repos.Departement", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
