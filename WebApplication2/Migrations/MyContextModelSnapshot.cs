﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication2.Data;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.Property<int>("Trajanje");

                    b.HasKey("FilmId");

                    b.ToTable("Film");
                });

            modelBuilder.Entity("WebApplication2.Models.FilmZanr", b =>
                {
                    b.Property<int>("FilmId");

                    b.Property<int>("ZanrId");

                    b.HasKey("FilmId", "ZanrId");

                    b.HasIndex("ZanrId");

                    b.ToTable("FilmZanr");
                });

            modelBuilder.Entity("WebApplication2.Models.Zanr", b =>
                {
                    b.Property<int>("ZanrId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("ZanrId");

                    b.ToTable("Zanr");
                });

            modelBuilder.Entity("WebApplication2.Models.FilmZanr", b =>
                {
                    b.HasOne("WebApplication2.Models.Film", "Film")
                        .WithMany("Zanrovi")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication2.Models.Zanr", "Zanr")
                        .WithMany("Filmovi")
                        .HasForeignKey("ZanrId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
