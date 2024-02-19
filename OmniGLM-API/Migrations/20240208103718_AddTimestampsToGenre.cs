using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OmniGLM_API.Migrations
{
    /// <inheritdoc />
    public partial class AddTimestampsToGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "genres",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "genres",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "genres");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "genres");
        }
    }
}
