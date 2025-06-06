using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SerwisTelefonow.Migrations
{
    /// <inheritdoc />
    public partial class InitDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "klient",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    imie = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    nazwisko = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    telefon = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_klient", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "model_kod",
                columns: table => new
                {
                    kod_modelu = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    marka = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    pelna_nazwa = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_model_kod", x => x.kod_modelu);
                });

            migrationBuilder.CreateTable(
                name: "wpis_serwisowy",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    klient_id = table.Column<int>(type: "integer", nullable: false),
                    kod_modelu = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    imei = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    opis = table.Column<string>(type: "text", nullable: true),
                    cena_wstepna = table.Column<decimal>(type: "numeric", nullable: true),
                    cena_koncowa = table.Column<decimal>(type: "numeric", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wpis_serwisowy", x => x.id);
                    table.ForeignKey(
                        name: "FK_wpis_serwisowy_klient_klient_id",
                        column: x => x.klient_id,
                        principalTable: "klient",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_wpis_serwisowy_model_kod_kod_modelu",
                        column: x => x.kod_modelu,
                        principalTable: "model_kod",
                        principalColumn: "kod_modelu",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_wpis_serwisowy_klient_id",
                table: "wpis_serwisowy",
                column: "klient_id");

            migrationBuilder.CreateIndex(
                name: "IX_wpis_serwisowy_kod_modelu",
                table: "wpis_serwisowy",
                column: "kod_modelu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wpis_serwisowy");

            migrationBuilder.DropTable(
                name: "klient");

            migrationBuilder.DropTable(
                name: "model_kod");
        }
    }
}
