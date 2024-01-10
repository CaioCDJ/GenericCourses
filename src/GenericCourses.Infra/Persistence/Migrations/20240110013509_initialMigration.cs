using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenericCourses.Infra.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "certificates",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    courseId = table.Column<Guid>(type: "uuid", nullable: false),
                    emited_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_certificates", x => x.id);
                });

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
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lastupdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "modules",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    order = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    courseId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    text = table.Column<string>(type: "text", nullable: true),
                    userId = table.Column<string>(type: "text", nullable: true),
                    thumb = table.Column<string>(type: "text", nullable: true),
                    acesses = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_posts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "subscriptionplans",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    months = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_subscriptionplans", x => x.id);
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
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
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
                name: "categories",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    Courseid = table.Column<Guid>(type: "uuid", nullable: true),
                    Postid = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.id);
                    table.ForeignKey(
                        name: "FK_categories_courses_Courseid",
                        column: x => x.Courseid,
                        principalTable: "courses",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_categories_posts_Postid",
                        column: x => x.Postid,
                        principalTable: "posts",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "text", nullable: true),
                    email = table.Column<string>(type: "text", nullable: true),
                    cpf = table.Column<int>(type: "integer", nullable: false),
                    phoneNumber = table.Column<int>(type: "integer", nullable: false),
                    role = table.Column<int>(type: "integer", nullable: false),
                    socialNetwork = table.Column<string>(type: "text", nullable: true),
                    github = table.Column<string>(type: "text", nullable: true),
                    is_active = table.Column<bool>(type: "boolean", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    subscriptionplanId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                    table.ForeignKey(
                        name: "FK_users_subscriptionplans_subscriptionplanId",
                        column: x => x.subscriptionplanId,
                        principalTable: "subscriptionplans",
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

            migrationBuilder.CreateIndex(
                name: "IX_categories_Courseid",
                table: "categories",
                column: "Courseid");

            migrationBuilder.CreateIndex(
                name: "IX_categories_Postid",
                table: "categories",
                column: "Postid");

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
                name: "posts");

            migrationBuilder.DropTable(
                name: "CourseProgresses");

            migrationBuilder.DropTable(
                name: "videos");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "modules");

            migrationBuilder.DropTable(
                name: "subscriptionplans");
        }
    }
}
