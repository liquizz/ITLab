﻿// <auto-generated />
using System;
using ITLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ITLab.Landing.MVC.Migrations
{
    [DbContext(typeof(ITLabContext))]
    [Migration("20200622202842_remove_error_with_short_news-virtualtable")]
    partial class remove_error_with_short_newsvirtualtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ITLab.Models.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CommentatorId")
                        .HasColumnType("int");

                    b.Property<int?>("NewsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeDate")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("CommentatorId");

                    b.HasIndex("NewsId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ITLab.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FeedbackStatus")
                        .HasColumnType("int")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FeedbackStatus");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("ITLab.Models.FeedbackStatuses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Statuses")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("FeedbackStatuses");
                });

            modelBuilder.Entity("ITLab.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HeadPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("ITLab.Models.Photos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NewsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NewsId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("ITLab.Models.Subscriptions", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Email");

                    b.ToTable("Subscriptions");
                });

            modelBuilder.Entity("ITLab.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ITLab.Models.Videos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NewsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NewsId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("ITLab.Models.Comments", b =>
                {
                    b.HasOne("ITLab.Models.Users", "Commentator")
                        .WithMany("Comments")
                        .HasForeignKey("CommentatorId")
                        .HasConstraintName("FK__Comments__Commen__49C3F6B7");

                    b.HasOne("ITLab.Models.News", "News")
                        .WithMany("Comments")
                        .HasForeignKey("NewsId")
                        .HasConstraintName("FK__Comments__NewsId__4AB81AF0");
                });

            modelBuilder.Entity("ITLab.Models.Feedback", b =>
                {
                    b.HasOne("ITLab.Models.FeedbackStatuses", "FeedbackStatusNavigation")
                        .WithMany("Feedback")
                        .HasForeignKey("FeedbackStatus")
                        .HasConstraintName("FK__Feedback__Feedba__4316F928");
                });

            modelBuilder.Entity("ITLab.Models.Photos", b =>
                {
                    b.HasOne("ITLab.Models.News", "News")
                        .WithMany("Photos")
                        .HasForeignKey("NewsId")
                        .HasConstraintName("FK__Photos__NewsId__398D8EEE");
                });

            modelBuilder.Entity("ITLab.Models.Videos", b =>
                {
                    b.HasOne("ITLab.Models.News", "News")
                        .WithMany("Videos")
                        .HasForeignKey("NewsId")
                        .HasConstraintName("FK__Videos__NewsId__3D5E1FD2");
                });
#pragma warning restore 612, 618
        }
    }
}
