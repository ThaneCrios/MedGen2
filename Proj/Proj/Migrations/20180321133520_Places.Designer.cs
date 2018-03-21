﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Proj.Models;
using System;

namespace Proj.Migrations
{
    [DbContext(typeof(MedGenContext))]
    [Migration("20180321133520_Places")]
    partial class Places
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proj.Models.LivePlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CityName");

                    b.Property<string>("CityType");

                    b.Property<string>("District");

                    b.Property<int>("Population");

                    b.Property<int>("PopulationChildren");

                    b.Property<string>("Republic");

                    b.HasKey("Id");

                    b.ToTable("LivePlaces");
                });

            modelBuilder.Entity("Proj.Models.Man", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BirthPlace");

                    b.Property<string>("CityAdress");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Fio");

                    b.Property<string>("Nationality");

                    b.Property<string>("Sex");

                    b.Property<string>("StreetAdress");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Proj.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardCode");

                    b.Property<int>("ManId");

                    b.Property<string>("Notes");

                    b.Property<string>("OurNotOur");

                    b.Property<string>("TypeOfInheritance");

                    b.Property<string>("diagnosis");

                    b.Property<int>("disability");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
