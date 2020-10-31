using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace BudgetTool.UI.Migrations
{
    public partial class AddedBudgetModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Income",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NetIncome = table.Column<float>(nullable: false),
                    StudyGrant = table.Column<float>(nullable: false),
                    StudentLoan = table.Column<float>(nullable: false),
                    HousingAllowance = table.Column<float>(nullable: false),
                    UnemploymentBenefit = table.Column<float>(nullable: false),
                    OtherBenefits = table.Column<float>(nullable: false),
                    OtherIncomes = table.Column<float>(nullable: false),
                    TotalIncomes = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Income", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceAndMonthlyCost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceAndMonthlyCost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LivingCost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivingCost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoansAndSavingsCost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoansAndSavingsCost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravellingCost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravellingCost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VariableCost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FoodAndDailyEquipments = table.Column<float>(nullable: false),
                    DoctorAndMedicines = table.Column<float>(nullable: false),
                    Clothing = table.Column<float>(nullable: false),
                    Freetime = table.Column<float>(nullable: false),
                    FurnitureAndDecoration = table.Column<float>(nullable: false),
                    Vacation = table.Column<float>(nullable: false),
                    OtherVariableCosts = table.Column<float>(nullable: false),
                    TotalVariableCosts = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VariableCost", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FixedCost",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    LivingCostsId = table.Column<int>(nullable: true),
                    InsuranceAndMonthlyCostsId = table.Column<int>(nullable: true),
                    TravellingCostsId = table.Column<int>(nullable: true),
                    LoansAndSavingsCostsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixedCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FixedCost_InsuranceAndMonthlyCost_InsuranceAndMonthlyCostsId",
                        column: x => x.InsuranceAndMonthlyCostsId,
                        principalTable: "InsuranceAndMonthlyCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FixedCost_LivingCost_LivingCostsId",
                        column: x => x.LivingCostsId,
                        principalTable: "LivingCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FixedCost_LoansAndSavingsCost_LoansAndSavingsCostsId",
                        column: x => x.LoansAndSavingsCostsId,
                        principalTable: "LoansAndSavingsCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FixedCost_TravellingCost_TravellingCostsId",
                        column: x => x.TravellingCostsId,
                        principalTable: "TravellingCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BudgetModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IncomesId = table.Column<int>(nullable: true),
                    FixedCostsId = table.Column<int>(nullable: true),
                    VariableCostsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BudgetModels_FixedCost_FixedCostsId",
                        column: x => x.FixedCostsId,
                        principalTable: "FixedCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BudgetModels_Income_IncomesId",
                        column: x => x.IncomesId,
                        principalTable: "Income",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BudgetModels_VariableCost_VariableCostsId",
                        column: x => x.VariableCostsId,
                        principalTable: "VariableCost",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BudgetModels_FixedCostsId",
                table: "BudgetModels",
                column: "FixedCostsId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetModels_IncomesId",
                table: "BudgetModels",
                column: "IncomesId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetModels_VariableCostsId",
                table: "BudgetModels",
                column: "VariableCostsId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedCost_InsuranceAndMonthlyCostsId",
                table: "FixedCost",
                column: "InsuranceAndMonthlyCostsId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedCost_LivingCostsId",
                table: "FixedCost",
                column: "LivingCostsId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedCost_LoansAndSavingsCostsId",
                table: "FixedCost",
                column: "LoansAndSavingsCostsId");

            migrationBuilder.CreateIndex(
                name: "IX_FixedCost_TravellingCostsId",
                table: "FixedCost",
                column: "TravellingCostsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BudgetModels");

            migrationBuilder.DropTable(
                name: "FixedCost");

            migrationBuilder.DropTable(
                name: "Income");

            migrationBuilder.DropTable(
                name: "VariableCost");

            migrationBuilder.DropTable(
                name: "InsuranceAndMonthlyCost");

            migrationBuilder.DropTable(
                name: "LivingCost");

            migrationBuilder.DropTable(
                name: "LoansAndSavingsCost");

            migrationBuilder.DropTable(
                name: "TravellingCost");
        }
    }
}
