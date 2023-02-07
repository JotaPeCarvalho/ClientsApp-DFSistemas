using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientApp.Migrations
{
    /// <inheritdoc />
    public partial class ModelandoTabelasNovamenteParaTeste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMidias_Clients_ClientId",
                table: "SocialMidias");

            migrationBuilder.DropIndex(
                name: "IX_SocialMidias_ClientId",
                table: "SocialMidias");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "SocialMidias");

            migrationBuilder.AddColumn<int>(
                name: "SocialMidiaId",
                table: "Clients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_SocialMidiaId",
                table: "Clients",
                column: "SocialMidiaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_SocialMidias_SocialMidiaId",
                table: "Clients",
                column: "SocialMidiaId",
                principalTable: "SocialMidias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_SocialMidias_SocialMidiaId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_SocialMidiaId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "SocialMidiaId",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "SocialMidias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SocialMidias_ClientId",
                table: "SocialMidias",
                column: "ClientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMidias_Clients_ClientId",
                table: "SocialMidias",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
