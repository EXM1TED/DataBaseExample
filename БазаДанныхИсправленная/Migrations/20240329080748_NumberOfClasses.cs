using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace БазаДанныхИсправленная.Migrations
{
    /// <inheritdoc />
    public partial class NumberOfClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Number_of_class_id",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NumberOfClasses",
                columns: table => new
                {
                    Id_Number_Class = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number_of_class = table.Column<int>(type: "INTEGER", nullable: false),
                    Id_Of_Tasks = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumberOfClasses", x => x.Id_Number_Class);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NumberOfClasses");

            migrationBuilder.DropColumn(
                name: "Number_of_class_id",
                table: "Users");
        }
    }
}
