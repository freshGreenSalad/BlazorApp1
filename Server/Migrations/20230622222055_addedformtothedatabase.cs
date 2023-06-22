using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class addedformtothedatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "questionType",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "FormID",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_FormID",
                table: "Questions",
                column: "FormID");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Forms_FormID",
                table: "Questions",
                column: "FormID",
                principalTable: "Forms",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Forms_FormID",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropIndex(
                name: "IX_Questions_FormID",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "FormID",
                table: "Questions");

            migrationBuilder.AddColumn<int>(
                name: "questionType",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
