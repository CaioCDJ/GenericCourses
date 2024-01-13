﻿// <auto-generated />
using System;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GenericCourses.Infra.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240113000946_UsersUpdate")]
    partial class UsersUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CourseProgress", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("courseId")
                        .HasColumnType("uuid");

                    b.Property<bool>("done")
                        .HasColumnType("boolean");

                    b.Property<Guid>("userId")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("courseId");

                    b.HasIndex("userId");

                    b.ToTable("CourseProgresses");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("Courseid")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("Postid")
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("Courseid");

                    b.HasIndex("Postid");

                    b.ToTable("categories");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Certificate", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("courseId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("emited_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.ToTable("certificates");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Course", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("active")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("duration")
                        .HasColumnType("text");

                    b.Property<string>("instrutor")
                        .HasColumnType("text");

                    b.Property<bool>("isFree")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("lastupdate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("thumb")
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Module", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<bool>("complete")
                        .HasColumnType("boolean");

                    b.Property<Guid>("courseId")
                        .HasColumnType("uuid");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<int>("order")
                        .HasColumnType("integer");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("modules");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Post", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("acesses")
                        .HasColumnType("integer");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("text")
                        .HasColumnType("text");

                    b.Property<string>("thumb")
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<string>("userId")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("posts");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Subscriptionplan", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("months")
                        .HasColumnType("integer");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("subscriptionplans");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("cpf")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("github")
                        .HasColumnType("text");

                    b.Property<bool>("is_active")
                        .HasColumnType("boolean");

                    b.Property<int?>("phoneNumber")
                        .HasColumnType("integer");

                    b.Property<int>("role")
                        .HasColumnType("integer");

                    b.Property<string>("socialNetwork")
                        .HasColumnType("text");

                    b.Property<Guid>("subscriptionplanId")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("subscriptionplanId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Video", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("duration")
                        .HasColumnType("text");

                    b.Property<Guid>("moduleId")
                        .HasColumnType("uuid");

                    b.Property<int>("order")
                        .HasColumnType("integer");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<string>("videoUrl")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("moduleId");

                    b.ToTable("videos");
                });

            modelBuilder.Entity("GenericCourses.Infra.Persistence.LoginUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<Guid>("id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("userid")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("userid");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ModuleProgress", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("courseProgressId")
                        .HasColumnType("uuid");

                    b.Property<bool>("done")
                        .HasColumnType("boolean");

                    b.Property<Guid>("moduleId")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("courseProgressId");

                    b.HasIndex("moduleId");

                    b.ToTable("moduleProgresses");
                });

            modelBuilder.Entity("VideoProgress", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("moduleId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("videoId")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("moduleId");

                    b.HasIndex("videoId");

                    b.ToTable("VideoProgresses");
                });

            modelBuilder.Entity("CourseProgress", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GenericCourses.Domain.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("user");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Category", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Course", null)
                        .WithMany("categories")
                        .HasForeignKey("Courseid");

                    b.HasOne("GenericCourses.Domain.Entities.Post", null)
                        .WithMany("categories")
                        .HasForeignKey("Postid");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.User", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Subscriptionplan", "subscriptionplan")
                        .WithMany("users")
                        .HasForeignKey("subscriptionplanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("subscriptionplan");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Video", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Module", null)
                        .WithMany("videos")
                        .HasForeignKey("moduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenericCourses.Infra.Persistence.LoginUser", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GenericCourses.Infra.Persistence.LoginUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GenericCourses.Infra.Persistence.LoginUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GenericCourses.Infra.Persistence.LoginUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GenericCourses.Infra.Persistence.LoginUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ModuleProgress", b =>
                {
                    b.HasOne("CourseProgress", "courseProgress")
                        .WithMany()
                        .HasForeignKey("courseProgressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GenericCourses.Domain.Entities.Module", "module")
                        .WithMany()
                        .HasForeignKey("moduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("courseProgress");

                    b.Navigation("module");
                });

            modelBuilder.Entity("VideoProgress", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Module", "module")
                        .WithMany()
                        .HasForeignKey("moduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GenericCourses.Domain.Entities.Video", "video")
                        .WithMany()
                        .HasForeignKey("videoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("module");

                    b.Navigation("video");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Course", b =>
                {
                    b.Navigation("categories");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Module", b =>
                {
                    b.Navigation("videos");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Post", b =>
                {
                    b.Navigation("categories");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Subscriptionplan", b =>
                {
                    b.Navigation("users");
                });
#pragma warning restore 612, 618
        }
    }
}