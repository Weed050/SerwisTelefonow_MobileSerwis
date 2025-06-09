using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SerwisTelefonow.Migrations
{
    /// <inheritdoc />
    public partial class AddingMorePhoneModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "model_kod",
                columns: new[] { "kod_modelu", "marka", "pelna_nazwa" },
                values: new object[,]
                {
                    { "IP12", "Apple", "iPhone 12" },
                    { "IP13", "Apple", "iPhone 13" },
                    { "IP14PRO", "Apple", "iPhone 14 Pro" },
                    { "SM-G991B", "Samsung", "Samsung Galaxy S21" },
                    { "SM-G996B", "Samsung", "Samsung Galaxy S21+" },
                    { "SM-G998B", "Samsung", "Samsung Galaxy S21 Ultra" },
                    { "MOTOE7", "Motorola", "Moto E7" },
                    { "MOTOE7PLUS", "Motorola", "Moto E7 Plus" },
                    { "ONEPLUS9", "OnePlus", "OnePlus 9" },
                    { "ONEPLUS9PRO", "OnePlus", "OnePlus 9 Pro" },
                    { "P40", "Huawei", "Huawei P40" },
                    { "P40PRO", "Huawei", "Huawei P40 Pro" },
                    { "NORD2", "OnePlus", "OnePlus Nord 2" },
                    { "REDMI9", "Xiaomi", "Redmi 9" },
                    { "REDMI9A", "Xiaomi", "Redmi 9A" },
                    { "REDMI10", "Xiaomi", "Redmi 10" },
                    { "SM-A127F", "Samsung", "Samsung Galaxy A12" },
                    { "SM-A725F", "Samsung", "Samsung Galaxy A72" },
                    { "SM-M127F", "Samsung", "Samsung Galaxy M12" },
                    { "IP11", "Apple", "iPhone 11" },
                    { "IPSE", "Apple", "iPhone SE (2020)" },
                    { "SM-F916B", "Samsung", "Samsung Galaxy Z Fold 3" },
                    { "SM-F711B", "Samsung", "Samsung Galaxy Z Flip 3" },
                    { "MI11LITE", "Xiaomi", "Xiaomi Mi 11 Lite" },
                    { "MI11ULTRA", "Xiaomi", "Xiaomi Mi 11 Ultra" },
                    { "PIXEL6", "Google", "Google Pixel 6" },
                    { "PIXEL6PRO", "Google", "Google Pixel 6 Pro" },
                    { "MOTOG9", "Motorola", "Moto G9 Power" },
                    { "MOTOG100", "Motorola", "Moto G100" },
                    { "P30", "Huawei", "Huawei P30" },
                    { "P30PRO", "Huawei", "Huawei P30 Pro" },
                    { "SM-G780F", "Samsung", "Samsung Galaxy S20 FE" },
                    { "SM-G781B", "Samsung", "Samsung Galaxy S20 FE 5G" },
                    { "NOKIA7PLUS", "Nokia", "Nokia 7 Plus" },
                    { "NOKIA5", "Nokia", "Nokia 5.4" },
                    { "NOKIA3", "Nokia", "Nokia 3.4" },
                    { "IPXR", "Apple", "iPhone XR" },
                    { "IPXS", "Apple", "iPhone XS" },
                    { "IPXSMAX", "Apple", "iPhone XS Max" },
                    { "SM-A025F", "Samsung", "Samsung Galaxy A02" },
                    { "SM-A032F", "Samsung", "Samsung Galaxy A03" },
                    { "SM-A515F", "Samsung", "Samsung Galaxy A51" },
                    { "REDMINOTE8", "Xiaomi", "Redmi Note 8" }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
