using Microsoft.EntityFrameworkCore.Migrations;

namespace KieuVanThang341.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KVT341",
                columns: table => new
                {
                    PersonId = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KVT341", x => x.PersonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KVT341");
        }
    }
}
