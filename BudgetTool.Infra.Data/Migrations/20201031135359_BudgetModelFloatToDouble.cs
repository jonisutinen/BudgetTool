using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetTool.UI.Migrations
{
    public partial class BudgetModelFloatToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Vacation",
                table: "VariableCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "TotalVariableCosts",
                table: "VariableCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "OtherVariableCosts",
                table: "VariableCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "FurnitureAndDecoration",
                table: "VariableCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Freetime",
                table: "VariableCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "FoodAndDailyEquipments",
                table: "VariableCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "DoctorAndMedicines",
                table: "VariableCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Clothing",
                table: "VariableCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "TravellingCostsTotal",
                table: "TravellingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "TrafficAndVehiceTax",
                table: "TravellingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "PublicTransport",
                table: "TravellingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "OtherTravellingCosts",
                table: "TravellingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Fuel",
                table: "TravellingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "CarAndMotorcycleRepair",
                table: "TravellingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "CarAndMotorcycleInsurance",
                table: "TravellingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "UsageLoan",
                table: "LoansAndSavingsCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "TotalLoansAndSavings",
                table: "LoansAndSavingsCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "StudentLoan",
                table: "LoansAndSavingsCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "RetirementSaving",
                table: "LoansAndSavingsCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "OtherLoansAndSavings",
                table: "LoansAndSavingsCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "OtherConstantSaving",
                table: "LoansAndSavingsCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "CarLoan",
                table: "LoansAndSavingsCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Water",
                table: "LivingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "ServiceCharge",
                table: "LivingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "RentOrMortgage",
                table: "LivingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "OtherLivingCosts",
                table: "LivingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "LivingCostsTotal",
                table: "LivingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Heating",
                table: "LivingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "ElectricityOrGas",
                table: "LivingCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "TravelInsurance",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "TradeFundOrUnemploymentFund",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "TVAndPaymentChannels",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "SportAndExercise",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "OtherInsuranceAndMonthlyCosts",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "NewspaperAndMagazines",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "MobileAndInternet",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "InsuranceAndMonthlyCostsTotal",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "HomeInsurance",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "AccidentInsurance",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "UnemploymentBenefit",
                table: "Income",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "TotalIncomes",
                table: "Income",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "StudyGrant",
                table: "Income",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "StudentLoan",
                table: "Income",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "OtherIncomes",
                table: "Income",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "OtherBenefits",
                table: "Income",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "NetIncome",
                table: "Income",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "HousingAllowance",
                table: "Income",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "FixedCostsTotal",
                table: "FixedCost",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Vacation",
                table: "VariableCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "TotalVariableCosts",
                table: "VariableCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "OtherVariableCosts",
                table: "VariableCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "FurnitureAndDecoration",
                table: "VariableCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Freetime",
                table: "VariableCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "FoodAndDailyEquipments",
                table: "VariableCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "DoctorAndMedicines",
                table: "VariableCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Clothing",
                table: "VariableCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "TravellingCostsTotal",
                table: "TravellingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "TrafficAndVehiceTax",
                table: "TravellingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "PublicTransport",
                table: "TravellingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "OtherTravellingCosts",
                table: "TravellingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Fuel",
                table: "TravellingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "CarAndMotorcycleRepair",
                table: "TravellingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "CarAndMotorcycleInsurance",
                table: "TravellingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "UsageLoan",
                table: "LoansAndSavingsCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "TotalLoansAndSavings",
                table: "LoansAndSavingsCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "StudentLoan",
                table: "LoansAndSavingsCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "RetirementSaving",
                table: "LoansAndSavingsCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "OtherLoansAndSavings",
                table: "LoansAndSavingsCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "OtherConstantSaving",
                table: "LoansAndSavingsCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "CarLoan",
                table: "LoansAndSavingsCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Water",
                table: "LivingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "ServiceCharge",
                table: "LivingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "RentOrMortgage",
                table: "LivingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "OtherLivingCosts",
                table: "LivingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "LivingCostsTotal",
                table: "LivingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "Heating",
                table: "LivingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "ElectricityOrGas",
                table: "LivingCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "TravelInsurance",
                table: "InsuranceAndMonthlyCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "TradeFundOrUnemploymentFund",
                table: "InsuranceAndMonthlyCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "TVAndPaymentChannels",
                table: "InsuranceAndMonthlyCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "SportAndExercise",
                table: "InsuranceAndMonthlyCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "OtherInsuranceAndMonthlyCosts",
                table: "InsuranceAndMonthlyCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "NewspaperAndMagazines",
                table: "InsuranceAndMonthlyCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "MobileAndInternet",
                table: "InsuranceAndMonthlyCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "InsuranceAndMonthlyCostsTotal",
                table: "InsuranceAndMonthlyCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "HomeInsurance",
                table: "InsuranceAndMonthlyCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "AccidentInsurance",
                table: "InsuranceAndMonthlyCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "UnemploymentBenefit",
                table: "Income",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "TotalIncomes",
                table: "Income",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "StudyGrant",
                table: "Income",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "StudentLoan",
                table: "Income",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "OtherIncomes",
                table: "Income",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "OtherBenefits",
                table: "Income",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "NetIncome",
                table: "Income",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "HousingAllowance",
                table: "Income",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<float>(
                name: "FixedCostsTotal",
                table: "FixedCost",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
