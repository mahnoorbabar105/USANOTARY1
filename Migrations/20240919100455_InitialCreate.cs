using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace USANotary.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotaryPublics");

            migrationBuilder.CreateTable(
                name: "JobData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KBA = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyAddres1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyAddres2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PropertyZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobData", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobData");

            migrationBuilder.CreateTable(
                name: "NotaryPublics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClosingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternalReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KBA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyAddres1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyAddres2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyState = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaryPublics", x => x.Id);
                });
        }
    }
}
