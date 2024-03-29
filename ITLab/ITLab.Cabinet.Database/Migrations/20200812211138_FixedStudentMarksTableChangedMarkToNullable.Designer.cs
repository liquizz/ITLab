﻿// <auto-generated />
using System;
using ITLab.Cabinet.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ITLab.Cabinet.Database.Migrations
{
    [DbContext(typeof(CabinetContext))]
    [Migration("20200812211138_FixedStudentMarksTableChangedMarkToNullable")]
    partial class FixedStudentMarksTableChangedMarkToNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HeadPhotoPhotoId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.HasIndex("HeadPhotoPhotoId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.HomeTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuizId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.HasIndex("QuizId");

                    b.ToTable("HomeTasks");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.Lesson", b =>
                {
                    b.Property<int>("LessonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LessonDateFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LessonDateTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LessonId");

                    b.HasIndex("CourseId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.Photo", b =>
                {
                    b.Property<int>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("PhotoId");

                    b.HasIndex("CourseId");

                    b.HasIndex("LessonId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.Presentations", b =>
                {
                    b.Property<int>("PresentationsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PresentationLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("PresentationsId");

                    b.HasIndex("LessonId");

                    b.ToTable("Presentations");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.Quiz", b =>
                {
                    b.Property<int>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuizLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuizId");

                    b.ToTable("Quizzes");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.StudentMarks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HomeTaskId")
                        .HasColumnType("int");

                    b.Property<int?>("Mark")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HomeTaskId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentMarks");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.StudentsCourses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentsCourses");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.Video", b =>
                {
                    b.Property<int>("VideoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("VideoLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VideoId");

                    b.HasIndex("LessonId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.Course", b =>
                {
                    b.HasOne("ITLab.Cabinet.Database.Models.Photo", "HeadPhoto")
                        .WithMany()
                        .HasForeignKey("HeadPhotoPhotoId");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.HomeTask", b =>
                {
                    b.HasOne("ITLab.Cabinet.Database.Models.Lesson", null)
                        .WithMany("Tasks")
                        .HasForeignKey("LessonId");

                    b.HasOne("ITLab.Cabinet.Database.Models.Quiz", "Quiz")
                        .WithMany()
                        .HasForeignKey("QuizId");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.Lesson", b =>
                {
                    b.HasOne("ITLab.Cabinet.Database.Models.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.Photo", b =>
                {
                    b.HasOne("ITLab.Cabinet.Database.Models.Course", null)
                        .WithMany("Photos")
                        .HasForeignKey("CourseId");

                    b.HasOne("ITLab.Cabinet.Database.Models.Lesson", null)
                        .WithMany("Photos")
                        .HasForeignKey("LessonId");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.Presentations", b =>
                {
                    b.HasOne("ITLab.Cabinet.Database.Models.Lesson", null)
                        .WithMany("Presentations")
                        .HasForeignKey("LessonId");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.StudentMarks", b =>
                {
                    b.HasOne("ITLab.Cabinet.Database.Models.HomeTask", "HomeTask")
                        .WithMany()
                        .HasForeignKey("HomeTaskId");

                    b.HasOne("ITLab.Cabinet.Database.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.StudentsCourses", b =>
                {
                    b.HasOne("ITLab.Cabinet.Database.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("ITLab.Cabinet.Database.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("ITLab.Cabinet.Database.Models.Video", b =>
                {
                    b.HasOne("ITLab.Cabinet.Database.Models.Lesson", null)
                        .WithMany("Videos")
                        .HasForeignKey("LessonId");
                });
#pragma warning restore 612, 618
        }
    }
}
