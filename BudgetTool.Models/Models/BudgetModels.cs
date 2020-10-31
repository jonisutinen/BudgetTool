using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTool.Models.Models
{
    public class BudgetModel
    {
        public int Id { get; set; }
        public Income Incomes { get; set; }
        public FixedCost FixedCosts { get; set; }
        public VariableCost VariableCosts { get; set; }
    }

    public class Income
    {
        public int Id { get; set; }
        public double NetIncome { get; set; }
        public double StudyGrant { get; set; }
        public double StudentLoan { get; set; }
        public double HousingAllowance { get; set; }
        public double UnemploymentBenefit { get; set; }
        public double OtherBenefits { get; set; }
        public double OtherIncomes { get; set; }
        public double TotalIncomes { get; set; }
    }

    public class FixedCost
    {
        public int Id { get; set; }
        public LivingCost LivingCosts { get; set; }
        public InsuranceAndMonthlyCost InsuranceAndMonthlyCosts { get; set; }
        public TravellingCost TravellingCosts { get; set; }
        public LoansAndSavingsCost LoansAndSavingsCosts { get; set; }
        public double FixedCostsTotal { get; set; }

        public class LivingCost
        {
            public int Id { get; set; }
            public double RentOrMortgage { get; set; }
            public double Heating { get; set; }
            public double Water { get; set; }
            public double ElectricityOrGas { get; set; }
            public double ServiceCharge { get; set; }
            public double OtherLivingCosts { get; set; }
            public double LivingCostsTotal { get; set; }
        }

        public class InsuranceAndMonthlyCost
        {
            public int Id { get; set; }
            public double AccidentInsurance { get; set; }
            public double TravelInsurance { get; set; }
            public double HomeInsurance { get; set; }
            public double MobileAndInternet { get; set; }
            public double TVAndPaymentChannels { get; set; }
            public double TradeFundOrUnemploymentFund { get; set; }
            public double SportAndExercise { get; set; }
            public double NewspaperAndMagazines { get; set; }
            public double OtherInsuranceAndMonthlyCosts { get; set; }
            public double InsuranceAndMonthlyCostsTotal { get; set; }

        }

        public class TravellingCost
        {
            public int Id { get; set; }
            public double TrafficAndVehiceTax { get; set; }
            public double CarAndMotorcycleInsurance { get; set; }
            public double Fuel { get; set; }
            public double CarAndMotorcycleRepair { get; set; }
            public double PublicTransport { get; set; }
            public double OtherTravellingCosts { get; set; }
            public double TravellingCostsTotal { get; set; }
        }

        public class LoansAndSavingsCost
        {
            public int Id { get; set; }
            public double StudentLoan { get; set; }
            public double UsageLoan { get; set; }
            public double RetirementSaving { get; set; }
            public double OtherConstantSaving { get; set; }
            public double CarLoan { get; set; }
            public double OtherLoansAndSavings { get; set; }
            public double TotalLoansAndSavings { get; set; }
        }

    }


    public class VariableCost
    {
        public int Id { get; set; }
        public double FoodAndDailyEquipments { get; set; }
        public double DoctorAndMedicines { get; set; }
        public double Clothing { get; set; }
        public double Freetime { get; set; }
        public double FurnitureAndDecoration { get; set; }
        public double Vacation { get; set; }
        public double OtherVariableCosts { get; set; }
        public double TotalVariableCosts { get; set; }
    }

    
}
