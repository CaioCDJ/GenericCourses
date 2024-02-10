using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GenericCourses.Infra.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PostCategoryFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "subscription_plans",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    months = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_subscription_plans", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    cpf = table.Column<int>(type: "integer", nullable: false),
                    phone = table.Column<int>(type: "integer", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_admins", x => x.id);
                    table.ForeignKey(
                        name: "fk_admins_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    subscriptionplan_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_clients", x => x.id);
                    table.ForeignKey(
                        name: "fk_clients_subscription_plans_subscriptionplan_id",
                        column: x => x.subscriptionplan_id,
                        principalTable: "subscription_plans",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_clients_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "instructors",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    social_network = table.Column<string>(type: "text", nullable: true),
                    github = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_instructors", x => x.id);
                    table.ForeignKey(
                        name: "fk_instructors_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    thumb = table.Column<string>(type: "text", nullable: true),
                    is_free = table.Column<bool>(type: "boolean", nullable: false),
                    duration = table.Column<string>(type: "text", nullable: true),
                    instructor_id = table.Column<Guid>(type: "uuid", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_courses", x => x.id);
                    table.ForeignKey(
                        name: "fk_courses_instructors_instructor_id",
                        column: x => x.instructor_id,
                        principalTable: "instructors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    category = table.Column<string>(type: "text", nullable: true),
                    courseid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_categories", x => x.id);
                    table.ForeignKey(
                        name: "fk_categories_courses_courseid",
                        column: x => x.courseid,
                        principalTable: "courses",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "certificates",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    courseid = table.Column<Guid>(type: "uuid", nullable: false),
                    course_id = table.Column<Guid>(type: "uuid", nullable: true),
                    emited_at = table.Column<DateTime>(type: "Date", nullable: false),
                    user_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_certificates", x => x.id);
                    table.ForeignKey(
                        name: "fk_certificates_courses_courseid",
                        column: x => x.courseid,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_certificates_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "course_progresses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    userid = table.Column<Guid>(type: "uuid", nullable: false),
                    client_id = table.Column<Guid>(type: "uuid", nullable: false),
                    course_id = table.Column<Guid>(type: "uuid", nullable: false),
                    done = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_course_progresses", x => x.id);
                    table.ForeignKey(
                        name: "fk_course_progresses_courses_course_id",
                        column: x => x.course_id,
                        principalTable: "courses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_course_progresses_users_userid",
                        column: x => x.userid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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
                    courseid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_modules", x => x.id);
                    table.ForeignKey(
                        name: "fk_modules_courses_courseid",
                        column: x => x.courseid,
                        principalTable: "courses",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "blog_posts",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    text = table.Column<string>(type: "text", nullable: true),
                    thumb = table.Column<string>(type: "text", nullable: true),
                    acesses = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    category_id = table.Column<Guid>(type: "uuid", nullable: false),
                    instructor_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_blog_posts", x => x.id);
                    table.ForeignKey(
                        name: "fk_blog_posts_categories_category_id",
                        column: x => x.category_id,
                        principalTable: "categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_blog_posts_instructors_instructor_id",
                        column: x => x.instructor_id,
                        principalTable: "instructors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "modules_progress",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    module_id = table.Column<Guid>(type: "uuid", nullable: false),
                    course_progress_id = table.Column<Guid>(type: "uuid", nullable: false),
                    done = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_modules_progress", x => x.id);
                    table.ForeignKey(
                        name: "fk_modules_progress_course_progresses_course_progress_id",
                        column: x => x.course_progress_id,
                        principalTable: "course_progresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_modules_progress_modules_module_id",
                        column: x => x.module_id,
                        principalTable: "modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "videos",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    video_url = table.Column<string>(type: "text", nullable: true),
                    duration = table.Column<string>(type: "text", nullable: true),
                    order = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "Date", nullable: false),
                    module_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_videos", x => x.id);
                    table.ForeignKey(
                        name: "fk_videos_modules_module_id",
                        column: x => x.module_id,
                        principalTable: "modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "video_progresses",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    video_id = table.Column<Guid>(type: "uuid", nullable: false),
                    module_id = table.Column<Guid>(type: "uuid", nullable: false),
                    done = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_video_progresses", x => x.id);
                    table.ForeignKey(
                        name: "fk_video_progresses_modules_module_id",
                        column: x => x.module_id,
                        principalTable: "modules",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_video_progresses_videos_video_id",
                        column: x => x.video_id,
                        principalTable: "videos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "id", "courseid", "category" },
                values: new object[,]
                {
                    { new Guid("16cd8eb9-72a2-44b8-bcbb-2db7916612ff"), null, "C#" },
                    { new Guid("3e753754-32e1-4517-ba42-0d21b1dfe793"), null, "C" },
                    { new Guid("61abe257-226c-4bd4-86a1-36a67a9168f9"), null, "Banco de dados" },
                    { new Guid("6635d32f-2967-4ba1-a729-ce819c507704"), null, "Php" },
                    { new Guid("73be8908-b53b-4266-a359-0d29210e4df3"), null, "Postgresql" },
                    { new Guid("90436445-dc9e-4181-8bef-b8effd6e9d8b"), null, "C" },
                    { new Guid("b11ddc11-1219-4823-be10-d94d0a1635cd"), null, "Laravel" },
                    { new Guid("cbf807d9-2658-49b5-89ca-9ae914284a16"), null, "TypeScript" },
                    { new Guid("eaaf2c39-debd-42fd-a976-cb1447c32f46"), null, "Docker" },
                    { new Guid("fdc1a7e4-6e85-415a-9183-642c0f7d9bde"), null, "Javascript" }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "cpf", "created_at", "email", "is_active", "name", "password", "phone" },
                values: new object[,]
                {
                    { new Guid("747395ec-04ea-4c0d-805d-50e456f397bc"), 0, new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1743), "admin@admin.com", true, "admin", "$2a$11$8xZE/aTlLanfhip4fQrz3.fWL8mhvXKkrpF0ViE/QGnCBjWBgZvoe", null },
                    { new Guid("91313bce-d20b-497e-8a8e-c5dbd1d22204"), 0, new DateTime(2024, 2, 10, 12, 44, 12, 780, DateTimeKind.Local).AddTicks(8872), "user@email.com", true, "user", "$2a$11$JfW7JhOk4IqKqnJbwXGuA.AIIdQarYv8cfEsP2gFLq.JBlLX9pfcu", null }
                });

            migrationBuilder.InsertData(
                table: "instructors",
                columns: new[] { "id", "github", "social_network", "user_id" },
                values: new object[] { new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"), null, null, new Guid("747395ec-04ea-4c0d-805d-50e456f397bc") });

            migrationBuilder.InsertData(
                table: "blog_posts",
                columns: new[] { "id", "acesses", "category_id", "created_at", "instructor_id", "text", "thumb", "title" },
                values: new object[,]
                {
                    { new Guid("01e4efd2-202e-4ffa-86f5-415dff4b3845"), 0, new Guid("16cd8eb9-72a2-44b8-bcbb-2db7916612ff"), new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1503), new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"), "Iste et voluptatem.", null, "Frango" },
                    { new Guid("5582798a-d8cd-48db-a55f-157d18c2166c"), 0, new Guid("fdc1a7e4-6e85-415a-9183-642c0f7d9bde"), new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1218), new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"), "Commodi libero eos consequatur incidunt.\nRepellat tempora sequi officiis itaque tempore sit quibusdam explicabo.\nEt corrupti est vitae officiis quas.\nNumquam voluptates distinctio omnis.\nDoloremque ipsum repellendus iure delectus.", null, "Queijo" },
                    { new Guid("6f910259-c77d-4e64-913a-55375b9ebff3"), 0, new Guid("cbf807d9-2658-49b5-89ca-9ae914284a16"), new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1397), new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"), "Voluptatem fugit sapiente ducimus inventore perspiciatis.", null, "Computador" },
                    { new Guid("783bcce9-e653-4683-ab51-86d7167ec3bc"), 0, new Guid("cbf807d9-2658-49b5-89ca-9ae914284a16"), new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1562), new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"), "Odio sunt temporibus.", null, "Salsicha" },
                    { new Guid("94de7881-0c4f-454f-83ff-d789f473096a"), 0, new Guid("3e753754-32e1-4517-ba42-0d21b1dfe793"), new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(512), new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"), "Consequatur fugiat corporis incidunt.\nUt vitae consequatur dolorum quaerat voluptatem.\nDolorem ut eum.\nAliquid sed quam minima mollitia sed magni.", null, "Frango" },
                    { new Guid("b4300719-96b3-4c4c-9c81-68a52f2c56cf"), 0, new Guid("b11ddc11-1219-4823-be10-d94d0a1635cd"), new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1613), new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"), "Est dolor quam eius omnis quia autem eos quaerat. Ducimus omnis libero impedit qui repellendus. Unde et qui velit.", null, "Salgadinhos" },
                    { new Guid("c5245898-d7d4-4e5f-9a08-7c553a5c2ebb"), 0, new Guid("61abe257-226c-4bd4-86a1-36a67a9168f9"), new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(984), new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"), "Ut sed corrupti quia impedit incidunt voluptate ipsam tempora.\nAut ad voluptatibus suscipit possimus.\nVoluptate magni fugiat exercitationem porro eum labore.\nVoluptas nam illo non consequatur nihil sunt.\nEaque laudantium hic.\nDolorem necessitatibus deserunt et non modi.", null, "Sapatos" },
                    { new Guid("e48f3892-8eb8-4a14-9582-669e482585db"), 0, new Guid("90436445-dc9e-4181-8bef-b8effd6e9d8b"), new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(778), new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"), "Rerum excepturi mollitia. Ut laboriosam reprehenderit qui expedita quia cum vero quo. Debitis ipsam in eius aut deserunt laudantium.", null, "Salada" },
                    { new Guid("e731f7cb-3deb-4dac-9ffd-476fea7394b3"), 0, new Guid("3e753754-32e1-4517-ba42-0d21b1dfe793"), new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(27), new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"), "ut", null, "Bola" },
                    { new Guid("fe83a16d-4c43-4d8b-aae1-f8c3599d16cd"), 0, new Guid("90436445-dc9e-4181-8bef-b8effd6e9d8b"), new DateTime(2024, 2, 10, 12, 44, 12, 664, DateTimeKind.Local).AddTicks(1459), new Guid("31d1c6d0-129a-4d7a-b002-66bd67044f51"), "natus", null, "Pizza" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_admins_user_id",
                table: "admins",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_blog_posts_category_id",
                table: "blog_posts",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "ix_blog_posts_instructor_id",
                table: "blog_posts",
                column: "instructor_id");

            migrationBuilder.CreateIndex(
                name: "ix_categories_courseid",
                table: "categories",
                column: "courseid");

            migrationBuilder.CreateIndex(
                name: "ix_certificates_courseid",
                table: "certificates",
                column: "courseid");

            migrationBuilder.CreateIndex(
                name: "ix_certificates_user_id",
                table: "certificates",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_clients_subscriptionplan_id",
                table: "clients",
                column: "subscriptionplan_id");

            migrationBuilder.CreateIndex(
                name: "ix_clients_user_id",
                table: "clients",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_course_progresses_course_id",
                table: "course_progresses",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "ix_course_progresses_userid",
                table: "course_progresses",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "ix_courses_instructor_id",
                table: "courses",
                column: "instructor_id");

            migrationBuilder.CreateIndex(
                name: "ix_instructors_user_id",
                table: "instructors",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_modules_courseid",
                table: "modules",
                column: "courseid");

            migrationBuilder.CreateIndex(
                name: "ix_modules_progress_course_progress_id",
                table: "modules_progress",
                column: "course_progress_id");

            migrationBuilder.CreateIndex(
                name: "ix_modules_progress_module_id",
                table: "modules_progress",
                column: "module_id");

            migrationBuilder.CreateIndex(
                name: "ix_video_progresses_module_id",
                table: "video_progresses",
                column: "module_id");

            migrationBuilder.CreateIndex(
                name: "ix_video_progresses_video_id",
                table: "video_progresses",
                column: "video_id");

            migrationBuilder.CreateIndex(
                name: "ix_videos_module_id",
                table: "videos",
                column: "module_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "blog_posts");

            migrationBuilder.DropTable(
                name: "certificates");

            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "modules_progress");

            migrationBuilder.DropTable(
                name: "video_progresses");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "subscription_plans");

            migrationBuilder.DropTable(
                name: "course_progresses");

            migrationBuilder.DropTable(
                name: "videos");

            migrationBuilder.DropTable(
                name: "modules");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "instructors");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
