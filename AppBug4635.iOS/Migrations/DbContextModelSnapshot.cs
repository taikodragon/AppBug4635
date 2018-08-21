﻿// <auto-generated />
using AppBug4635;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AppBug4635.Migrations
{
    [DbContext(typeof(DbContext))]
    partial class DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("AppBug59184.Model.BuggedLargerNullableEntity", b =>
                {
                    b.Property<Guid>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NotNullable1");

                    b.Property<DateTime>("NotNullable2");

                    b.Property<DateTime>("NotNullable3");

                    b.Property<DateTime>("NotNullable4");

                    b.Property<int?>("Nullable1");

                    b.Property<Guid?>("Nullable2");

                    b.Property<Guid?>("Nullable3");

                    b.Property<Guid?>("Nullable4");

                    b.Property<string>("Nullable5");

                    b.Property<DateTime?>("Nullable6");

                    b.Property<DateTime?>("Nullable7");

                    b.HasKey("Key");

                    b.ToTable("BuggedLargerNullableEntities");
                });

            modelBuilder.Entity("AppBug59184.Model.BuggedNotNullbaleEntity", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("NotNullable1");

                    b.Property<bool>("NotNullable10");

                    b.Property<bool>("NotNullable11");

                    b.Property<bool>("NotNullable12");

                    b.Property<bool>("NotNullable13");

                    b.Property<bool>("NotNullable14");

                    b.Property<bool>("NotNullable2");

                    b.Property<bool>("NotNullable3");

                    b.Property<bool>("NotNullable4");

                    b.Property<bool>("NotNullable5");

                    b.Property<bool>("NotNullable6");

                    b.Property<bool>("NotNullable7");

                    b.Property<bool>("NotNullable8");

                    b.Property<bool>("NotNullable9");

                    b.HasKey("Key");

                    b.ToTable("BuggedNotNullableEntities");
                });

            modelBuilder.Entity("AppBug59184.Model.BuggedNullableEntity", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("Nullable1");

                    b.Property<long?>("Nullable2");

                    b.Property<long?>("Nullable3");

                    b.Property<long?>("Nullable4");

                    b.HasKey("Key");

                    b.ToTable("BuggedNullableEntities");
                });

            modelBuilder.Entity("AppBug59184.Model.OkNotNullableEntity", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("NotNullable1");

                    b.Property<bool>("NotNullable10");

                    b.Property<bool>("NotNullable11");

                    b.Property<bool>("NotNullable12");

                    b.Property<bool>("NotNullable13");

                    b.Property<bool>("NotNullable2");

                    b.Property<bool>("NotNullable3");

                    b.Property<bool>("NotNullable4");

                    b.Property<bool>("NotNullable5");

                    b.Property<bool>("NotNullable6");

                    b.Property<bool>("NotNullable7");

                    b.Property<bool>("NotNullable8");

                    b.Property<bool>("NotNullable9");

                    b.HasKey("Key");

                    b.ToTable("OkNotNullableEntities");
                });

            modelBuilder.Entity("AppBug59184.Model.OkNullableEntity", b =>
                {
                    b.Property<int>("Key")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("Nullable1");

                    b.Property<long?>("Nullable2");

                    b.Property<long?>("Nullable3");

                    b.HasKey("Key");

                    b.ToTable("OkNullableEntities");
                });
#pragma warning restore 612, 618
        }
    }
}