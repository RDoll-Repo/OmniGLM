using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OmniGLM_API.Migrations
{
    /// <inheritdoc />
    public partial class AddTimestampsForGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "date_added",
                table: "games",
                newName: "created_at");

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "games",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "games");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "games",
                newName: "date_added");
        }
    }
}
