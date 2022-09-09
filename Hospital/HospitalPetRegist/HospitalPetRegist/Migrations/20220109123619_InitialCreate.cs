using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalPetRegist.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HospitalAPIs",
                columns: table => new
                {
                    NumberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OwnersName = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    OwnersLastname = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    PetsName = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    Services = table.Column<string>(type: "nvarchar(15)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalAPIs", x => x.NumberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospitalAPIs");
        }
    }
}
