using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlogDemo.Migrations
{
    public partial class v1014 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationRegistro",
                table: "ApplicationRegistro");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ApplicationRegistro",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationRegistro",
                table: "ApplicationRegistro",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationRegistro",
                table: "ApplicationRegistro");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ApplicationRegistro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationRegistro",
                table: "ApplicationRegistro",
                column: "Email");
        }
    }
}
