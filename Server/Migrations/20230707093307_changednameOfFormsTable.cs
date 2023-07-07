using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    /// <inheritdoc />
    public partial class changednameOfFormsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_individualMultiChoiceQuestion_Questions_QuestionID",
                table: "individualMultiChoiceQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Forms_FormID",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Forms",
                table: "Forms");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameTable(
                name: "Forms",
                newName: "Form");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_FormID",
                table: "Question",
                newName: "IX_Question_FormID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Form",
                table: "Form",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_individualMultiChoiceQuestion_Question_QuestionID",
                table: "individualMultiChoiceQuestion",
                column: "QuestionID",
                principalTable: "Question",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Form_FormID",
                table: "Question",
                column: "FormID",
                principalTable: "Form",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_individualMultiChoiceQuestion_Question_QuestionID",
                table: "individualMultiChoiceQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Form_FormID",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Form",
                table: "Form");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "Form",
                newName: "Forms");

            migrationBuilder.RenameIndex(
                name: "IX_Question_FormID",
                table: "Questions",
                newName: "IX_Questions_FormID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Forms",
                table: "Forms",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_individualMultiChoiceQuestion_Questions_QuestionID",
                table: "individualMultiChoiceQuestion",
                column: "QuestionID",
                principalTable: "Questions",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Forms_FormID",
                table: "Questions",
                column: "FormID",
                principalTable: "Forms",
                principalColumn: "ID");
        }
    }
}
