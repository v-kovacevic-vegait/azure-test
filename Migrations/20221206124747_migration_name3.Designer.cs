﻿// <auto-generated />
using System;
using MealForFamily.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MealForFamily.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221206124747_migration_name3")]
    partial class migration_name3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MealForFamily.Models.AboutUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NewTest")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RawDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AboutUs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "<h1>About us</h1></br><p>We are organisation meal for families 3M.</p>",
                            NewTest = "",
                            RawDescription = ""
                        });
                });

            modelBuilder.Entity("MealForFamily.Models.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReceiverAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReceiverCity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReceiverName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("text");

                    b.Property<string>("TransactionModel")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("BankAccount");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountNumber = "160-6000001255298-83",
                            PhoneNumber = "(00 381) 60 37-65-017",
                            ReceiverAddress = "Miše Dimitrijevića 3B",
                            ReceiverCity = "Novi Sad",
                            ReceiverName = "Obrok za porodicu 3M",
                            ReferenceNumber = "",
                            TransactionModel = ""
                        });
                });

            modelBuilder.Entity("MealForFamily.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "obrokzaporodicu3m@gmail.com",
                            IsDeleted = false,
                            PhoneNumber = "(00 381) 60 37-65-017",
                            Title = "Obrok za porodicu 3M"
                        });
                });

            modelBuilder.Entity("MealForFamily.Models.Donation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool?>("IsCompany")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool?>("IsPickup")
                        .HasColumnType("boolean");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("VolunteerActionId")
                        .HasColumnType("integer");

                    b.Property<int?>("VolunteerActionTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("VolunteerActionId");

                    b.HasIndex("VolunteerActionTypeId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("MealForFamily.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("RawDescription")
                        .HasColumnType("text");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("MealForFamily.Models.NewsletterSubscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("NewsletterSubscriptions");
                });

            modelBuilder.Entity("MealForFamily.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MealForFamily.Models.VolunteerAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageURL")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("RawDescription")
                        .HasColumnType("text");

                    b.Property<string>("ReferenceNumber")
                        .HasColumnType("text");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("text");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.ToTable("VolunteerActions");
                });

            modelBuilder.Entity("MealForFamily.Models.VolunteerActionStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("VolunteerActionStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Trenutno u toku"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Uspešno završena"
                        });
                });

            modelBuilder.Entity("MealForFamily.Models.VolunteerActionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool?>("HasPayment")
                        .HasColumnType("boolean");

                    b.Property<bool?>("HasPickup")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("VolunteerActionTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasPayment = false,
                            HasPickup = true,
                            IsDeleted = false,
                            Name = "Hrana"
                        },
                        new
                        {
                            Id = 2,
                            HasPayment = true,
                            HasPickup = false,
                            IsDeleted = false,
                            Name = "Novac"
                        },
                        new
                        {
                            Id = 3,
                            HasPayment = false,
                            HasPickup = true,
                            IsDeleted = false,
                            Name = "Odeća i obuća"
                        },
                        new
                        {
                            Id = 4,
                            HasPayment = false,
                            HasPickup = true,
                            IsDeleted = false,
                            Name = "Igračke"
                        },
                        new
                        {
                            Id = 5,
                            HasPayment = false,
                            HasPickup = true,
                            IsDeleted = false,
                            Name = "Ostalo"
                        });
                });

            modelBuilder.Entity("MealForFamily.Models.Donation", b =>
                {
                    b.HasOne("MealForFamily.Models.VolunteerAction", "VolunteerAction")
                        .WithMany("Donations")
                        .HasForeignKey("VolunteerActionId");

                    b.HasOne("MealForFamily.Models.VolunteerActionType", "VolunteerActionType")
                        .WithMany("Donations")
                        .HasForeignKey("VolunteerActionTypeId");

                    b.Navigation("VolunteerAction");

                    b.Navigation("VolunteerActionType");
                });

            modelBuilder.Entity("MealForFamily.Models.VolunteerAction", b =>
                {
                    b.HasOne("MealForFamily.Models.VolunteerActionStatus", "Status")
                        .WithMany("VolunteerActions")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MealForFamily.Models.VolunteerActionType", "Type")
                        .WithMany("VolunteerActions")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("MealForFamily.Models.VolunteerAction", b =>
                {
                    b.Navigation("Donations");
                });

            modelBuilder.Entity("MealForFamily.Models.VolunteerActionStatus", b =>
                {
                    b.Navigation("VolunteerActions");
                });

            modelBuilder.Entity("MealForFamily.Models.VolunteerActionType", b =>
                {
                    b.Navigation("Donations");

                    b.Navigation("VolunteerActions");
                });
#pragma warning restore 612, 618
        }
    }
}
