﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using leaderboardAPI.Models;

namespace leaderboardAPI.Migrations
{
    [DbContext(typeof(PlayerContext))]
    [Migration("20190613230004_intialDatabase")]
    partial class intialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("leaderboardAPI.Models.Player", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("name");

                    b.Property<string>("recordDate");

                    b.Property<int>("score");

                    b.HasKey("id");

                    b.ToTable("players");
                });
#pragma warning restore 612, 618
        }
    }
}
