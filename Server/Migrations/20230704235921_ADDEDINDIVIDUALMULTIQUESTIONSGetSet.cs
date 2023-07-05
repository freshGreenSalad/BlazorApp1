using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class ADDEDINDIVIDUALMULTIQUESTIONSGetSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionID",
                table: "individualMultiChoiceQuestion",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_individualMultiChoiceQuestion_QuestionID",
                table: "individualMultiChoiceQuestion",
                column: "QuestionID");

            migrationBuilder.AddForeignKey(
                name: "FK_individualMultiChoiceQuestion_Questions_QuestionID",
                table: "individualMultiChoiceQuestion",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_individualMultiChoiceQuestion_Questions_QuestionID",
                table: "individualMultiChoiceQuestion");

            migrationBuilder.DropIndex(
                name: "IX_individualMultiChoiceQuestion_QuestionID",
                table: "individualMultiChoiceQuestion");

            migrationBuilder.DropColumn(
                name: "QuestionID",
                table: "individualMultiChoiceQuestion");
        }
    }
}
