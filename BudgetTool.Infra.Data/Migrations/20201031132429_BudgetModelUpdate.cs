using Microsoft.EntityFrameworkCore.Migrations;

namespace BudgetTool.UI.Migrations
{
    public partial class BudgetModelUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CarAndMotorcycleInsurance",
                table: "TravellingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "CarAndMotorcycleRepair",
                table: "TravellingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Fuel",
                table: "TravellingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "OtherTravellingCosts",
                table: "TravellingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PublicTransport",
                table: "TravellingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TrafficAndVehiceTax",
                table: "TravellingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TravellingCostsTotal",
                table: "TravellingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "CarLoan",
                table: "LoansAndSavingsCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "OtherConstantSaving",
                table: "LoansAndSavingsCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "OtherLoansAndSavings",
                table: "LoansAndSavingsCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "RetirementSaving",
                table: "LoansAndSavingsCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "StudentLoan",
                table: "LoansAndSavingsCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TotalLoansAndSavings",
                table: "LoansAndSavingsCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UsageLoan",
                table: "LoansAndSavingsCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ElectricityOrGas",
                table: "LivingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Heating",
                table: "LivingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "LivingCostsTotal",
                table: "LivingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "OtherLivingCosts",
                table: "LivingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "RentOrMortgage",
                table: "LivingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ServiceCharge",
                table: "LivingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Water",
                table: "LivingCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "AccidentInsurance",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "HomeInsurance",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "InsuranceAndMonthlyCostsTotal",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "MobileAndInternet",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "NewspaperAndMagazines",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "OtherInsuranceAndMonthlyCosts",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "SportAndExercise",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TVAndPaymentChannels",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TradeFundOrUnemploymentFund",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "TravelInsurance",
                table: "InsuranceAndMonthlyCost",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "FixedCostsTotal",
                table: "FixedCost",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarAndMotorcycleInsurance",
                table: "TravellingCost");

            migrationBuilder.DropColumn(
                name: "CarAndMotorcycleRepair",
                table: "TravellingCost");

            migrationBuilder.DropColumn(
                name: "Fuel",
                table: "TravellingCost");

            migrationBuilder.DropColumn(
                name: "OtherTravellingCosts",
                table: "TravellingCost");

            migrationBuilder.DropColumn(
                name: "PublicTransport",
                table: "TravellingCost");

            migrationBuilder.DropColumn(
                name: "TrafficAndVehiceTax",
                table: "TravellingCost");

            migrationBuilder.DropColumn(
                name: "TravellingCostsTotal",
                table: "TravellingCost");

            migrationBuilder.DropColumn(
                name: "CarLoan",
                table: "LoansAndSavingsCost");

            migrationBuilder.DropColumn(
                name: "OtherConstantSaving",
                table: "LoansAndSavingsCost");

            migrationBuilder.DropColumn(
                name: "OtherLoansAndSavings",
                table: "LoansAndSavingsCost");

            migrationBuilder.DropColumn(
                name: "RetirementSaving",
                table: "LoansAndSavingsCost");

            migrationBuilder.DropColumn(
                name: "StudentLoan",
                table: "LoansAndSavingsCost");

            migrationBuilder.DropColumn(
                name: "TotalLoansAndSavings",
                table: "LoansAndSavingsCost");

            migrationBuilder.DropColumn(
                name: "UsageLoan",
                table: "LoansAndSavingsCost");

            migrationBuilder.DropColumn(
                name: "ElectricityOrGas",
                table: "LivingCost");

            migrationBuilder.DropColumn(
                name: "Heating",
                table: "LivingCost");

            migrationBuilder.DropColumn(
                name: "LivingCostsTotal",
                table: "LivingCost");

            migrationBuilder.DropColumn(
                name: "OtherLivingCosts",
                table: "LivingCost");

            migrationBuilder.DropColumn(
                name: "RentOrMortgage",
                table: "LivingCost");

            migrationBuilder.DropColumn(
                name: "ServiceCharge",
                table: "LivingCost");

            migrationBuilder.DropColumn(
                name: "Water",
                table: "LivingCost");

            migrationBuilder.DropColumn(
                name: "AccidentInsurance",
                table: "InsuranceAndMonthlyCost");

            migrationBuilder.DropColumn(
                name: "HomeInsurance",
                table: "InsuranceAndMonthlyCost");

            migrationBuilder.DropColumn(
                name: "InsuranceAndMonthlyCostsTotal",
                table: "InsuranceAndMonthlyCost");

            migrationBuilder.DropColumn(
                name: "MobileAndInternet",
                table: "InsuranceAndMonthlyCost");

            migrationBuilder.DropColumn(
                name: "NewspaperAndMagazines",
                table: "InsuranceAndMonthlyCost");

            migrationBuilder.DropColumn(
                name: "OtherInsuranceAndMonthlyCosts",
                table: "InsuranceAndMonthlyCost");

            migrationBuilder.DropColumn(
                name: "SportAndExercise",
                table: "InsuranceAndMonthlyCost");

            migrationBuilder.DropColumn(
                name: "TVAndPaymentChannels",
                table: "InsuranceAndMonthlyCost");

            migrationBuilder.DropColumn(
                name: "TradeFundOrUnemploymentFund",
                table: "InsuranceAndMonthlyCost");

            migrationBuilder.DropColumn(
                name: "TravelInsurance",
                table: "InsuranceAndMonthlyCost");

            migrationBuilder.DropColumn(
                name: "FixedCostsTotal",
                table: "FixedCost");
        }
    }
}
