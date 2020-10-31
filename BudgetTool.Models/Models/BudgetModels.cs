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
        public float NetIncome { get; set; }
        public float StudyGrant { get; set; }
        public float StudentLoan { get; set; }
        public float HousingAllowance { get; set; }
        public float UnemploymentBenefit { get; set; }
        public float OtherBenefits { get; set; }
        public float OtherIncomes { get; set; }
        public float TotalIncomes { get; set; }
    }

    public class FixedCost
    {
        public int Id { get; set; }
        public LivingCost LivingCosts { get; set; }
        public InsuranceAndMonthlyCost InsuranceAndMonthlyCosts { get; set; }
        public TravellingCost TravellingCosts { get; set; }
        public LoansAndSavingsCost LoansAndSavingsCosts { get; set; }
        public float FixedCostsTotal { get; set; }

        public class LivingCost
        {
            public int Id { get; set; }
            public float RentOrMortgage { get; set; }
            public float Heating { get; set; }
            public float Water { get; set; }
            public float ElectricityOrGas { get; set; }
            public float ServiceCharge { get; set; }
            public float OtherLivingCosts { get; set; }
            public float LivingCostsTotal { get; set; }
        }

        public class InsuranceAndMonthlyCost
        {
            public int Id { get; set; }
            public float AccidentInsurance { get; set; }
            public float TravelInsurance { get; set; }
            public float HomeInsurance { get; set; }
            public float MobileAndInternet { get; set; }
            public float TVAndPaymentChannels { get; set; }
            public float TradeFundOrUnemploymentFund { get; set; }
            public float SportAndExercise { get; set; }
            public float NewspaperAndMagazines { get; set; }
            public float OtherInsuranceAndMonthlyCosts { get; set; }
            public float InsuranceAndMonthlyCostsTotal { get; set; }

        }

        public class TravellingCost
        {
            public int Id { get; set; }
            public float TrafficAndVehiceTax { get; set; }
            public float CarAndMotorcycleInsurance { get; set; }
            public float Fuel { get; set; }
            public float CarAndMotorcycleRepair { get; set; }
            public float PublicTransport { get; set; }
            public float OtherTravellingCosts { get; set; }
            public float TravellingCostsTotal { get; set; }
        }

        public class LoansAndSavingsCost
        {
            public int Id { get; set; }
            public float StudentLoan { get; set; }
            public float UsageLoan { get; set; }
            public float RetirementSaving { get; set; }
            public float OtherConstantSaving { get; set; }
            public float CarLoan { get; set; }
            public float OtherLoansAndSavings { get; set; }
            public float TotalLoansAndSavings { get; set; }
        }

    }


    public class VariableCost
    {
        public int Id { get; set; }
        public float FoodAndDailyEquipments { get; set; }
        public float DoctorAndMedicines { get; set; }
        public float Clothing { get; set; }
        public float Freetime { get; set; }
        public float FurnitureAndDecoration { get; set; }
        public float Vacation { get; set; }
        public float OtherVariableCosts { get; set; }
        public float TotalVariableCosts { get; set; }
    }

    
}
