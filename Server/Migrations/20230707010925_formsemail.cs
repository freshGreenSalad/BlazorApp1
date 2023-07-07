using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class formsemail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Forms",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "Forms");
        }
    }
}
