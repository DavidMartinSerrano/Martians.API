﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Robot.Infrastructure.Data;

namespace Martians.API.Migrations
{
    [DbContext(typeof(RobotContext))]
    [Migration("20220129212617_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Robot.Core.Entities.CoordinatesEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("X")
                        .HasColumnType("int");

                    b.Property<int>("Y")
                        .HasColumnType("int");

                    b.Property<int>("Z")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Coordinates");
                });

            modelBuilder.Entity("Robot.Core.Entities.RobotEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CoordinatesId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Orientation")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoordinatesId");

                    b.ToTable("Robots");
                });

            modelBuilder.Entity("Robot.Core.Entities.TroubleEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RobotEntityId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RobotEntityId");

                    b.ToTable("Troubles");
                });

            modelBuilder.Entity("Robot.Core.Entities.RobotEntity", b =>
                {
                    b.HasOne("Robot.Core.Entities.CoordinatesEntity", "Coordinates")
                        .WithMany()
                        .HasForeignKey("CoordinatesId");

                    b.Navigation("Coordinates");
                });

            modelBuilder.Entity("Robot.Core.Entities.TroubleEntity", b =>
                {
                    b.HasOne("Robot.Core.Entities.RobotEntity", null)
                        .WithMany("Troubles")
                        .HasForeignKey("RobotEntityId");
                });

            modelBuilder.Entity("Robot.Core.Entities.RobotEntity", b =>
                {
                    b.Navigation("Troubles");
                });
#pragma warning restore 612, 618
        }
    }
}