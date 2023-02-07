using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientApp.Migrations
{
    /// <inheritdoc />
    public partial class TestandoNovoBd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Adresses_AdressId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Phones_PhoneId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_AdressId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_PhoneId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "PhoneId",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Phones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Adresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Phones_ClientId",
                table: "Phones",
                column: "ClientId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_ClientId",
                table: "Adresses",
                column: "ClientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Clients_ClientId",
                table: "Adresses",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Clients_ClientId",
                table: "Phones",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Clients_ClientId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Clients_ClientId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Phones_ClientId",
                table: "Phones");

            migrationBuilder.DropIndex(
                name: "IX_Adresses_ClientId",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Phones");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Adresses");

            migrationBuilder.AddColumn<int>(
                name: "AdressId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhoneId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AdressId",
                table: "Clients",
                column: "AdressId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_PhoneId",
                table: "Clients",
                column: "PhoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Adresses_AdressId",
                table: "Clients",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Phones_PhoneId",
                table: "Clients",
                column: "PhoneId",
                principalTable: "Phones",
                principalColumn: "Id");
        }
    }
}
