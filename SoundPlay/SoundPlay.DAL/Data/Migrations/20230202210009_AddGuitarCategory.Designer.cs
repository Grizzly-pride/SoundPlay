﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoundPlay.DAL.Data;

#nullable disable

namespace SoundPlay.DAL.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230202210009_AddGuitarCategory")]
    partial class AddGuitarCategory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SoundPlay.DAL.Models.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("SoundPlay.DAL.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("SoundPlay.DAL.Models.Guitar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int")
                        .HasColumnName("brand_id");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("ColorId")
                        .HasColumnType("int")
                        .HasColumnName("color_id");

                    b.Property<DateTime>("DateDelivery")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("date_delivery");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnName("description");

                    b.Property<int>("FretboardId")
                        .HasColumnType("int")
                        .HasColumnName("fretboard_id");

                    b.Property<byte>("FretsCount")
                        .HasColumnType("tinyint")
                        .HasColumnName("frets_count");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnName("name");

                    b.Property<int>("NeckId")
                        .HasColumnType("int")
                        .HasColumnName("neck_id");

                    b.Property<int?>("PickupSetId")
                        .HasColumnType("int")
                        .HasColumnName("pickup_set_id");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnName("picture_url");

                    b.Property<decimal>("Price")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal")
                        .HasColumnName("price");

                    b.Property<int?>("ShapeId")
                        .HasColumnType("int")
                        .HasColumnName("shape_id");

                    b.Property<int>("SoundboardId")
                        .HasColumnType("int")
                        .HasColumnName("soundboard_id");

                    b.Property<byte>("StringsCount")
                        .HasColumnType("tinyint")
                        .HasColumnName("strings_count");

                    b.Property<int?>("TremoloTypeId")
                        .HasColumnType("int")
                        .HasColumnName("tremolo_id");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ColorId");

                    b.HasIndex("FretboardId");

                    b.HasIndex("NeckId");

                    b.HasIndex("PickupSetId");

                    b.HasIndex("ShapeId");

                    b.HasIndex("SoundboardId");

                    b.HasIndex("TremoloTypeId");

                    b.ToTable("Guitars");
                });

            modelBuilder.Entity("SoundPlay.DAL.Models.GuitarCategory", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("GuitarCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electric Guitar"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Accoustic Guitar"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Classic Guitar"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Electric Bass"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Accoustic Bass"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Ukulele"
                        });
                });

            modelBuilder.Entity("SoundPlay.DAL.Models.GuitarShape", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("GuitarShapes");
                });

            modelBuilder.Entity("SoundPlay.DAL.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("SoundPlay.DAL.Models.PickupSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("PickupSets");
                });

            modelBuilder.Entity("SoundPlay.DAL.Models.TremoloType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("TremoloTypes");
                });

            modelBuilder.Entity("SoundPlay.DAL.Models.Guitar", b =>
                {
                    b.HasOne("SoundPlay.DAL.Models.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SoundPlay.DAL.Models.GuitarCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SoundPlay.DAL.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SoundPlay.DAL.Models.Material", "Fretboard")
                        .WithMany()
                        .HasForeignKey("FretboardId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SoundPlay.DAL.Models.Material", "Neck")
                        .WithMany()
                        .HasForeignKey("NeckId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SoundPlay.DAL.Models.PickupSet", "PickupSet")
                        .WithMany()
                        .HasForeignKey("PickupSetId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SoundPlay.DAL.Models.GuitarShape", "Shape")
                        .WithMany()
                        .HasForeignKey("ShapeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("SoundPlay.DAL.Models.Material", "Soundboard")
                        .WithMany()
                        .HasForeignKey("SoundboardId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SoundPlay.DAL.Models.TremoloType", "TremoloType")
                        .WithMany()
                        .HasForeignKey("TremoloTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Brand");

                    b.Navigation("Category");

                    b.Navigation("Color");

                    b.Navigation("Fretboard");

                    b.Navigation("Neck");

                    b.Navigation("PickupSet");

                    b.Navigation("Shape");

                    b.Navigation("Soundboard");

                    b.Navigation("TremoloType");
                });
#pragma warning restore 612, 618
        }
    }
}
