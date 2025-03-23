﻿// <auto-generated />
using System;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250323074106_AddTripPlanCars")]
    partial class AddTripPlanCars
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccessLayer.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BookingType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("end_date_time");

                    b.Property<int>("NumOfPassengers")
                        .HasColumnType("int")
                        .HasColumnName("numOfPassengers");

                    b.Property<DateTime>("StartDateTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2(7)")
                        .HasDefaultValue(new DateTime(2025, 3, 23, 10, 41, 6, 533, DateTimeKind.Local).AddTicks(9268))
                        .HasColumnName("start_date_time");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.ToTable("Bookings", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("capacity");

                    b.Property<string>("CarStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("status");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("categoryId");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("color");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("image");

                    b.Property<decimal>("Mbw")
                        .HasColumnType("decimal(12,2)")
                        .HasColumnName("mbw");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("model");

                    b.Property<decimal>("Ppd")
                        .HasColumnType("decimal(12,2)")
                        .HasColumnName("price_per_day");

                    b.Property<decimal>("Pph")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cars", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.CarBooking", b =>
                {
                    b.Property<int>("BookingId")
                        .HasColumnType("int")
                        .HasColumnName("booking_id");

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("car_id");

                    b.Property<string>("DropoffLocation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("dropOffLocation");

                    b.Property<string>("PickupLocation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("pickUpLocation");

                    b.Property<bool>("WithDriver")
                        .HasColumnType("bit")
                        .HasColumnName("withDriver");

                    b.HasKey("BookingId");

                    b.HasIndex("CarId", "BookingId")
                        .IsUnique();

                    b.ToTable("CarBookings", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.ImageShot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int")
                        .HasColumnName("bookingId");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("path");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.ToTable("ImageShots", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("AmountDue")
                        .HasColumnType("decimal(12,2)")
                        .HasColumnName("amountDue");

                    b.Property<decimal>("AmountPaid")
                        .HasColumnType("decimal(12,2)")
                        .HasColumnName("amountPaid");

                    b.Property<int>("BookingId")
                        .HasColumnType("int")
                        .HasColumnName("bookingId");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("")
                        .HasColumnName("notes");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("paymentDate");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("BookingId");

                    b.ToTable("Payments", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.PaymentMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("icon");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("method");

                    b.HasKey("Id");

                    b.HasIndex("Method")
                        .IsUnique();

                    b.ToTable("PaymentMethods", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.PaymentTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(12,2)")
                        .HasColumnName("amount");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int")
                        .HasColumnName("paymentId");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("int")
                        .HasColumnName("paymentMethodId");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("transactionDate");

                    b.Property<string>("TransactionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("transaction_type");

                    b.HasKey("Id");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("PaymentId", "PaymentMethodId")
                        .IsUnique();

                    b.ToTable("PaymentTransactions", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Regions", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPrivate")
                        .HasColumnType("bit");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trip");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.TripBooking", b =>
                {
                    b.Property<int>("BookingId")
                        .HasColumnType("int")
                        .HasColumnName("booking_id");

                    b.Property<int>("TripPlanId")
                        .HasColumnType("int")
                        .HasColumnName("tripPlanId");

                    b.Property<bool>("WithGuide")
                        .HasColumnType("bit")
                        .HasColumnName("withGuide");

                    b.HasKey("BookingId");

                    b.HasIndex("TripPlanId", "BookingId")
                        .IsUnique();

                    b.ToTable("TripBookings", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.TripPlan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Duration")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("duration");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("end_date_time");

                    b.Property<string>("HotelsStays")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("")
                        .HasColumnName("hotels_stays");

                    b.Property<string>("IndudedServices")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("")
                        .HasColumnName("induded_services");

                    b.Property<string>("MealsPlan")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("")
                        .HasColumnName("meals_plan");

                    b.Property<int>("RegionId")
                        .HasColumnType("int")
                        .HasColumnName("regionId");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("start_date_time");

                    b.Property<string>("Stops")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TripId")
                        .HasColumnType("int")
                        .HasColumnName("tripId");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.HasIndex("TripId");

                    b.ToTable("TripPlans", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.TripPlanCar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int")
                        .HasColumnName("car_id");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(12,2)")
                        .HasColumnName("price");

                    b.Property<int>("TripPlanId")
                        .HasColumnType("int")
                        .HasColumnName("trip_plan_id");

                    b.HasKey("Id");

                    b.HasIndex("TripPlanId");

                    b.HasIndex("CarId", "TripPlanId")
                        .IsUnique();

                    b.ToTable("TripPlanCars", (string)null);
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Car", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Category", "Category")
                        .WithMany("Cars")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.CarBooking", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Booking", "Booking")
                        .WithOne("CarBooking")
                        .HasForeignKey("DataAccessLayer.Entities.CarBooking", "BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Entities.Car", "Car")
                        .WithMany("CarBookings")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Car");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.ImageShot", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Booking", "Booking")
                        .WithMany("ImageShots")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Payment", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Booking", "Booking")
                        .WithMany("Payments")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.PaymentTransaction", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Payment", "Payment")
                        .WithMany("PaymentTransactions")
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Entities.PaymentMethod", "PaymentMethod")
                        .WithMany("PaymentTransctions")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.TripBooking", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Booking", "Booking")
                        .WithOne("TripBooking")
                        .HasForeignKey("DataAccessLayer.Entities.TripBooking", "BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Entities.TripPlan", "TripPlan")
                        .WithMany("TripBookings")
                        .HasForeignKey("TripPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("TripPlan");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.TripPlan", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Region", "Region")
                        .WithMany("TripPlans")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Entities.Trip", "Trip")
                        .WithMany("TripPlans")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Region");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.TripPlanCar", b =>
                {
                    b.HasOne("DataAccessLayer.Entities.Car", "Car")
                        .WithMany("TripPlanCars")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccessLayer.Entities.TripPlan", "TripPlan")
                        .WithMany("TripPlanCars")
                        .HasForeignKey("TripPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("TripPlan");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Booking", b =>
                {
                    b.Navigation("CarBooking");

                    b.Navigation("ImageShots");

                    b.Navigation("Payments");

                    b.Navigation("TripBooking");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Car", b =>
                {
                    b.Navigation("CarBookings");

                    b.Navigation("TripPlanCars");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Category", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Payment", b =>
                {
                    b.Navigation("PaymentTransactions");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.PaymentMethod", b =>
                {
                    b.Navigation("PaymentTransctions");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Region", b =>
                {
                    b.Navigation("TripPlans");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.Trip", b =>
                {
                    b.Navigation("TripPlans");
                });

            modelBuilder.Entity("DataAccessLayer.Entities.TripPlan", b =>
                {
                    b.Navigation("TripBookings");

                    b.Navigation("TripPlanCars");
                });
#pragma warning restore 612, 618
        }
    }
}
