using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppEntitys.Migrations
{
    /// <inheritdoc />
    public partial class m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerTable",
                columns: table => new
                {
                    CustomersInformationClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTable", x => x.CustomersInformationClassId);
                });

            migrationBuilder.CreateTable(
                name: "HeavyVehiclesTable",
                columns: table => new
                {
                    HeavyVehiclesClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarsDateModel = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarsBuyPriceForUs = table.Column<double>(type: "float", nullable: false),
                    CarsSellPrice = table.Column<double>(type: "float", nullable: false),
                    CarsRentPrice = table.Column<double>(type: "float", nullable: false),
                    CarsCondition = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeavyVehiclesTable", x => x.HeavyVehiclesClassId);
                });

            migrationBuilder.CreateTable(
                name: "lightCarsTable",
                columns: table => new
                {
                    LightCarsClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarsDateModel = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarsBuyPriceForUs = table.Column<double>(type: "float", nullable: false),
                    CarsSellPrice = table.Column<double>(type: "float", nullable: false),
                    CarsRentPrice = table.Column<double>(type: "float", nullable: false),
                    CarsCondition = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lightCarsTable", x => x.LightCarsClassId);
                });

            migrationBuilder.CreateTable(
                name: "heavyVehicleRentalReportTable",
                columns: table => new
                {
                    HeavyVehicleRentalReportClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReciveTheCarDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RentPrice = table.Column<double>(type: "float", nullable: false),
                    HeavyVehiclesClassId = table.Column<int>(type: "int", nullable: false),
                    CustomersInformationClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_heavyVehicleRentalReportTable", x => x.HeavyVehicleRentalReportClassId);
                    table.ForeignKey(
                        name: "FK_heavyVehicleRentalReportTable_CustomerTable_CustomersInformationClassId",
                        column: x => x.CustomersInformationClassId,
                        principalTable: "CustomerTable",
                        principalColumn: "CustomersInformationClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_heavyVehicleRentalReportTable_HeavyVehiclesTable_HeavyVehiclesClassId",
                        column: x => x.HeavyVehiclesClassId,
                        principalTable: "HeavyVehiclesTable",
                        principalColumn: "HeavyVehiclesClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "heavyVehicleSalesTable",
                columns: table => new
                {
                    HeavyVehicleSalesReportClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomersInformationClassId = table.Column<int>(type: "int", nullable: false),
                    vehicleClassHeavyVehiclesClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_heavyVehicleSalesTable", x => x.HeavyVehicleSalesReportClassId);
                    table.ForeignKey(
                        name: "FK_heavyVehicleSalesTable_CustomerTable_CustomersInformationClassId",
                        column: x => x.CustomersInformationClassId,
                        principalTable: "CustomerTable",
                        principalColumn: "CustomersInformationClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_heavyVehicleSalesTable_HeavyVehiclesTable_vehicleClassHeavyVehiclesClassId",
                        column: x => x.vehicleClassHeavyVehiclesClassId,
                        principalTable: "HeavyVehiclesTable",
                        principalColumn: "HeavyVehiclesClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "lightCarRentalsTable",
                columns: table => new
                {
                    LightCarRentalReportClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReciveTheCarDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RentPrice = table.Column<double>(type: "float", nullable: false),
                    CustomersInformationClassId = table.Column<int>(type: "int", nullable: false),
                    LightCarsClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lightCarRentalsTable", x => x.LightCarRentalReportClassId);
                    table.ForeignKey(
                        name: "FK_lightCarRentalsTable_CustomerTable_CustomersInformationClassId",
                        column: x => x.CustomersInformationClassId,
                        principalTable: "CustomerTable",
                        principalColumn: "CustomersInformationClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_lightCarRentalsTable_lightCarsTable_LightCarsClassId",
                        column: x => x.LightCarsClassId,
                        principalTable: "lightCarsTable",
                        principalColumn: "LightCarsClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LightCarSalesTable",
                columns: table => new
                {
                    LightCarSalesReportClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomersInformationClassId = table.Column<int>(type: "int", nullable: false),
                    LightCarsClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LightCarSalesTable", x => x.LightCarSalesReportClassId);
                    table.ForeignKey(
                        name: "FK_LightCarSalesTable_CustomerTable_CustomersInformationClassId",
                        column: x => x.CustomersInformationClassId,
                        principalTable: "CustomerTable",
                        principalColumn: "CustomersInformationClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LightCarSalesTable_lightCarsTable_LightCarsClassId",
                        column: x => x.LightCarsClassId,
                        principalTable: "lightCarsTable",
                        principalColumn: "LightCarsClassId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_heavyVehicleRentalReportTable_CustomersInformationClassId",
                table: "heavyVehicleRentalReportTable",
                column: "CustomersInformationClassId");

            migrationBuilder.CreateIndex(
                name: "IX_heavyVehicleRentalReportTable_HeavyVehiclesClassId",
                table: "heavyVehicleRentalReportTable",
                column: "HeavyVehiclesClassId");

            migrationBuilder.CreateIndex(
                name: "IX_heavyVehicleSalesTable_CustomersInformationClassId",
                table: "heavyVehicleSalesTable",
                column: "CustomersInformationClassId");

            migrationBuilder.CreateIndex(
                name: "IX_heavyVehicleSalesTable_vehicleClassHeavyVehiclesClassId",
                table: "heavyVehicleSalesTable",
                column: "vehicleClassHeavyVehiclesClassId");

            migrationBuilder.CreateIndex(
                name: "IX_lightCarRentalsTable_CustomersInformationClassId",
                table: "lightCarRentalsTable",
                column: "CustomersInformationClassId");

            migrationBuilder.CreateIndex(
                name: "IX_lightCarRentalsTable_LightCarsClassId",
                table: "lightCarRentalsTable",
                column: "LightCarsClassId");

            migrationBuilder.CreateIndex(
                name: "IX_LightCarSalesTable_CustomersInformationClassId",
                table: "LightCarSalesTable",
                column: "CustomersInformationClassId");

            migrationBuilder.CreateIndex(
                name: "IX_LightCarSalesTable_LightCarsClassId",
                table: "LightCarSalesTable",
                column: "LightCarsClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "heavyVehicleRentalReportTable");

            migrationBuilder.DropTable(
                name: "heavyVehicleSalesTable");

            migrationBuilder.DropTable(
                name: "lightCarRentalsTable");

            migrationBuilder.DropTable(
                name: "LightCarSalesTable");

            migrationBuilder.DropTable(
                name: "HeavyVehiclesTable");

            migrationBuilder.DropTable(
                name: "CustomerTable");

            migrationBuilder.DropTable(
                name: "lightCarsTable");
        }
    }
}
