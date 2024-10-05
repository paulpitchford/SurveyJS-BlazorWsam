using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SurveyBlazor.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSurveyStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SurveyStructure",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyStructure",
                table: "SurveyResults");
        }
    }
}
