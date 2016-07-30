﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using OfferingSolutions.UoWCore.SampleApp;

namespace OfferingSolutions.UoWCore.SampleApp.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OfferingSolutions.UoWCore.SampleApp.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("OfferingSolutions.UoWCore.SampleApp.Models.Thing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("PersonId");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Things");
                });

            modelBuilder.Entity("OfferingSolutions.UoWCore.SampleApp.Models.Thing", b =>
                {
                    b.HasOne("OfferingSolutions.UoWCore.SampleApp.Models.Person")
                        .WithMany("Things")
                        .HasForeignKey("PersonId");
                });
        }
    }
}
