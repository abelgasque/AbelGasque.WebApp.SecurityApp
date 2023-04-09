﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SecurityApp.Web.Infrastructure.Entities.Models;

namespace SecurityApp.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SecurityApp.Web.Infrastructure.Entities.Models.CustomerModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID_CUSTOMER");

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("ACTIVE");

                    b.Property<int>("AuthAttempts")
                        .HasColumnType("int")
                        .HasColumnName("AUTH_ATTEMPTS");

                    b.Property<bool>("Block")
                        .HasColumnType("bit")
                        .HasColumnName("BLOCK");

                    b.Property<string>("Code")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("CODE");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATION_DATE");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FIRST_NAME");

                    b.Property<Guid>("IdCustomerRole")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID_CUSTOMER_ROLE");

                    b.Property<bool>("IsNewCustomer")
                        .HasColumnType("bit")
                        .HasColumnName("IS_NEW_CUSTOMER");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("LAST_NAME");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("MAIL");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("PASSWORD");

                    b.Property<string>("PasswordTemp")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("PASSWORD_TEMP");

                    b.Property<DateTime?>("PasswordTempDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("PASSWORD_TEMP_DATE");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UPDATE_DATE");

                    b.HasKey("Id");

                    b.HasIndex("Mail")
                        .IsUnique();

                    b.ToTable("CUSTOMER");

                    b.HasData(
                        new
                        {
                            Id = new Guid("08c26113-f776-4b2d-bc76-7d1e1fa7ec3a"),
                            Active = true,
                            AuthAttempts = 0,
                            Block = false,
                            CreationDate = new DateTime(2023, 4, 9, 10, 57, 16, 174, DateTimeKind.Local).AddTicks(1019),
                            FirstName = "Abel",
                            IdCustomerRole = new Guid("34b23fbf-8eae-4cb9-b6ee-8cd2a30a8197"),
                            IsNewCustomer = false,
                            LastName = "Gasque L. Silva",
                            Mail = "contato.abelgasque@gmail.com",
                            Password = "admin"
                        });
                });

            modelBuilder.Entity("SecurityApp.Web.Infrastructure.Entities.Models.CustomerRoleModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID_CUSTOMER_ROLE");

                    b.Property<bool>("Active")
                        .HasColumnType("bit")
                        .HasColumnName("ACTIVE");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CODE");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATION_DATE");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NAME");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("UPDATE_DATE");

                    b.HasKey("Id");

                    b.ToTable("CUSTOMER_ROLE");

                    b.HasData(
                        new
                        {
                            Id = new Guid("34b23fbf-8eae-4cb9-b6ee-8cd2a30a8197"),
                            Active = true,
                            Code = "ROLE_ADMINISTRATOR",
                            CreationDate = new DateTime(2023, 4, 9, 10, 57, 16, 172, DateTimeKind.Local).AddTicks(9037),
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = new Guid("0e698570-760b-48fa-9973-929005f50875"),
                            Active = true,
                            Code = "ROLE_CUSTOMER",
                            CreationDate = new DateTime(2023, 4, 9, 10, 57, 16, 174, DateTimeKind.Local).AddTicks(467),
                            Name = "Customer"
                        });
                });

            modelBuilder.Entity("SecurityApp.Web.Infrastructure.Entities.Models.DeviceModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID_DEVICE");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CODE");

                    b.Property<DateTime?>("CodeDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("CODE_DATE");

                    b.Property<DateTime?>("CreationDate")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATION_DATE");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("EXPIRATION_DATE");

                    b.Property<Guid>("IdCustomer")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID_CUSTOMER");

                    b.Property<bool>("Online")
                        .HasColumnType("bit")
                        .HasColumnName("ONLINE");

                    b.HasKey("Id");

                    b.ToTable("DEVICE");
                });

            modelBuilder.Entity("SecurityApp.Web.Infrastructure.Entities.Models.MailMessageModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID_MAIL_MESSAGE");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BODY");

                    b.Property<DateTime?>("CreationDate")
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasColumnName("CREATION_DATE");

                    b.Property<Guid>("IdCustomer")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID_CUSTOMER");

                    b.Property<DateTime?>("SendDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("SEND_DATE");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TITLE");

                    b.HasKey("Id");

                    b.ToTable("MAIL_MESSAGE");
                });
#pragma warning restore 612, 618
        }
    }
}
