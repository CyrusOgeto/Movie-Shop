using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviePlace.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receipt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MGenre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MTrailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoldCopies = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipt", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receipt");
        }
    }
}
