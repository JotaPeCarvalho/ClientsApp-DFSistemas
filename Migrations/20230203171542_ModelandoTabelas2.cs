using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientApp.Migrations
{
    /// <inheritdoc />
    public partial class ModelandoTabelas2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RedesSociais_Clientes_ClientId",
                table: "RedesSociais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RedesSociais",
                table: "RedesSociais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Telefones",
                newName: "Phones");

            migrationBuilder.RenameTable(
                name: "RedesSociais",
                newName: "SocialMidias");

            migrationBuilder.RenameTable(
                name: "Enderecos",
                newName: "Adresses");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Clients");

            migrationBuilder.RenameIndex(
                name: "IX_RedesSociais_ClientId",
                table: "SocialMidias",
                newName: "IX_SocialMidias_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phones",
                table: "Phones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SocialMidias",
                table: "SocialMidias",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adresses",
                table: "Adresses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMidias_Clients_ClientId",
                table: "SocialMidias",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMidias_Clients_ClientId",
                table: "SocialMidias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SocialMidias",
                table: "SocialMidias");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phones",
                table: "Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adresses",
                table: "Adresses");

            migrationBuilder.RenameTable(
                name: "SocialMidias",
                newName: "RedesSociais");

            migrationBuilder.RenameTable(
                name: "Phones",
                newName: "Telefones");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "Adresses",
                newName: "Enderecos");

            migrationBuilder.RenameIndex(
                name: "IX_SocialMidias_ClientId",
                table: "RedesSociais",
                newName: "IX_RedesSociais_ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RedesSociais",
                table: "RedesSociais",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RedesSociais_Clientes_ClientId",
                table: "RedesSociais",
                column: "ClientId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
