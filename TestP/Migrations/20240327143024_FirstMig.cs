using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestP.Migrations
{
    /// <inheritdoc />
    public partial class FirstMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarsDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlateNumber = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Marke = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    OwnerName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    OwnerContactInfo = table.Column<string>(type: "nvarchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarsDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarsDetails");
        }
    }
}
