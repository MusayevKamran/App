﻿// <auto-generated />
using System;
using App.Persistance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190321092049_Initi")]
    partial class Initi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("App.Domain.Entities.Article", b =>
                {
                    b.Property<int>("ArticleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("Image");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Like");

                    b.Property<int>("PostCategory");

                    b.Property<int>("Row");

                    b.Property<string>("Title");

                    b.Property<string>("URL");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<Guid?>("UserId");

                    b.HasKey("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("App.Domain.Entities.ArticleCategory", b =>
                {
                    b.Property<int>("ArticleId");

                    b.Property<int>("CategoryId");

                    b.HasKey("ArticleId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("ArticleCategories");
                });

            modelBuilder.Entity("App.Domain.Entities.ArticleImages", b =>
                {
                    b.Property<int>("ArticleId");

                    b.Property<int>("ImageId");

                    b.HasKey("ArticleId", "ImageId");

                    b.HasIndex("ImageId")
                        .IsUnique();

                    b.ToTable("ArticleImages");
                });

            modelBuilder.Entity("App.Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CategoryID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsNew");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<int>("Row")
                        .HasColumnType("Row");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("App.Domain.Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArticleId");

                    b.Property<string>("Content");

                    b.Property<int>("Count");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<Guid?>("UserId");

                    b.HasKey("CommentId");

                    b.HasIndex("ArticleId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("App.Domain.Entities.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageLink");

                    b.HasKey("ImageId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("App.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("About");

                    b.Property<string>("Education");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<int>("Follower");

                    b.Property<string>("Image");

                    b.Property<string>("Job");

                    b.Property<int>("Like");

                    b.Property<string>("Quote");

                    b.Property<string>("SecondName");

                    b.Property<string>("URL");

                    b.Property<int>("View");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("App.Domain.Entities.Article", b =>
                {
                    b.HasOne("App.Domain.Entities.User", "User")
                        .WithMany("Article")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_User_Articles");
                });

            modelBuilder.Entity("App.Domain.Entities.ArticleCategory", b =>
                {
                    b.HasOne("App.Domain.Entities.Article", "Article")
                        .WithMany("ArticleCategory")
                        .HasForeignKey("ArticleId")
                        .HasConstraintName("FK_Article_Categories")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Domain.Entities.Category", "Category")
                        .WithMany("ArticleCategory")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK_Category_Articles")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Domain.Entities.ArticleImages", b =>
                {
                    b.HasOne("App.Domain.Entities.Article", "Article")
                        .WithMany("Images")
                        .HasForeignKey("ArticleId")
                        .HasConstraintName("FK_Article_Images")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("App.Domain.Entities.Image", "Image")
                        .WithOne("ArticleImages")
                        .HasForeignKey("App.Domain.Entities.ArticleImages", "ImageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("App.Domain.Entities.Comment", b =>
                {
                    b.HasOne("App.Domain.Entities.Article", "Article")
                        .WithMany("Comment")
                        .HasForeignKey("ArticleId")
                        .HasConstraintName("FK_Article_Comments");

                    b.HasOne("App.Domain.Entities.User", "User")
                        .WithMany("Comment")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_User_Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
