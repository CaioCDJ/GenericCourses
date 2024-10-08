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
    [Migration("20240530225905_commentsAndReview")]
    partial class commentsAndReview
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CourseProgress", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("courseId")
                        .HasColumnType("uuid")
                        .HasColumnName("course_id");

                    b.Property<bool>("done")
                        .HasColumnType("boolean")
                        .HasColumnName("done");

                    b.Property<Guid>("userId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("id")
                        .HasName("pk_course_progresses");

                    b.HasIndex("courseId")
                        .HasDatabaseName("ix_course_progresses_course_id");

                    b.HasIndex("userId")
                        .HasDatabaseName("ix_course_progresses_user_id");

                    b.ToTable("course_progresses", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Admin", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("userId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("id")
                        .HasName("pk_admins");

                    b.HasIndex("userId")
                        .HasDatabaseName("ix_admins_user_id");

                    b.ToTable("admins", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.BlogPost", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("acesses")
                        .HasColumnType("integer")
                        .HasColumnName("acesses");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("Date")
                        .HasColumnName("created_at");

                    b.Property<Guid>("instructorId")
                        .HasColumnType("uuid")
                        .HasColumnName("instructor_id");

                    b.Property<string>("text")
                        .HasColumnType("text")
                        .HasColumnName("text");

                    b.Property<string>("thumb")
                        .HasColumnType("text")
                        .HasColumnName("thumb");

                    b.Property<string>("title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("id")
                        .HasName("pk_blog_posts");

                    b.HasIndex("instructorId")
                        .HasDatabaseName("ix_blog_posts_instructor_id");

                    b.ToTable("blog_posts", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("blogPostId")
                        .HasColumnType("uuid")
                        .HasColumnName("blog_post_id");

                    b.Property<Guid?>("courseId")
                        .HasColumnType("uuid")
                        .HasColumnName("course_id");

                    b.Property<string>("name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("id")
                        .HasName("pk_categories");

                    b.HasIndex("blogPostId")
                        .HasDatabaseName("ix_categories_blog_post_id");

                    b.HasIndex("courseId")
                        .HasDatabaseName("ix_categories_course_id");

                    b.ToTable("categories", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Certificate", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("courseId")
                        .HasColumnType("uuid")
                        .HasColumnName("course_id");

                    b.Property<DateTime>("emited_at")
                        .HasColumnType("Date")
                        .HasColumnName("emited_at");

                    b.Property<Guid>("userId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("id")
                        .HasName("pk_certificates");

                    b.HasIndex("courseId")
                        .HasDatabaseName("ix_certificates_course_id");

                    b.HasIndex("userId")
                        .HasDatabaseName("ix_certificates_user_id");

                    b.ToTable("certificates", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Client", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("subscriptionplanId")
                        .HasColumnType("uuid")
                        .HasColumnName("subscriptionplan_id");

                    b.Property<Guid>("userId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("id")
                        .HasName("pk_clients");

                    b.HasIndex("subscriptionplanId")
                        .HasDatabaseName("ix_clients_subscriptionplan_id");

                    b.HasIndex("userId")
                        .HasDatabaseName("ix_clients_user_id");

                    b.ToTable("clients", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Comment", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("blogPostId")
                        .HasColumnType("uuid")
                        .HasColumnName("blog_post_id");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("Date")
                        .HasColumnName("created_at");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("text");

                    b.HasKey("id")
                        .HasName("pk_comments");

                    b.HasIndex("blogPostId")
                        .HasDatabaseName("ix_comments_blog_post_id");

                    b.ToTable("comments", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Course", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("active")
                        .HasColumnType("boolean")
                        .HasColumnName("active");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("Date")
                        .HasColumnName("created_at");

                    b.Property<string>("description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("duration")
                        .HasColumnType("text")
                        .HasColumnName("duration");

                    b.Property<Guid>("instructorId")
                        .HasColumnType("uuid")
                        .HasColumnName("instructor_id");

                    b.Property<bool>("is_free")
                        .HasColumnType("boolean")
                        .HasColumnName("is_free");

                    b.Property<DateTime>("lastupdate")
                        .HasColumnType("Date")
                        .HasColumnName("lastupdate");

                    b.Property<string>("thumb")
                        .HasColumnType("text")
                        .HasColumnName("thumb");

                    b.Property<string>("title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("id")
                        .HasName("pk_courses");

                    b.HasIndex("instructorId")
                        .HasDatabaseName("ix_courses_instructor_id");

                    b.ToTable("courses", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Instructor", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("github")
                        .HasColumnType("text")
                        .HasColumnName("github");

                    b.Property<string>("social_network")
                        .HasColumnType("text")
                        .HasColumnName("social_network");

                    b.Property<Guid>("userId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("id")
                        .HasName("pk_instructors");

                    b.HasIndex("userId")
                        .HasDatabaseName("ix_instructors_user_id");

                    b.ToTable("instructors", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Module", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("Courseid")
                        .HasColumnType("uuid")
                        .HasColumnName("courseid");

                    b.Property<bool>("complete")
                        .HasColumnType("boolean")
                        .HasColumnName("complete");

                    b.Property<string>("description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("order")
                        .HasColumnType("integer")
                        .HasColumnName("order");

                    b.Property<string>("title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("id")
                        .HasName("pk_modules");

                    b.HasIndex("Courseid")
                        .HasDatabaseName("ix_modules_courseid");

                    b.ToTable("modules", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Review", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("clientId")
                        .HasColumnType("uuid")
                        .HasColumnName("client_id");

                    b.Property<Guid>("courseId")
                        .HasColumnType("uuid")
                        .HasColumnName("course_id");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("Date")
                        .HasColumnName("created_at");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("text");

                    b.HasKey("id")
                        .HasName("pk_reviews");

                    b.HasIndex("clientId")
                        .HasDatabaseName("ix_reviews_client_id");

                    b.HasIndex("courseId")
                        .HasDatabaseName("ix_reviews_course_id");

                    b.ToTable("reviews", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Subscriptionplan", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("Date")
                        .HasColumnName("created_at");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("months")
                        .HasColumnType("integer")
                        .HasColumnName("months");

                    b.Property<float>("price")
                        .HasColumnType("real")
                        .HasColumnName("price");

                    b.HasKey("id")
                        .HasName("pk_subscription_plans");

                    b.ToTable("subscription_plans", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("cpf")
                        .HasColumnType("integer")
                        .HasColumnName("cpf");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("Date")
                        .HasColumnName("created_at");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<bool>("is_active")
                        .HasColumnType("boolean")
                        .HasColumnName("is_active");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password");

                    b.Property<int?>("phone")
                        .HasColumnType("integer")
                        .HasColumnName("phone");

                    b.HasKey("id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Video", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("Date")
                        .HasColumnName("created_at");

                    b.Property<string>("description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("duration")
                        .HasColumnType("text")
                        .HasColumnName("duration");

                    b.Property<Guid>("moduleId")
                        .HasColumnType("uuid")
                        .HasColumnName("module_id");

                    b.Property<int>("order")
                        .HasColumnType("integer")
                        .HasColumnName("order");

                    b.Property<string>("title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<string>("videoUrl")
                        .HasColumnType("text")
                        .HasColumnName("video_url");

                    b.HasKey("id")
                        .HasName("pk_videos");

                    b.HasIndex("moduleId")
                        .HasDatabaseName("ix_videos_module_id");

                    b.ToTable("videos", (string)null);
                });

            modelBuilder.Entity("ModuleProgress", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("courseProgressId")
                        .HasColumnType("uuid")
                        .HasColumnName("course_progress_id");

                    b.Property<bool>("done")
                        .HasColumnType("boolean")
                        .HasColumnName("done");

                    b.Property<Guid>("moduleId")
                        .HasColumnType("uuid")
                        .HasColumnName("module_id");

                    b.HasKey("id")
                        .HasName("pk_modules_progress");

                    b.HasIndex("courseProgressId")
                        .HasDatabaseName("ix_modules_progress_course_progress_id");

                    b.HasIndex("moduleId")
                        .HasDatabaseName("ix_modules_progress_module_id");

                    b.ToTable("modules_progress", (string)null);
                });

            modelBuilder.Entity("VideoProgress", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<bool>("done")
                        .HasColumnType("boolean")
                        .HasColumnName("done");

                    b.Property<Guid>("moduleId")
                        .HasColumnType("uuid")
                        .HasColumnName("module_id");

                    b.Property<Guid>("videoId")
                        .HasColumnType("uuid")
                        .HasColumnName("video_id");

                    b.HasKey("id")
                        .HasName("pk_video_progresses");

                    b.HasIndex("moduleId")
                        .HasDatabaseName("ix_video_progresses_module_id");

                    b.HasIndex("videoId")
                        .HasDatabaseName("ix_video_progresses_video_id");

                    b.ToTable("video_progresses", (string)null);
                });

            modelBuilder.Entity("CourseProgress", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_course_progresses_courses_course_id");

                    b.HasOne("GenericCourses.Domain.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_course_progresses_users_user_id");

                    b.Navigation("Course");

                    b.Navigation("user");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Admin", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_admins_users_user_id");

                    b.Navigation("user");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.BlogPost", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Instructor", "instructor")
                        .WithMany("posts")
                        .HasForeignKey("instructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_blog_posts_instructors_instructor_id");

                    b.Navigation("instructor");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Category", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.BlogPost", "blogPost")
                        .WithMany("category")
                        .HasForeignKey("blogPostId")
                        .HasConstraintName("fk_categories_blog_posts_blog_post_id");

                    b.HasOne("GenericCourses.Domain.Entities.Course", "course")
                        .WithMany("categories")
                        .HasForeignKey("courseId")
                        .HasConstraintName("fk_categories_courses_course_id");

                    b.Navigation("blogPost");

                    b.Navigation("course");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Certificate", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Course", "course")
                        .WithMany()
                        .HasForeignKey("courseId")
                        .HasConstraintName("fk_certificates_courses_course_id");

                    b.HasOne("GenericCourses.Domain.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_certificates_users_user_id");

                    b.Navigation("course");

                    b.Navigation("user");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Client", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Subscriptionplan", "subscriptionplan")
                        .WithMany("clients")
                        .HasForeignKey("subscriptionplanId")
                        .HasConstraintName("fk_clients_subscription_plans_subscriptionplan_id");

                    b.HasOne("GenericCourses.Domain.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_clients_users_user_id");

                    b.Navigation("subscriptionplan");

                    b.Navigation("user");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Comment", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.BlogPost", "blogPost")
                        .WithMany("comments")
                        .HasForeignKey("blogPostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_comments_blog_posts_blog_post_id");

                    b.Navigation("blogPost");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Course", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Instructor", "instructor")
                        .WithMany()
                        .HasForeignKey("instructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_courses_instructors_instructor_id");

                    b.Navigation("instructor");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Instructor", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_instructors_users_user_id");

                    b.Navigation("user");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Module", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Course", null)
                        .WithMany("modules")
                        .HasForeignKey("Courseid")
                        .HasConstraintName("fk_modules_courses_courseid");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Review", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Client", "client")
                        .WithMany("reviews")
                        .HasForeignKey("clientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reviews_clients_client_id");

                    b.HasOne("GenericCourses.Domain.Entities.Course", "course")
                        .WithMany("reviews")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_reviews_courses_course_id");

                    b.Navigation("client");

                    b.Navigation("course");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Video", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Module", null)
                        .WithMany("videos")
                        .HasForeignKey("moduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_videos_modules_module_id");
                });

            modelBuilder.Entity("ModuleProgress", b =>
                {
                    b.HasOne("CourseProgress", "course_progress")
                        .WithMany()
                        .HasForeignKey("courseProgressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_modules_progress_course_progresses_course_progress_id");

                    b.HasOne("GenericCourses.Domain.Entities.Module", "module")
                        .WithMany()
                        .HasForeignKey("moduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_modules_progress_modules_module_id");

                    b.Navigation("course_progress");

                    b.Navigation("module");
                });

            modelBuilder.Entity("VideoProgress", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Module", "module")
                        .WithMany()
                        .HasForeignKey("moduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_video_progresses_modules_module_id");

                    b.HasOne("GenericCourses.Domain.Entities.Video", "video")
                        .WithMany()
                        .HasForeignKey("videoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_video_progresses_videos_video_id");

                    b.Navigation("module");

                    b.Navigation("video");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.BlogPost", b =>
                {
                    b.Navigation("category");

                    b.Navigation("comments");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Client", b =>
                {
                    b.Navigation("reviews");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Course", b =>
                {
                    b.Navigation("categories");

                    b.Navigation("modules");

                    b.Navigation("reviews");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Instructor", b =>
                {
                    b.Navigation("posts");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Module", b =>
                {
                    b.Navigation("videos");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Subscriptionplan", b =>
                {
                    b.Navigation("clients");
                });
#pragma warning restore 612, 618
        }
    }
}
