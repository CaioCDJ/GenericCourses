using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GenericCourses.Infra.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class CertificateFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    thumb = table.Column<string>(type: "text", nullable: true),
                    isFree = table.Column<bool>(type: "boolean", nullable: false),
                    duration = table.Column<string>(type: "text", nullable: true),
                    instrutor = table.Column<string>(type: "text", nullable: true),
                    active = table.Column<bool>(type: "boolean", nullable: false),
                    createdAt = table.Column<DateTime>(type: "Date", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "subscriptionplans",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    createdAt = table.Column<DateTime>(type: "Date", nullable: false),
                    months = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscriptionplans", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    order = table.Column<int>(type: "integer", nullable: false),
                    complete = table.Column<bool>(type: "boolean", nullable: false),
                    courseId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modules", x => x.id);
                    table.ForeignKey(
                        name: "FK_modules_courses_courseId",
                        column: x => x.courseId,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    cpf = table.Column<int>(type: "integer", nullable: false),
                    phoneNumber = table.Column<int>(type: "integer", nullable: true),
                    role = table.Column<int>(type: "integer", nullable: false),
                    socialNetwork = table.Column<string>(type: "text", nullable: true),
                    github = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    createdAt = table.Column<DateTime>(type: "Date", nullable: false),
                    subscriptionplanId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_users_subscriptionplans_subscriptionplanId",
                        column: x => x.subscriptionplanId,
                        principalTable: "subscriptionplans",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "videos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    videoUrl = table.Column<string>(type: "text", nullable: true),
                    duration = table.Column<string>(type: "text", nullable: true),
                    order = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "Date", nullable: false),
                    moduleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videos", x => x.id);
                    table.ForeignKey(
                        name: "FK_videos_modules_moduleId",
                        column: x => x.moduleId,
                        principalTable: "modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "blogPosts",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    text = table.Column<string>(type: "text", nullable: true),
                    thumb = table.Column<string>(type: "text", nullable: true),
                    acesses = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    userId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogPosts", x => x.id);
                    table.ForeignKey(
                        name: "FK_blogPosts_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "certificates",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    courseId = table.Column<Guid>(type: "uuid", nullable: true),
                    emited_at = table.Column<DateTime>(type: "Date", nullable: false),
                    userId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_certificates", x => x.id);
                    table.ForeignKey(
                        name: "FK_certificates_courses_courseId",
                        column: x => x.courseId,
                        principalTable: "courses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_certificates_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseProgresses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    userId = table.Column<Guid>(type: "uuid", nullable: false),
                    courseId = table.Column<Guid>(type: "uuid", nullable: false),
                    done = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseProgresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_CourseProgresses_courses_courseId",
                        column: x => x.courseId,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseProgresses_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoProgresses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    videoId = table.Column<Guid>(type: "uuid", nullable: false),
                    moduleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoProgresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_VideoProgresses_modules_moduleId",
                        column: x => x.moduleId,
                        principalTable: "modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoProgresses_videos_videoId",
                        column: x => x.videoId,
                        principalTable: "videos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    BlogPostid = table.Column<Guid>(type: "uuid", nullable: true),
                    Courseid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.id);
                    table.ForeignKey(
                        name: "FK_categories_blogPosts_BlogPostid",
                        column: x => x.BlogPostid,
                        principalTable: "blogPosts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_categories_courses_Courseid",
                        column: x => x.Courseid,
                        principalTable: "courses",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "moduleProgresses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    moduleId = table.Column<Guid>(type: "uuid", nullable: false),
                    courseProgressId = table.Column<Guid>(type: "uuid", nullable: false),
                    done = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moduleProgresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_moduleProgresses_CourseProgresses_courseProgressId",
                        column: x => x.courseProgressId,
                        principalTable: "CourseProgresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_moduleProgresses_modules_moduleId",
                        column: x => x.moduleId,
                        principalTable: "modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "cpf", "createdAt", "email", "github", "is_active", "name", "phoneNumber", "role", "socialNetwork", "subscriptionplanId" },
                values: new object[,]
                {
                    { new Guid("729101f8-0085-4ed9-b06d-382e0efda857"), 0, new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(83), "user@email.com", null, true, "user", null, 2, null, null },
                    { new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df"), 0, new DateTime(2024, 1, 28, 14, 34, 0, 513, DateTimeKind.Local).AddTicks(9899), "admin@admin.com", null, true, "admin", null, 2, null, null }
                });

            migrationBuilder.InsertData(
                table: "blogPosts",
                columns: new[] { "id", "acesses", "created_at", "text", "thumb", "title", "userId" },
                values: new object[,]
                {
                    { new Guid("34eee0b0-1440-4165-8a80-2b8dbdd99b4e"), 0, new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(644), "In ipsam distinctio.\nSit sequi autem est ea alias deserunt et.\nNon voluptatem fugit et maxime laboriosam esse vel vel.\nA est facere necessitatibus quae.", null, "Salada", new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df") },
                    { new Guid("4ad4c3cd-1d52-4937-b249-c26ab82fdce0"), 0, new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(1007), "Ut eaque repellat est atque enim ex sunt est. Consequatur sint nobis vero ea quod voluptas. Eos voluptatem rerum et dolores sed ea ipsa. Est delectus sed illum. Inventore unde tempora. Dolorem et maxime.", null, "Computador", new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df") },
                    { new Guid("5168a64a-36b6-4aaa-af89-d2984e9edf4b"), 0, new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(1465), "quia", null, "Salada", new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df") },
                    { new Guid("5b84206a-4459-4593-80e8-ad1f358cfc25"), 0, new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(544), "Hic iusto unde iusto eum ipsum molestiae at.\nUt ducimus accusamus eius.\nRatione quo iure tenetur ipsa.\nIn quo aspernatur autem nemo.", null, "Peixe", new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df") },
                    { new Guid("81091d81-47c7-416b-98a1-cbef61fa86d5"), 0, new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(390), "Voluptates rerum et autem doloremque fugiat sit quam.\nAut praesentium quia officia et est quisquam quia assumenda.\nDicta eligendi velit nisi blanditiis id fugiat autem.\nRerum laboriosam corporis.", null, "Luvas", new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df") },
                    { new Guid("8a93d2f7-5944-4159-a30a-98c605c3cd29"), 0, new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(1228), "Aliquid sit dolores nostrum possimus asperiores dignissimos sint.\nQuisquam amet provident.\nOccaecati dolorem doloribus officia rerum corrupti earum sapiente est.", null, "Carro", new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df") },
                    { new Guid("bbc9a633-ba27-4e1a-acb1-be64c8fdc7da"), 0, new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(138), "Itaque aperiam perferendis dolore tenetur expedita laborum. Autem autem in. Molestiae saepe nesciunt libero modi cum deleniti saepe dolores. Et optio itaque. Ullam adipisci fugiat enim odit vitae doloremque atque. Nemo consequatur tempora dolore.", null, "Chapéu", new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df") },
                    { new Guid("c0bcf9ae-9eda-4378-94ce-2de8cdaf320c"), 0, new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(333), "Quia quaerat non rerum vel cum soluta voluptatum sapiente minima.", null, "Bola", new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df") },
                    { new Guid("c0d365b9-9a5d-4726-ba3f-2ab1c0d6d891"), 0, new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(880), "Quia voluptate possimus. Quae facilis non inventore. Sed perspiciatis placeat distinctio. Est inventore similique ipsam necessitatibus.", null, "Camiseta", new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df") },
                    { new Guid("f7c03de2-f552-43d3-a413-fd108dff129f"), 0, new DateTime(2024, 1, 28, 14, 34, 0, 514, DateTimeKind.Local).AddTicks(1321), "Amet ullam modi repudiandae cupiditate veritatis.\nEarum at in consequuntur.\nIn ut omnis iure ut animi.\nPlaceat suscipit qui.\nNobis voluptatibus ut quidem.", null, "Salgadinhos", new Guid("9f477862-f692-4b6a-b475-3fd9a786d8df") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_blogPosts_userId",
                table: "blogPosts",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_categories_BlogPostid",
                table: "categories",
                column: "BlogPostid");

            migrationBuilder.CreateIndex(
                name: "IX_categories_Courseid",
                table: "categories",
                column: "Courseid");

            migrationBuilder.CreateIndex(
                name: "IX_certificates_courseId",
                table: "certificates",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_certificates_userId",
                table: "certificates",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseProgresses_courseId",
                table: "CourseProgresses",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseProgresses_userId",
                table: "CourseProgresses",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_moduleProgresses_courseProgressId",
                table: "moduleProgresses",
                column: "courseProgressId");

            migrationBuilder.CreateIndex(
                name: "IX_moduleProgresses_moduleId",
                table: "moduleProgresses",
                column: "moduleId");

            migrationBuilder.CreateIndex(
                name: "IX_modules_courseId",
                table: "modules",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_users_subscriptionplanId",
                table: "users",
                column: "subscriptionplanId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoProgresses_moduleId",
                table: "VideoProgresses",
                column: "moduleId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoProgresses_videoId",
                table: "VideoProgresses",
                column: "videoId");

            migrationBuilder.CreateIndex(
                name: "IX_videos_moduleId",
                table: "videos",
                column: "moduleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "certificates");

            migrationBuilder.DropTable(
                name: "moduleProgresses");

            migrationBuilder.DropTable(
                name: "VideoProgresses");

            migrationBuilder.DropTable(
                name: "blogPosts");

            migrationBuilder.DropTable(
                name: "CourseProgresses");

            migrationBuilder.DropTable(
                name: "videos");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "modules");

            migrationBuilder.DropTable(
                name: "subscriptionplans");

            migrationBuilder.DropTable(
                name: "courses");
        }
    }
}
