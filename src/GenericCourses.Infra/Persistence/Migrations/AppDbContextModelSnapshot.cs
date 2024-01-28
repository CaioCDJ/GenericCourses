﻿// <auto-generated />
using System;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GenericCourses.Infra.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("GenericCourses.Domain.Entities.BlogPost", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("acesses")
                        .HasColumnType("integer");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("Date");

                    b.Property<string>("text")
                        .HasColumnType("text");

                    b.Property<string>("thumb")
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<Guid>("userId")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("blogPosts");

                    b.HasData(
                        new
                        {
                            id = new Guid("bbc9a633-ba27-4e1a-acb1-be64c8fdc7da"),
                            acesses = 0,
                            created_at = new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(138),
                            text = "Itaque aperiam perferendis dolore tenetur expedita laborum. Autem autem in. Molestiae saepe nesciunt libero modi cum deleniti saepe dolores. Et optio itaque. Ullam adipisci fugiat enim odit vitae doloremque atque. Nemo consequatur tempora dolore.",
                            title = "Chapéu",
                            userId = new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df")
                        },
                        new
                        {
                            id = new Guid("c0bcf9ae-9eda-4378-94ce-2de8cdaf320c"),
                            acesses = 0,
                            created_at = new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(333),
                            text = "Quia quaerat non rerum vel cum soluta voluptatum sapiente minima.",
                            title = "Bola",
                            userId = new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df")
                        },
                        new
                        {
                            id = new Guid("81091d81-47c7-416b-98a1-cbef61fa86d5"),
                            acesses = 0,
                            created_at = new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(390),
                            text = "Voluptates rerum et autem doloremque fugiat sit quam.\nAut praesentium quia officia et est quisquam quia assumenda.\nDicta eligendi velit nisi blanditiis id fugiat autem.\nRerum laboriosam corporis.",
                            title = "Luvas",
                            userId = new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df")
                        },
                        new
                        {
                            id = new Guid("5b84206a-4459-4593-80e8-ad1f358cfc25"),
                            acesses = 0,
                            created_at = new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(544),
                            text = "Hic iusto unde iusto eum ipsum molestiae at.\nUt ducimus accusamus eius.\nRatione quo iure tenetur ipsa.\nIn quo aspernatur autem nemo.",
                            title = "Peixe",
                            userId = new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df")
                        },
                        new
                        {
                            id = new Guid("34eee0b0-1440-4165-8a80-2b8dbdd99b4e"),
                            acesses = 0,
                            created_at = new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(644),
                            text = "In ipsam distinctio.\nSit sequi autem est ea alias deserunt et.\nNon voluptatem fugit et maxime laboriosam esse vel vel.\nA est facere necessitatibus quae.",
                            title = "Salada",
                            userId = new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df")
                        },
                        new
                        {
                            id = new Guid("c0d365b9-9a5d-4726-ba3f-2ab1c0d6d891"),
                            acesses = 0,
                            created_at = new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(880),
                            text = "Quia voluptate possimus. Quae facilis non inventore. Sed perspiciatis placeat distinctio. Est inventore similique ipsam necessitatibus.",
                            title = "Camiseta",
                            userId = new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df")
                        },
                        new
                        {
                            id = new Guid("4ad4c3cd-1d52-4937-b249-c26ab82fdce0"),
                            acesses = 0,
                            created_at = new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(1007),
                            text = "Ut eaque repellat est atque enim ex sunt est. Consequatur sint nobis vero ea quod voluptas. Eos voluptatem rerum et dolores sed ea ipsa. Est delectus sed illum. Inventore unde tempora. Dolorem et maxime.",
                            title = "Computador",
                            userId = new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df")
                        },
                        new
                        {
                            id = new Guid("8a93d2f7-5944-4159-a30a-98c605c3cd29"),
                            acesses = 0,
                            created_at = new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(1228),
                            text = "Aliquid sit dolores nostrum possimus asperiores dignissimos sint.\nQuisquam amet provident.\nOccaecati dolorem doloribus officia rerum corrupti earum sapiente est.",
                            title = "Carro",
                            userId = new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df")
                        },
                        new
                        {
                            id = new Guid("f7c03de2-f552-43d3-a413-fd108dff129f"),
                            acesses = 0,
                            created_at = new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(1321),
                            text = "Amet ullam modi repudiandae cupiditate veritatis.\nEarum at in consequuntur.\nIn ut omnis iure ut animi.\nPlaceat suscipit qui.\nNobis voluptatibus ut quidem.",
                            title = "Salgadinhos",
                            userId = new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df")
                        },
                        new
                        {
                            id = new Guid("5168a64a-36b6-4aaa-af89-d2984e9edf4b"),
                            acesses = 0,
                            created_at = new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(1465),
                            text = "quia",
                            title = "Salada",
                            userId = new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df")
                        });
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("BlogPostid")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("Courseid")
                        .HasColumnType("uuid");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("BlogPostid");

                    b.HasIndex("Courseid");

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
                        .HasColumnType("Date");

                    b.Property<Guid>("userId")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("courseId");

                    b.HasIndex("userId");

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
                        .HasColumnType("Date");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("duration")
                        .HasColumnType("text");

                    b.Property<string>("instrutor")
                        .HasColumnType("text");

                    b.Property<bool>("isFree")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("lastupdate")
                        .HasColumnType("Date");

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

                    b.HasIndex("courseId");

                    b.ToTable("modules");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Subscriptionplan", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("Date");

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
                        .HasColumnType("Date");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("github")
                        .HasColumnType("text");

                    b.Property<bool>("is_active")
                        .HasColumnType("boolean");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("phoneNumber")
                        .HasColumnType("integer");

                    b.Property<int>("role")
                        .HasColumnType("integer");

                    b.Property<string>("socialNetwork")
                        .HasColumnType("text");

                    b.Property<Guid?>("subscriptionplanId")
                        .HasColumnType("uuid");

                    b.HasKey("id");

                    b.HasIndex("subscriptionplanId");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            id = new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df"),
                            cpf = 0,
                            createdAt = new DateTime(2024, 1, 28, 14, 34, 0, 513, DateTimeKind.Local).AddTicks(9899),
                            email = "admin@admin.com",
                            is_active = true,
                            name = "admin",
                            role = 2
                        },
                        new
                        {
                            id = new Guid("729101f8-0085-4ed9-b06d-382e0efda857"),
                            cpf = 0,
                            createdAt = new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(83),
                            email = "user@email.com",
                            is_active = true,
                            name = "user",
                            role = 2
                        });
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Video", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("Date");

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

            modelBuilder.Entity("GenericCourses.Domain.Entities.BlogPost", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.User", null)
                        .WithMany("posts")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Category", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.BlogPost", null)
                        .WithMany("categories")
                        .HasForeignKey("BlogPostid");

                    b.HasOne("GenericCourses.Domain.Entities.Course", null)
                        .WithMany("categories")
                        .HasForeignKey("Courseid");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Certificate", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Course", "course")
                        .WithMany()
                        .HasForeignKey("courseId");

                    b.HasOne("GenericCourses.Domain.Entities.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");

                    b.Navigation("user");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Module", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Course", null)
                        .WithMany("modules")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.User", b =>
                {
                    b.HasOne("GenericCourses.Domain.Entities.Subscriptionplan", "subscriptionplan")
                        .WithMany("users")
                        .HasForeignKey("subscriptionplanId");

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

            modelBuilder.Entity("GenericCourses.Domain.Entities.BlogPost", b =>
                {
                    b.Navigation("categories");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Course", b =>
                {
                    b.Navigation("categories");

                    b.Navigation("modules");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Module", b =>
                {
                    b.Navigation("videos");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.Subscriptionplan", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("GenericCourses.Domain.Entities.User", b =>
                {
                    b.Navigation("posts");
                });
#pragma warning restore 612, 618
        }
    }
}
