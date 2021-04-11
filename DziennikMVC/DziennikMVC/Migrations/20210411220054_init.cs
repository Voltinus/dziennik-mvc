using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DziennikMVC.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Klasa",
                columns: table => new
                {
                    KlasaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(nullable: true),
                    NauczycielId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klasa", x => x.KlasaId);
                });

            migrationBuilder.CreateTable(
                name: "Nauczyciel",
                columns: table => new
                {
                    NauczycielId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KontoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nauczyciel", x => x.NauczycielId);
                });

            migrationBuilder.CreateTable(
                name: "Przedmiot",
                columns: table => new
                {
                    PrzedmiotId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(nullable: true),
                    dziedzina = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przedmiot", x => x.PrzedmiotId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uczen",
                columns: table => new
                {
                    UczenId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KlasaId = table.Column<int>(nullable: false),
                    KontoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uczen", x => x.UczenId);
                    table.ForeignKey(
                        name: "FK_Uczen_Klasa_KlasaId",
                        column: x => x.KlasaId,
                        principalTable: "Klasa",
                        principalColumn: "KlasaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nauczanie",
                columns: table => new
                {
                    NauczanieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrzedmiotId = table.Column<int>(nullable: false),
                    NauczycielId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nauczanie", x => x.NauczanieId);
                    table.ForeignKey(
                        name: "FK_Nauczanie_Nauczyciel_NauczycielId",
                        column: x => x.NauczycielId,
                        principalTable: "Nauczyciel",
                        principalColumn: "NauczycielId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nauczanie_Przedmiot_PrzedmiotId",
                        column: x => x.PrzedmiotId,
                        principalTable: "Przedmiot",
                        principalColumn: "PrzedmiotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wydarzenie",
                columns: table => new
                {
                    WydarzenieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nazwa = table.Column<string>(nullable: true),
                    opis = table.Column<string>(nullable: true),
                    data = table.Column<DateTimeOffset>(nullable: false),
                    KlasaId = table.Column<int>(nullable: false),
                    NauczycielId = table.Column<int>(nullable: true),
                    PrzedmiotId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wydarzenie", x => x.WydarzenieId);
                    table.ForeignKey(
                        name: "FK_Wydarzenie_Klasa_KlasaId",
                        column: x => x.KlasaId,
                        principalTable: "Klasa",
                        principalColumn: "KlasaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wydarzenie_Nauczyciel_NauczycielId",
                        column: x => x.NauczycielId,
                        principalTable: "Nauczyciel",
                        principalColumn: "NauczycielId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wydarzenie_Przedmiot_PrzedmiotId",
                        column: x => x.PrzedmiotId,
                        principalTable: "Przedmiot",
                        principalColumn: "PrzedmiotId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    imie = table.Column<string>(nullable: true),
                    nazwisko = table.Column<string>(nullable: true),
                    adres = table.Column<string>(nullable: true),
                    pesel = table.Column<string>(nullable: true),
                    NauczycielId = table.Column<int>(nullable: true),
                    UczenId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Nauczyciel_NauczycielId",
                        column: x => x.NauczycielId,
                        principalTable: "Nauczyciel",
                        principalColumn: "NauczycielId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Uczen_UczenId",
                        column: x => x.UczenId,
                        principalTable: "Uczen",
                        principalColumn: "UczenId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ocena",
                columns: table => new
                {
                    OcenaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ocena = table.Column<string>(nullable: true),
                    opis_oceny = table.Column<string>(nullable: true),
                    czy_koncowa = table.Column<int>(nullable: false),
                    data = table.Column<DateTimeOffset>(nullable: false),
                    UczenId = table.Column<int>(nullable: false),
                    NauczycielId = table.Column<int>(nullable: false),
                    PrzedmiotId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocena", x => x.OcenaId);
                    table.ForeignKey(
                        name: "FK_Ocena_Nauczyciel_NauczycielId",
                        column: x => x.NauczycielId,
                        principalTable: "Nauczyciel",
                        principalColumn: "NauczycielId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocena_Przedmiot_PrzedmiotId",
                        column: x => x.PrzedmiotId,
                        principalTable: "Przedmiot",
                        principalColumn: "PrzedmiotId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ocena_Uczen_UczenId",
                        column: x => x.UczenId,
                        principalTable: "Uczen",
                        principalColumn: "UczenId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lekcja",
                columns: table => new
                {
                    LekcjaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTimeOffset>(nullable: false),
                    KlasaId = table.Column<int>(nullable: false),
                    NauczanieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lekcja", x => x.LekcjaId);
                    table.ForeignKey(
                        name: "FK_Lekcja_Klasa_KlasaId",
                        column: x => x.KlasaId,
                        principalTable: "Klasa",
                        principalColumn: "KlasaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lekcja_Nauczanie_NauczanieId",
                        column: x => x.NauczanieId,
                        principalTable: "Nauczanie",
                        principalColumn: "NauczanieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wiadomosc",
                columns: table => new
                {
                    WiadomoscId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tytul = table.Column<string>(nullable: true),
                    tresc = table.Column<string>(nullable: true),
                    data_wyslania = table.Column<DateTimeOffset>(nullable: false),
                    czy_odczytana = table.Column<int>(nullable: false),
                    NadawcaId = table.Column<string>(nullable: true),
                    OdbiorcaId = table.Column<string>(nullable: true),
                    KontoId = table.Column<string>(nullable: true),
                    KontoId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wiadomosc", x => x.WiadomoscId);
                    table.ForeignKey(
                        name: "FK_Wiadomosc_AspNetUsers_KontoId",
                        column: x => x.KontoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wiadomosc_AspNetUsers_KontoId1",
                        column: x => x.KontoId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Obecnosc",
                columns: table => new
                {
                    ObecnoscId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    obecnosc = table.Column<int>(nullable: false),
                    LekcjaId = table.Column<int>(nullable: true),
                    UczenId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obecnosc", x => x.ObecnoscId);
                    table.ForeignKey(
                        name: "FK_Obecnosc_Lekcja_LekcjaId",
                        column: x => x.LekcjaId,
                        principalTable: "Lekcja",
                        principalColumn: "LekcjaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Obecnosc_Uczen_UczenId",
                        column: x => x.UczenId,
                        principalTable: "Uczen",
                        principalColumn: "UczenId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NauczycielId",
                table: "AspNetUsers",
                column: "NauczycielId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UczenId",
                table: "AspNetUsers",
                column: "UczenId");

            migrationBuilder.CreateIndex(
                name: "IX_Lekcja_KlasaId",
                table: "Lekcja",
                column: "KlasaId");

            migrationBuilder.CreateIndex(
                name: "IX_Lekcja_NauczanieId",
                table: "Lekcja",
                column: "NauczanieId");

            migrationBuilder.CreateIndex(
                name: "IX_Nauczanie_NauczycielId",
                table: "Nauczanie",
                column: "NauczycielId");

            migrationBuilder.CreateIndex(
                name: "IX_Nauczanie_PrzedmiotId",
                table: "Nauczanie",
                column: "PrzedmiotId");

            migrationBuilder.CreateIndex(
                name: "IX_Obecnosc_LekcjaId",
                table: "Obecnosc",
                column: "LekcjaId");

            migrationBuilder.CreateIndex(
                name: "IX_Obecnosc_UczenId",
                table: "Obecnosc",
                column: "UczenId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocena_NauczycielId",
                table: "Ocena",
                column: "NauczycielId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocena_PrzedmiotId",
                table: "Ocena",
                column: "PrzedmiotId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocena_UczenId",
                table: "Ocena",
                column: "UczenId");

            migrationBuilder.CreateIndex(
                name: "IX_Uczen_KlasaId",
                table: "Uczen",
                column: "KlasaId");

            migrationBuilder.CreateIndex(
                name: "IX_Wiadomosc_KontoId",
                table: "Wiadomosc",
                column: "KontoId");

            migrationBuilder.CreateIndex(
                name: "IX_Wiadomosc_KontoId1",
                table: "Wiadomosc",
                column: "KontoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Wydarzenie_KlasaId",
                table: "Wydarzenie",
                column: "KlasaId");

            migrationBuilder.CreateIndex(
                name: "IX_Wydarzenie_NauczycielId",
                table: "Wydarzenie",
                column: "NauczycielId");

            migrationBuilder.CreateIndex(
                name: "IX_Wydarzenie_PrzedmiotId",
                table: "Wydarzenie",
                column: "PrzedmiotId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Obecnosc");

            migrationBuilder.DropTable(
                name: "Ocena");

            migrationBuilder.DropTable(
                name: "Wiadomosc");

            migrationBuilder.DropTable(
                name: "Wydarzenie");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Lekcja");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Nauczanie");

            migrationBuilder.DropTable(
                name: "Uczen");

            migrationBuilder.DropTable(
                name: "Nauczyciel");

            migrationBuilder.DropTable(
                name: "Przedmiot");

            migrationBuilder.DropTable(
                name: "Klasa");
        }
    }
}
