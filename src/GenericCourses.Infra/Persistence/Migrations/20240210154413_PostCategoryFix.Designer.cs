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
    [Migration("20240210154413_PostCategoryFix")]
    partial class PostCategoryFix
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CourseProgress", b =>
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

                    b.Property<bool>("done")
                        .HasColumnType("boolean")
                        .HasColumnName("done");

                    b.Property<Guid>("userid")
                        .HasColumnType("uuid")
                        .HasColumnName("userid");

                    b.HasKey("id")
                        .HasName("pk_course_progresses");

                    b.HasIndex("courseId")
                        .HasDatabaseName("ix_course_progresses_course_id");

                    b.HasIndex("userid")
                        .HasDatabaseName("ix_course_progresses_userid");

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

                    b.Property<Guid>("categoryId")
                        .HasColumnType("uuid")
                        .HasColumnName("category_id");

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

                    b.HasIndex("categoryId")
                        .HasDatabaseName("ix_blog_posts_category_id");

                    b.HasIndex("instructorId")
                        .HasDatabaseName("ix_blog_posts_instructor_id");

                    b.ToTable("blog_posts", (string)null);

                    b.HasData(
                        new
                        {
                            id = new Guid("e731f7cb-3deb-4dac-9ffd-476fea7394b3"),
                            acesses = 0,
                            categoryId = new Guid("3e753754-32e1-4517-ba42-0d21b1dfe793"),
                            created_at = new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(27),
                            instructorId = new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"),
                            text = "ut",
                            title = "Bola"
                        },
                        new
                        {
                            id = new Guid("94de7881-0c4f-454f-83ff-d789f473096a"),
                            acesses = 0,
                            categoryId = new Guid("3e753754-32e1-4517-ba42-0d21b1dfe793"),
                            created_at = new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(512),
                            instructorId = new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"),
                            text = "Consequatur fugiat corporis incidunt.\nUt vitae consequatur dolorum quaerat voluptatem.\nDolorem ut eum.\nAliquid sed quam minima mollitia sed magni.",
                            title = "Frango"
                        },
                        new
                        {
                            id = new Guid("e48f3892-8eb8-4a14-9582-669e482585db"),
                            acesses = 0,
                            categoryId = new Guid("90436445-dc9e-4181-8bef-b8effd6e9d8b"),
                            created_at = new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(778),
                            instructorId = new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"),
                            text = "Rerum excepturi mollitia. Ut laboriosam reprehenderit qui expedita quia cum vero quo. Debitis ipsam in eius aut deserunt laudantium.",
                            title = "Salada"
                        },
                        new
                        {
                            id = new Guid("c5245898-d7d4-4e5f-9a08-7c553a5c2ebb"),
                            acesses = 0,
                            categoryId = new Guid("61abe257-226c-4bd4-86a1-36a67a9168f9"),
                            created_at = new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(984),
                            instructorId = new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"),
                            text = "Ut sed corrupti quia impedit incidunt voluptate ipsam tempora.\nAut ad voluptatibus suscipit possimus.\nVoluptate magni fugiat exercitationem porro eum labore.\nVoluptas nam illo non consequatur nihil sunt.\nEaque laudantium hic.\nDolorem necessitatibus deserunt et non modi.",
                            title = "Sapatos"
                        },
                        new
                        {
                            id = new Guid("5582798a-d8cd-48db-a55f-157d18c2166c"),
                            acesses = 0,
                            categoryId = new Guid("fdc1a7e4-6e85-415a-9183-642c0f7d9bde"),
                            created_at = new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1218),
                            instructorId = new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"),
                            text = "Commodi libero eos consequatur incidunt.\nRepellat tempora sequi officiis itaque tempore sit quibusdam explicabo.\nEt corrupti est vitae officiis quas.\nNumquam voluptates distinctio omnis.\nDoloremque ipsum repellendus iure delectus.",
                            title = "Queijo"
                        },
                        new
                        {
                            id = new Guid("6f910259-c77d-4e64-913a-55375b9ebff3"),
                            acesses = 0,
                            categoryId = new Guid("cbf807d9-2658-49b5-89ca-9ae914284a16"),
                            created_at = new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1397),
                            instructorId = new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"),
                            text = "Voluptatem fugit sapiente ducimus inventore perspiciatis.",
                            title = "Computador"
                        },
                        new
                        {
                            id = new Guid("fe83a16d-4c43-4d8b-aae1-f8c3599d16cd"),
                            acesses = 0,
                            categoryId = new Guid("90436445-dc9e-4181-8bef-b8effd6e9d8b"),
                            created_at = new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1459),
                            instructorId = new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"),
                            text = "natus",
                            title = "Pizza"
                        },
                        new
                        {
                            id = new Guid("01e4efd2-202e-4ffa-86f5-415dff4b3845"),
                            acesses = 0,
                            categoryId = new Guid("16cd8eb9-72a2-44b8-bcbb-2db7916612ff"),
                            created_at = new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1503),
                            instructorId = new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"),
                            text = "Iste et voluptatem.",
                            title = "Frango"
                        },
                        new
                        {
                            id = new Guid("783bcce9-e653-4683-ab51-86d7167ec3bc"),
                            acesses = 0,
                            categoryId = new Guid("cbf807d9-2658-49b5-89ca-9ae914284a16"),
                            created_at = new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1562),
                            instructorId = new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"),
                            text = "Odio sunt temporibus.",
                            title = "Salsicha"
                        },
                        new
                        {
                            id = new Guid("b4300719-96b3-4c4c-9c81-68a52f2c56cf"),
                            acesses = 0,
                            categoryId = new Guid("b11ddc11-1219-4823-be10-d94d0a1635cd"),
                            created_at = new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1613),
                            instructorId = new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"),
                            text = "Est dolor quam eius omnis quia autem eos quaerat. Ducimus omnis libero impedit qui repellendus. Unde et qui velit.",
                            title = "Salgadinhos"
                        });
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("Courseid")
                        .HasColumnType("uuid")
                        .HasColumnName("courseid");

                    b.Property<string>("category")
                        .HasColumnType("text")
                        .HasColumnName("category");

                    b.HasKey("id")
                        .HasName("pk_categories");

                    b.HasIndex("Courseid")
                        .HasDatabaseName("ix_categories_courseid");

                    b.ToTable("categories", (string)null);

                    b.HasData(
                        new
                        {
                            id = new Guid("16cd8eb9-72a2-44b8-bcbb-2db7916612ff"),
                            category = "C#"
                        },
                        new
                        {
                            id = new Guid("fdc1a7e4-6e85-415a-9183-642c0f7d9bde"),
                            category = "Javascript"
                        },
                        new
                        {
                            id = new Guid("cbf807d9-2658-49b5-89ca-9ae914284a16"),
                            category = "TypeScript"
                        },
                        new
                        {
                            id = new Guid("b11ddc11-1219-4823-be10-d94d0a1635cd"),
                            category = "Laravel"
                        },
                        new
                        {
                            id = new Guid("6635d32f-2967-4ba1-a729-ce819c507704"),
                            category = "Php"
                        },
                        new
                        {
                            id = new Guid("61abe257-226c-4bd4-86a1-36a67a9168f9"),
                            category = "Banco de dados"
                        },
                        new
                        {
                            id = new Guid("eaaf2c39-debd-42fd-a976-cb1447c32f46"),
                            category = "Docker"
                        },
                        new
                        {
                            id = new Guid("73be8908-b53b-4266-a359-0d29210e4df3"),
                            category = "Postgresql"
                        },
                        new
                        {
                            id = new Guid("90436445-dc9e-4181-8bef-b8effd6e9d8b"),
                            category = "C"
                        },
                        new
                        {
                            id = new Guid("3e753754-32e1-4517-ba42-0d21b1dfe793"),
                            category = "C"
                        });
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Certificate", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("course_id")
                        .HasColumnType("uuid")
                        .HasColumnName("course_id");

                    b.Property<Guid>("courseid")
                        .HasColumnType("uuid")
                        .HasColumnName("courseid");

                    b.Property<DateTime>("emited_at")
                        .HasColumnType("Date")
                        .HasColumnName("emited_at");

                    b.Property<Guid>("userId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("id")
                        .HasName("pk_certificates");

                    b.HasIndex("courseid")
                        .HasDatabaseName("ix_certificates_courseid");

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

                    b.HasData(
                        new
                        {
                            id = new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"),
                            userId = new Guid("747395ec-04ea-4c0d-805d-50e456f397bc")
                        });
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

                    b.HasData(
                        new
                        {
                            id = new Guid("747395ec-04ea-4c0d-805d-50e456f397bc"),
                            cpf = 0,
                            created_at = new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1743),
                            email = "admin@admin.com",
                            is_active = true,
                            name = "admin",
                            password = "$2a$11$8xZE/aTlLanfhip4fQrz3.fWL8mhvXKkrpF0ViE/QGnCBjWBgZvoe"
                        },
                        new
                        {
                            id = new Guid("91313bce-d20b-497e-8a8e-c5dbd1d22204"),
                            cpf = 0,
                            created_at = new DateTime(2024, 2, 10, 12, 44, 12, 780, DateTimeKind.Local).AddTicks(8872),
                            email = "user@email.com",
                            is_active = true,
                            name = "user",
                            password = "$2a$11$JfW7JhOk4IqKqnJbwXGuA.AIIdQarYv8cfEsP2gFLq.JBlLX9pfcu"
                        });
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
                        .HasForeignKey("userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_course_progresses_users_userid");

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
                    b.HasOne("GenericCourses.Domain.Entities.Category", "category")
                        .WithMany()
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_blog_posts_categories_category_id");

                    b.HasOne("GenericCourses.Domain.Entities.Instructor", "instructor")
                        .WithMany("posts")
                        .HasForeignKey("instructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_blog_posts_instructors_instructor_id");

                    b.Navigation("category");

                    b.Navigation("instructor");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Category", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Course", null)
                        .WithMany("categories")
                        .HasForeignKey("Courseid")
                        .HasConstraintName("fk_categories_courses_courseid");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Certificate", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Course", "course")
                        .WithMany()
                        .HasForeignKey("courseid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_certificates_courses_courseid");

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

            modelBuilder.Entity("GenericCourses.Domain.Entities.Course", b =>
                {
                    b.Navigation("categories");

                    b.Navigation("modules");
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
