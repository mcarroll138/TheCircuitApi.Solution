﻿// <auto-generated />
using CircuitCalendarApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CircuitCalendarApi.Migrations
{
    [DbContext(typeof(CircuitCalendarApiContext))]
    partial class CircuitCalendarApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CircuitCalendarApi.Models.CalendarEvent", b =>
                {
                    b.Property<int>("CalendarEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("CalendarEventId");

                    b.ToTable("CalendarEvents");
                });
#pragma warning restore 612, 618
        }
    }
}
