﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Randomizer.Shared.Models;

#nullable disable

namespace WebRandomizer.Migrations
{
    [DbContext(typeof(RandomizerContext))]
    partial class RandomizerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Randomizer.Shared.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConnectionId")
                        .HasColumnType("text");

                    b.Property<string>("Device")
                        .HasColumnType("text");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("RecievedSeq")
                        .HasColumnType("integer");

                    b.Property<int>("SentSeq")
                        .HasColumnType("integer");

                    b.Property<int>("SessionId")
                        .HasColumnType("integer");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<int>("WorldId")
                        .HasColumnType("integer");

                    b.Property<uint>("xmin")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("xid");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Randomizer.Shared.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("ItemIndex")
                        .HasColumnType("integer");

                    b.Property<int>("PlayerId")
                        .HasColumnType("integer");

                    b.Property<int>("SequenceNum")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Randomizer.Shared.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("ItemWorldId")
                        .HasColumnType("integer");

                    b.Property<int>("LocationId")
                        .HasColumnType("integer");

                    b.Property<int>("WorldId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("WorldId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Randomizer.Shared.Models.Seed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("GameId")
                        .HasColumnType("text");

                    b.Property<string>("GameName")
                        .HasColumnType("text");

                    b.Property<string>("GameVersion")
                        .HasColumnType("text");

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<string>("Hash")
                        .HasColumnType("text");

                    b.Property<string>("Mode")
                        .HasColumnType("text");

                    b.Property<int>("Players")
                        .HasColumnType("integer");

                    b.Property<string>("SeedNumber")
                        .HasColumnType("text");

                    b.Property<string>("Spoiler")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Seeds");
                });

            modelBuilder.Entity("Randomizer.Shared.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<int?>("SeedId")
                        .HasColumnType("integer");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SeedId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("Randomizer.Shared.Models.SessionEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("Confirmed")
                        .HasColumnType("boolean");

                    b.Property<int>("EventType")
                        .HasColumnType("integer");

                    b.Property<int>("FromWorldId")
                        .HasColumnType("integer");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.Property<int>("ItemLocation")
                        .HasColumnType("integer");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<int>("SequenceNum")
                        .HasColumnType("integer");

                    b.Property<int>("SessionId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ToWorldId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.ToTable("SessionEvents");
                });

            modelBuilder.Entity("Randomizer.Shared.Models.World", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Guid")
                        .HasColumnType("text");

                    b.Property<byte[]>("Patch")
                        .HasColumnType("bytea");

                    b.Property<string>("Player")
                        .HasColumnType("text");

                    b.Property<int>("SeedId")
                        .HasColumnType("integer");

                    b.Property<string>("Settings")
                        .HasColumnType("text");

                    b.Property<int>("WorldId")
                        .HasColumnType("integer");

                    b.Property<string>("WorldState")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SeedId");

                    b.ToTable("Worlds");
                });

            modelBuilder.Entity("Randomizer.Shared.Models.Client", b =>
                {
                    b.HasOne("Randomizer.Shared.Models.Session", null)
                        .WithMany("Clients")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Randomizer.Shared.Models.Event", b =>
                {
                    b.HasOne("Randomizer.Shared.Models.Client", null)
                        .WithMany("Events")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Randomizer.Shared.Models.Location", b =>
                {
                    b.HasOne("Randomizer.Shared.Models.World", null)
                        .WithMany("Locations")
                        .HasForeignKey("WorldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Randomizer.Shared.Models.Session", b =>
                {
                    b.HasOne("Randomizer.Shared.Models.Seed", "Seed")
                        .WithMany()
                        .HasForeignKey("SeedId");

                    b.Navigation("Seed");
                });

            modelBuilder.Entity("Randomizer.Shared.Models.SessionEvent", b =>
                {
                    b.HasOne("Randomizer.Shared.Models.Session", null)
                        .WithMany("Events")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Randomizer.Shared.Models.World", b =>
                {
                    b.HasOne("Randomizer.Shared.Models.Seed", null)
                        .WithMany("Worlds")
                        .HasForeignKey("SeedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Randomizer.Shared.Models.Client", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("Randomizer.Shared.Models.Seed", b =>
                {
                    b.Navigation("Worlds");
                });

            modelBuilder.Entity("Randomizer.Shared.Models.Session", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("Randomizer.Shared.Models.World", b =>
                {
                    b.Navigation("Locations");
                });
#pragma warning restore 612, 618
        }
    }
}
