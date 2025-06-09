using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SerwisTelefonow.Migrations
{
    /// <inheritdoc />
    public partial class AddedMissingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "imei",
                table: "wpis_serwisowy",
                type: "character varying(17)",
                maxLength: 17,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "imei",
                table: "wpis_serwisowy",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(17)",
                oldMaxLength: 17,
                oldNullable: true);
        }
    }
}
