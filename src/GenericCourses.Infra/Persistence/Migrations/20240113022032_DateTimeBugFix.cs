using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GenericCourses.Infra.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DateTimeBugFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_subscriptionplans_subscriptionplanId",
                table: "users");

            migrationBuilder.AlterColumn<Guid>(
                name: "subscriptionplanId",
                table: "users",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_users_subscriptionplans_subscriptionplanId",
                table: "users",
                column: "subscriptionplanId",
                principalTable: "subscriptionplans",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_subscriptionplans_subscriptionplanId",
                table: "users");

            migrationBuilder.AlterColumn<Guid>(
                name: "subscriptionplanId",
                table: "users",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_users_subscriptionplans_subscriptionplanId",
                table: "users",
                column: "subscriptionplanId",
                principalTable: "subscriptionplans",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
