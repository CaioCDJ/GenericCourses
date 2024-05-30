using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenericCourses.Infra.Persistence.Migrations;
/// <inheritdoc />
public partial class commentsAndReview : Migration {
	/// <inheritdoc />
	protected override void Up(MigrationBuilder migrationBuilder) {
		migrationBuilder.CreateTable(
			name: "subscription_plans",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				price = table.Column<float>(type: "real", nullable: false),
				description = table.Column<string>(type: "text", nullable: false),
				created_at = table.Column<DateTime>(type: "Date", nullable: false),
				months = table.Column<int>(type: "integer", nullable: false)
			},
			constraints: table => {
				table.PrimaryKey("pk_subscription_plans", x => x.id);
			});

		migrationBuilder.CreateTable(
			name: "users",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				name = table.Column<string>(type: "text", nullable: false),
				email = table.Column<string>(type: "text", nullable: false),
				password = table.Column<string>(type: "text", nullable: false),
				cpf = table.Column<int>(type: "integer", nullable: false),
				phone = table.Column<int>(type: "integer", nullable: true),
				is_active = table.Column<bool>(type: "boolean", nullable: false),
				created_at = table.Column<DateTime>(type: "Date", nullable: false)
			},
			constraints: table => {
				table.PrimaryKey("pk_users", x => x.id);
			});

		migrationBuilder.CreateTable(
			name: "admins",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				user_id = table.Column<Guid>(type: "uuid", nullable: false)
			},
			constraints: table => {
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
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				user_id = table.Column<Guid>(type: "uuid", nullable: false),
				subscriptionplan_id = table.Column<Guid>(type: "uuid", nullable: true)
			},
			constraints: table => {
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
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				user_id = table.Column<Guid>(type: "uuid", nullable: false),
				social_network = table.Column<string>(type: "text", nullable: true),
				github = table.Column<string>(type: "text", nullable: true)
			},
			constraints: table => {
				table.PrimaryKey("pk_instructors", x => x.id);
				table.ForeignKey(
					name: "fk_instructors_users_user_id",
					column: x => x.user_id,
					principalTable: "users",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateTable(
			name: "blog_posts",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				title = table.Column<string>(type: "text", nullable: true),
				text = table.Column<string>(type: "text", nullable: true),
				thumb = table.Column<string>(type: "text", nullable: true),
				acesses = table.Column<int>(type: "integer", nullable: false),
				created_at = table.Column<DateTime>(type: "Date", nullable: false),
				instructor_id = table.Column<Guid>(type: "uuid", nullable: false)
			},
			constraints: table => {
				table.PrimaryKey("pk_blog_posts", x => x.id);
				table.ForeignKey(
					name: "fk_blog_posts_instructors_instructor_id",
					column: x => x.instructor_id,
					principalTable: "instructors",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateTable(
			name: "courses",
			columns: table => new {
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
			constraints: table => {
				table.PrimaryKey("pk_courses", x => x.id);
				table.ForeignKey(
					name: "fk_courses_instructors_instructor_id",
					column: x => x.instructor_id,
					principalTable: "instructors",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateTable(
			name: "comments",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				text = table.Column<string>(type: "text", nullable: false),
				blog_post_id = table.Column<Guid>(type: "uuid", nullable: false),
				created_at = table.Column<DateTime>(type: "Date", nullable: false)
			},
			constraints: table => {
				table.PrimaryKey("pk_comments", x => x.id);
				table.ForeignKey(
					name: "fk_comments_blog_posts_blog_post_id",
					column: x => x.blog_post_id,
					principalTable: "blog_posts",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateTable(
			name: "categories",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				name = table.Column<string>(type: "text", nullable: true),
				blog_post_id = table.Column<Guid>(type: "uuid", nullable: true),
				course_id = table.Column<Guid>(type: "uuid", nullable: true)
			},
			constraints: table => {
				table.PrimaryKey("pk_categories", x => x.id);
				table.ForeignKey(
					name: "fk_categories_blog_posts_blog_post_id",
					column: x => x.blog_post_id,
					principalTable: "blog_posts",
					principalColumn: "id");
				table.ForeignKey(
					name: "fk_categories_courses_course_id",
					column: x => x.course_id,
					principalTable: "courses",
					principalColumn: "id");
			});

		migrationBuilder.CreateTable(
			name: "certificates",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				course_id = table.Column<Guid>(type: "uuid", nullable: true),
				emited_at = table.Column<DateTime>(type: "Date", nullable: false),
				user_id = table.Column<Guid>(type: "uuid", nullable: false)
			},
			constraints: table => {
				table.PrimaryKey("pk_certificates", x => x.id);
				table.ForeignKey(
					name: "fk_certificates_courses_course_id",
					column: x => x.course_id,
					principalTable: "courses",
					principalColumn: "id");
				table.ForeignKey(
					name: "fk_certificates_users_user_id",
					column: x => x.user_id,
					principalTable: "users",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateTable(
			name: "course_progresses",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				user_id = table.Column<Guid>(type: "uuid", nullable: false),
				course_id = table.Column<Guid>(type: "uuid", nullable: false),
				done = table.Column<bool>(type: "boolean", nullable: false)
			},
			constraints: table => {
				table.PrimaryKey("pk_course_progresses", x => x.id);
				table.ForeignKey(
					name: "fk_course_progresses_courses_course_id",
					column: x => x.course_id,
					principalTable: "courses",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
				table.ForeignKey(
					name: "fk_course_progresses_users_user_id",
					column: x => x.user_id,
					principalTable: "users",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateTable(
			name: "modules",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				title = table.Column<string>(type: "text", nullable: true),
				description = table.Column<string>(type: "text", nullable: true),
				order = table.Column<int>(type: "integer", nullable: false),
				complete = table.Column<bool>(type: "boolean", nullable: false),
				courseid = table.Column<Guid>(type: "uuid", nullable: true)
			},
			constraints: table => {
				table.PrimaryKey("pk_modules", x => x.id);
				table.ForeignKey(
					name: "fk_modules_courses_courseid",
					column: x => x.courseid,
					principalTable: "courses",
					principalColumn: "id");
			});

		migrationBuilder.CreateTable(
			name: "reviews",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				text = table.Column<string>(type: "text", nullable: false),
				created_at = table.Column<DateTime>(type: "Date", nullable: false),
				client_id = table.Column<Guid>(type: "uuid", nullable: false),
				course_id = table.Column<Guid>(type: "uuid", nullable: false)
			},
			constraints: table => {
				table.PrimaryKey("pk_reviews", x => x.id);
				table.ForeignKey(
					name: "fk_reviews_clients_client_id",
					column: x => x.client_id,
					principalTable: "clients",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
				table.ForeignKey(
					name: "fk_reviews_courses_course_id",
					column: x => x.course_id,
					principalTable: "courses",
					principalColumn: "id",
					onDelete: ReferentialAction.Cascade);
			});

		migrationBuilder.CreateTable(
			name: "modules_progress",
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				module_id = table.Column<Guid>(type: "uuid", nullable: false),
				course_progress_id = table.Column<Guid>(type: "uuid", nullable: false),
				done = table.Column<bool>(type: "boolean", nullable: false)
			},
			constraints: table => {
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
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				title = table.Column<string>(type: "text", nullable: true),
				description = table.Column<string>(type: "text", nullable: true),
				video_url = table.Column<string>(type: "text", nullable: true),
				duration = table.Column<string>(type: "text", nullable: true),
				order = table.Column<int>(type: "integer", nullable: false),
				created_at = table.Column<DateTime>(type: "Date", nullable: false),
				module_id = table.Column<Guid>(type: "uuid", nullable: false)
			},
			constraints: table => {
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
			columns: table => new {
				id = table.Column<Guid>(type: "uuid", nullable: false),
				video_id = table.Column<Guid>(type: "uuid", nullable: false),
				module_id = table.Column<Guid>(type: "uuid", nullable: false),
				done = table.Column<bool>(type: "boolean", nullable: false)
			},
			constraints: table => {
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

		migrationBuilder.CreateIndex(
			name: "ix_admins_user_id",
			table: "admins",
			column: "user_id");

		migrationBuilder.CreateIndex(
			name: "ix_blog_posts_instructor_id",
			table: "blog_posts",
			column: "instructor_id");

		migrationBuilder.CreateIndex(
			name: "ix_categories_blog_post_id",
			table: "categories",
			column: "blog_post_id");

		migrationBuilder.CreateIndex(
			name: "ix_categories_course_id",
			table: "categories",
			column: "course_id");

		migrationBuilder.CreateIndex(
			name: "ix_certificates_course_id",
			table: "certificates",
			column: "course_id");

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
			name: "ix_comments_blog_post_id",
			table: "comments",
			column: "blog_post_id");

		migrationBuilder.CreateIndex(
			name: "ix_course_progresses_course_id",
			table: "course_progresses",
			column: "course_id");

		migrationBuilder.CreateIndex(
			name: "ix_course_progresses_user_id",
			table: "course_progresses",
			column: "user_id");

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
			name: "ix_reviews_client_id",
			table: "reviews",
			column: "client_id");

		migrationBuilder.CreateIndex(
			name: "ix_reviews_course_id",
			table: "reviews",
			column: "course_id");

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
	protected override void Down(MigrationBuilder migrationBuilder) {
		migrationBuilder.DropTable(
			name: "admins");

		migrationBuilder.DropTable(
			name: "categories");

		migrationBuilder.DropTable(
			name: "certificates");

		migrationBuilder.DropTable(
			name: "comments");

		migrationBuilder.DropTable(
			name: "modules_progress");

		migrationBuilder.DropTable(
			name: "reviews");

		migrationBuilder.DropTable(
			name: "video_progresses");

		migrationBuilder.DropTable(
			name: "blog_posts");

		migrationBuilder.DropTable(
			name: "course_progresses");

		migrationBuilder.DropTable(
			name: "clients");

		migrationBuilder.DropTable(
			name: "videos");

		migrationBuilder.DropTable(
			name: "subscription_plans");

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
