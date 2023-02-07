using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientApp.Migrations
{
    /// <inheritdoc />
    public partial class CriandoRelacionamentoEntreClienteTelefoneEClienteEndereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
