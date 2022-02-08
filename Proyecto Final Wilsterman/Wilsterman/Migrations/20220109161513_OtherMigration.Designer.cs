﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wilsterman.Data;

namespace Wilsterman.Migrations
{
    [DbContext(typeof(WilstermanDBContext))]
    [Migration("20220109161513_OtherMigration")]
    partial class OtherMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Wilsterman.Data.Entities.GameEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AwayGoals")
                        .HasColumnType("int");

                    b.Property<string>("AwayTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AwayTeamPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DayWeek")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocalGoals")
                        .HasColumnType("int");

                    b.Property<string>("LocalTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalTeamPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MatchDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("MatchdayTournament")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Minutes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherSituation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeasonTournament")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stadium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StageTournament")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tournament")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("Wilsterman.Data.Entities.PlayerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentTeamPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenerealPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Shirt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Wilsterman.Data.Entities.TransferRumorEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Currency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("TargetTeam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TargetTeamPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transfer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransferVariables")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("TransferRumors");
                });

            modelBuilder.Entity("Wilsterman.Data.Entities.TransferRumorEntity", b =>
                {
                    b.HasOne("Wilsterman.Data.Entities.PlayerEntity", "Player")
                        .WithMany("Rumors")
                        .HasForeignKey("PlayerId");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Wilsterman.Data.Entities.PlayerEntity", b =>
                {
                    b.Navigation("Rumors");
                });
#pragma warning restore 612, 618
        }
    }
}
