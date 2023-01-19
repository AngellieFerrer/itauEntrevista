using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogDemo.Migrations
{
    public partial class v106 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Blog",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Fecha",
                table: "Blog",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Contenido",
                table: "Blog",
                maxLength: 5000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "EmailUser",
                table: "Blog",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailUser",
                table: "Blog");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Blog",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Fecha",
                table: "Blog",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Contenido",
                table: "Blog",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 5000);
        }
    }
}
