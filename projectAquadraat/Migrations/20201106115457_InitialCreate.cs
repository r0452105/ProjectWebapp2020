using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace projectAquadraat.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

         

            migrationBuilder.CreateTable(
                name: "Gebruiker",
                columns: table => new
                {
                    GebruikerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    Voornaam = table.Column<string>(nullable: true),
                    Nationaliteit = table.Column<string>(nullable: true),
                    Profielfoto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.GebruikerID);
                });

            migrationBuilder.CreateTable(
                name: "Nieuwsartikel",
                columns: table => new
                {
                    NieuwsartikelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titel = table.Column<string>(nullable: true),
                    KorteOmschrijving = table.Column<string>(nullable: true),
                    ArtikelTekst = table.Column<string>(nullable: true),
                    Artikelfoto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nieuwsartikel", x => x.NieuwsartikelID);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    RaceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    Finished = table.Column<bool>(nullable: false),
                    Startdatum = table.Column<DateTime>(nullable: false),
                    Aantalritten = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.RaceID);
                });

            migrationBuilder.CreateTable(
                name: "Ritsoort",
                columns: table => new
                {
                    RitsoortID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ritsoort", x => x.RitsoortID);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamID);
                });

          

            migrationBuilder.CreateTable(
                name: "Rit",
                columns: table => new
                {
                    RitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Afstand = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Profielfoto = table.Column<string>(nullable: true),
                    RitsoortID = table.Column<int>(nullable: false),
                    RaceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rit", x => x.RitID);
                    table.ForeignKey(
                        name: "FK_Rit_Race_RaceID",
                        column: x => x.RaceID,
                        principalTable: "Race",
                        principalColumn: "RaceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rit_Ritsoort_RitsoortID",
                        column: x => x.RitsoortID,
                        principalTable: "Ritsoort",
                        principalColumn: "RitsoortID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GebruikerTeam",
                columns: table => new
                {
                    GebruikerTeamID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamID = table.Column<int>(nullable: false),
                    GebruikerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GebruikerTeam", x => x.GebruikerTeamID);
                    table.ForeignKey(
                        name: "FK_GebruikerTeam_Gebruiker_GebruikerID",
                        column: x => x.GebruikerID,
                        principalTable: "Gebruiker",
                        principalColumn: "GebruikerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GebruikerTeam_Team_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Team",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RaceTeam",
                columns: table => new
                {
                    RaceTeamID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamID = table.Column<int>(nullable: false),
                    RaceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceTeam", x => x.RaceTeamID);
                    table.ForeignKey(
                        name: "FK_RaceTeam_Race_RaceID",
                        column: x => x.RaceID,
                        principalTable: "Race",
                        principalColumn: "RaceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceTeam_Team_TeamID",
                        column: x => x.TeamID,
                        principalTable: "Team",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Uitslag",
                columns: table => new
                {
                    UitslagID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Puntenklassement = table.Column<int>(nullable: false),
                    Bergklassement = table.Column<int>(nullable: false),
                    Strijdlustklassement = table.Column<int>(nullable: false),
                    Algemeenklassement = table.Column<TimeSpan>(nullable: false),
                    RitID = table.Column<int>(nullable: false),
                    GebruikerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uitslag", x => x.UitslagID);
                    table.ForeignKey(
                        name: "FK_Uitslag_Gebruiker_GebruikerID",
                        column: x => x.GebruikerID,
                        principalTable: "Gebruiker",
                        principalColumn: "GebruikerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uitslag_Rit_RitID",
                        column: x => x.RitID,
                        principalTable: "Rit",
                        principalColumn: "RitID",
                        onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.CreateIndex(
                name: "IX_GebruikerTeam_GebruikerID",
                table: "GebruikerTeam",
                column: "GebruikerID");

            migrationBuilder.CreateIndex(
                name: "IX_GebruikerTeam_TeamID",
                table: "GebruikerTeam",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_RaceTeam_RaceID",
                table: "RaceTeam",
                column: "RaceID");

            migrationBuilder.CreateIndex(
                name: "IX_RaceTeam_TeamID",
                table: "RaceTeam",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Rit_RaceID",
                table: "Rit",
                column: "RaceID");

            migrationBuilder.CreateIndex(
                name: "IX_Rit_RitsoortID",
                table: "Rit",
                column: "RitsoortID");

            migrationBuilder.CreateIndex(
                name: "IX_Uitslag_GebruikerID",
                table: "Uitslag",
                column: "GebruikerID");

            migrationBuilder.CreateIndex(
                name: "IX_Uitslag_RitID",
                table: "Uitslag",
                column: "RitID");
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
                name: "GebruikerTeam");

            migrationBuilder.DropTable(
                name: "Nieuwsartikel");

            migrationBuilder.DropTable(
                name: "RaceTeam");

            migrationBuilder.DropTable(
                name: "Uitslag");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Gebruiker");

            migrationBuilder.DropTable(
                name: "Rit");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "Ritsoort");
        }
    }
}
