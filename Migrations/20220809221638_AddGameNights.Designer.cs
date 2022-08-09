﻿// <auto-generated />
using System;
using GameNightWithFriends.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GameNightWithFriends.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220809221638_AddGameNights")]
    partial class AddGameNights
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GameNightWithFriends.Models.GameNight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("Host")
                        .HasColumnType("text");

                    b.Property<int>("MaximumPlayers")
                        .HasColumnType("integer");

                    b.Property<int>("MinimumPlayers")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("When")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("GameNights");
                });
#pragma warning restore 612, 618
        }
    }
}
