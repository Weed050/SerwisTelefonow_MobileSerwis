using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SerwisTelefonow.Migrations
{
    /// <inheritdoc />
    public partial class simpleSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "klient",
                columns: new[] { "id", "imie", "nazwisko", "telefon" },
                values: new object[,]
                {
                    { 1, "Adrian", "Kowalczyk", "123123123" },
                    { 2, "Kondrat", "Kwaśniak", "415617154" },
                    { 3, "Karol", "Marek", "918472948" }
                });

            migrationBuilder.InsertData(
                table: "model_kod",
                columns: new[] { "kod_modelu", "marka", "pelna_nazwa" },
                values: new object[,]
                {
                    { "MI12PRO", "Xiaomi", "Xiaomi 12 Pro" },
                    { "PIXEL7P", "Google", "Google Pixel 7 Pro" },
                    { "REDMIN10", "Xiaomi", "Redmi Note 10" },
                    { "SM-A525F", "Samsung", "Samsung Galaxy A52" }
                });

            migrationBuilder.InsertData(
                table: "wpis_serwisowy",
                columns: new[] { "id", "cena_koncowa", "cena_wstepna", "imei", "klient_id", "kod_modelu", "opis" },
                values: new object[,]
                {
                    { 1, null, 50m, "123456789012345", 1, "PIXEL7P", "Telefon się nie włącza, możliwe zalanie cieczą." },
                    { 2, 600m, 550m, "123456789012345", 1, "MI12PRO", "Rozbity ekran" },
                    { 3, null, 35m, "123461719012345", 2, "REDMIN10", "Telefon się nie włącza, oraz nie reaguje na podpięcie do ładowarki." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "klient",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "model_kod",
                keyColumn: "kod_modelu",
                keyValue: "SM-A525F");

            migrationBuilder.DeleteData(
                table: "wpis_serwisowy",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "wpis_serwisowy",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "wpis_serwisowy",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "klient",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "klient",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "model_kod",
                keyColumn: "kod_modelu",
                keyValue: "MI12PRO");

            migrationBuilder.DeleteData(
                table: "model_kod",
                keyColumn: "kod_modelu",
                keyValue: "PIXEL7P");

            migrationBuilder.DeleteData(
                table: "model_kod",
                keyColumn: "kod_modelu",
                keyValue: "REDMIN10");
        }
    }
}
