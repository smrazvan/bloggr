﻿// <auto-generated />
using System;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bloggr.Infrastructure.Migrations
{
    [DbContext(typeof(BloggrContext))]
    partial class BloggrContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bloggr.Domain.Entities.Interest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByUsername")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUsername");

                    b.ToTable("Interest");
                });

            modelBuilder.Entity("Domain.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedByUsername")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUsername");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Domain.Entities.Like", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedByUsername")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("PostId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUsername");

                    b.HasIndex("PostId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("Domain.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedByUsername")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedByUsername");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedByUsername")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.HasIndex("CreatedByUsername");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Bloggr.Domain.Entities.Interest", b =>
                {
                    b.HasOne("Domain.Entities.User", "CreatedBy")
                        .WithMany("Interests")
                        .HasForeignKey("CreatedByUsername");

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("Domain.Entities.Comment", b =>
                {
                    b.HasOne("Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUsername");

                    b.HasOne("Domain.Entities.Post", null)
                        .WithMany("Comments")
                        .HasForeignKey("PostId");

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("Domain.Entities.Like", b =>
                {
                    b.HasOne("Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUsername");

                    b.HasOne("Domain.Entities.Post", null)
                        .WithMany("Likes")
                        .HasForeignKey("PostId");

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("Domain.Entities.Post", b =>
                {
                    b.HasOne("Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUsername");

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedByUsername");

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("Domain.Entities.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Navigation("Interests");
                });
#pragma warning restore 612, 618
        }
    }
}
