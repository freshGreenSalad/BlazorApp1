using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    dateCreated = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    question = table.Column<string>(type: "TEXT", maxLength: 10000, nullable: false),
                    QuestionNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    QuestionType = table.Column<int>(type: "INTEGER", nullable: false),
                    FormID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Questions_Forms_FormID",
                        column: x => x.FormID,
                        principalTable: "Forms",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "individualMultiChoiceQuestion",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    question = table.Column<string>(type: "TEXT", nullable: false),
                    QuestionID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_individualMultiChoiceQuestion", x => x.ID);
                    table.ForeignKey(
                        name: "FK_individualMultiChoiceQuestion_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_individualMultiChoiceQuestion_QuestionID",
                table: "individualMultiChoiceQuestion",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_FormID",
                table: "Questions",
                column: "FormID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "individualMultiChoiceQuestion");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Forms");
        }
    }
}
