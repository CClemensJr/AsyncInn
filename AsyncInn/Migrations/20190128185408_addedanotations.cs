using Microsoft.EntityFrameworkCore.Migrations;

namespace AsyncInn.Migrations
{
    public partial class addedanotations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Hotels_HotelID",
                table: "HotelRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID1",
                table: "HotelRooms");

            migrationBuilder.DropIndex(
                name: "IX_HotelRooms_RoomID1",
                table: "HotelRooms");

            migrationBuilder.DropColumn(
                name: "RoomID1",
                table: "HotelRooms");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Hotels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotels",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Hotels",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoomID",
                table: "HotelRooms",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<int>(
                name: "HotelID1",
                table: "HotelRooms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_HotelID1",
                table: "HotelRooms",
                column: "HotelID1");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_RoomID",
                table: "HotelRooms",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Hotels_HotelID1",
                table: "HotelRooms",
                column: "HotelID1",
                principalTable: "Hotels",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID",
                table: "HotelRooms",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Hotels_HotelID1",
                table: "HotelRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID",
                table: "HotelRooms");

            migrationBuilder.DropIndex(
                name: "IX_HotelRooms_HotelID1",
                table: "HotelRooms");

            migrationBuilder.DropIndex(
                name: "IX_HotelRooms_RoomID",
                table: "HotelRooms");

            migrationBuilder.DropColumn(
                name: "HotelID1",
                table: "HotelRooms");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Hotels",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Hotels",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Hotels",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<decimal>(
                name: "RoomID",
                table: "HotelRooms",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "RoomID1",
                table: "HotelRooms",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Amenities",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 250);

            migrationBuilder.CreateIndex(
                name: "IX_HotelRooms_RoomID1",
                table: "HotelRooms",
                column: "RoomID1");

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Hotels_HotelID",
                table: "HotelRooms",
                column: "HotelID",
                principalTable: "Hotels",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Rooms_RoomID1",
                table: "HotelRooms",
                column: "RoomID1",
                principalTable: "Rooms",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
