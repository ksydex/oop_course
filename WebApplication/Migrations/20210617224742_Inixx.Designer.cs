// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WebApplication.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210617224742_Inixx")]
    partial class Inixx
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Data.Entities.Bus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Manufacturer")
                        .HasColumnType("text");

                    b.Property<string>("Model")
                        .HasColumnType("text");

                    b.Property<int>("Places")
                        .HasColumnType("integer");

                    b.Property<string>("Plate")
                        .HasColumnType("text");

                    b.Property<int>("YearOfIssue")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("Data.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("DateBirthday")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Data.Entities.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Cost")
                        .HasColumnType("double precision");

                    b.Property<double>("Length")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("Data.Entities.Route2Stop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("RouteId")
                        .HasColumnType("integer");

                    b.Property<int>("StopId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RouteId");

                    b.HasIndex("StopId");

                    b.ToTable("Route2Stops");
                });

            modelBuilder.Entity("Data.Entities.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BusId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DriverId")
                        .HasColumnType("integer");

                    b.Property<int>("RouteId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BusId");

                    b.HasIndex("DriverId");

                    b.HasIndex("RouteId");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("Data.Entities.Stop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Stops");
                });

            modelBuilder.Entity("Data.Entities.Route2Stop", b =>
                {
                    b.HasOne("Data.Entities.Route", "Route")
                        .WithMany("Route2Stops")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Stop", "Stop")
                        .WithMany()
                        .HasForeignKey("StopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Route");

                    b.Navigation("Stop");
                });

            modelBuilder.Entity("Data.Entities.Shift", b =>
                {
                    b.HasOne("Data.Entities.Bus", "Bus")
                        .WithMany("Shifts")
                        .HasForeignKey("BusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Driver", "Driver")
                        .WithMany("Shifts")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entities.Route", "Route")
                        .WithMany("Shifts")
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bus");

                    b.Navigation("Driver");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("Data.Entities.Bus", b =>
                {
                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("Data.Entities.Driver", b =>
                {
                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("Data.Entities.Route", b =>
                {
                    b.Navigation("Route2Stops");

                    b.Navigation("Shifts");
                });
#pragma warning restore 612, 618
        }
    }
}
