using Microsoft.EntityFrameworkCore.Migrations;

namespace InfoApp.API.Migrations
{
    public partial class ShipmentAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Shipment_type = table.Column<string>(nullable: true),
                    L = table.Column<int>(nullable: false),
                    B = table.Column<int>(nullable: false),
                    H = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Delivery_option = table.Column<string>(nullable: true),
                    Pickup_address = table.Column<string>(nullable: true),
                    Building_no = table.Column<int>(nullable: false),
                    Street_no = table.Column<int>(nullable: false),
                    Locality = table.Column<string>(nullable: true),
                    Pin_code = table.Column<int>(nullable: false),
                    Contact_no = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shipments");
        }
    }
}
