using Microsoft.EntityFrameworkCore.Migrations;

namespace DziennikMVC.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wiadomosc_AspNetUsers_KontoId",
                table: "Wiadomosc");

            migrationBuilder.DropForeignKey(
                name: "FK_Wiadomosc_AspNetUsers_KontoId1",
                table: "Wiadomosc");

            migrationBuilder.DropIndex(
                name: "IX_Wiadomosc_KontoId",
                table: "Wiadomosc");

            migrationBuilder.DropIndex(
                name: "IX_Wiadomosc_KontoId1",
                table: "Wiadomosc");

            migrationBuilder.DropColumn(
                name: "KontoId",
                table: "Wiadomosc");

            migrationBuilder.DropColumn(
                name: "KontoId1",
                table: "Wiadomosc");

            migrationBuilder.AlterColumn<string>(
                name: "OdbiorcaId",
                table: "Wiadomosc",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NadawcaId",
                table: "Wiadomosc",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wiadomosc_NadawcaId",
                table: "Wiadomosc",
                column: "NadawcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Wiadomosc_OdbiorcaId",
                table: "Wiadomosc",
                column: "OdbiorcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wiadomosc_AspNetUsers_NadawcaId",
                table: "Wiadomosc",
                column: "NadawcaId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Wiadomosc_AspNetUsers_OdbiorcaId",
                table: "Wiadomosc",
                column: "OdbiorcaId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wiadomosc_AspNetUsers_NadawcaId",
                table: "Wiadomosc");

            migrationBuilder.DropForeignKey(
                name: "FK_Wiadomosc_AspNetUsers_OdbiorcaId",
                table: "Wiadomosc");

            migrationBuilder.DropIndex(
                name: "IX_Wiadomosc_NadawcaId",
                table: "Wiadomosc");

            migrationBuilder.DropIndex(
                name: "IX_Wiadomosc_OdbiorcaId",
                table: "Wiadomosc");

            migrationBuilder.AlterColumn<string>(
                name: "OdbiorcaId",
                table: "Wiadomosc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NadawcaId",
                table: "Wiadomosc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KontoId",
                table: "Wiadomosc",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KontoId1",
                table: "Wiadomosc",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wiadomosc_KontoId",
                table: "Wiadomosc",
                column: "KontoId");

            migrationBuilder.CreateIndex(
                name: "IX_Wiadomosc_KontoId1",
                table: "Wiadomosc",
                column: "KontoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Wiadomosc_AspNetUsers_KontoId",
                table: "Wiadomosc",
                column: "KontoId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wiadomosc_AspNetUsers_KontoId1",
                table: "Wiadomosc",
                column: "KontoId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
