﻿// <auto-generated />
using System;
using Architecture.DataBase.CodeFirst;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Architecture.DataBase.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190916082035_ProjectInit")]
    partial class ProjectInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Architecture.DataBase.CodeFirst.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNo");

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime?>("CreatedUTCDate");

                    b.Property<string>("EmailId");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsApproved");

                    b.Property<string>("LastName");

                    b.Property<string>("LoginAttempt");

                    b.Property<string>("Password");

                    b.Property<string>("ProfilePic");

                    b.Property<long?>("UpdatedBy");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<DateTime?>("UpdatedUTCDate");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
