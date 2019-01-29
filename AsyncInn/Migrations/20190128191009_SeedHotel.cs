using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class SeedHotel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "123 N 82nd Ave, Sporkland, MI 53401", "Hotel Landria", "555-555-5555" },
                    { 2, "124 N 94th Ave, Avertine, WA 98002", "Hotel Alfansa", "555-555-5555" },
                    { 3, "1 N 15th Ave, Phoenix, AZ 85307", "Hotel Valdabash", "555-555-5555" },
                    { 4, "12000 N 142nd St, Yorktown, VA 24501", "Hotel Flatlinaz", "555-555-5555" },
                    { 5, "456 S 78910 Ave, Beachtown, CA 24512", "Hotel Bizzle", "555-555-5555" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
