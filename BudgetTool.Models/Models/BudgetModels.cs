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

        public Income()
        {
            this.TotalIncomes = NetIncome + StudyGrant + StudentLoan + HousingAllowance + 
                UnemploymentBenefit + OtherBenefits + OtherIncomes;
        }
    }

    public class FixedCost
    {
        public int Id { get; set; }
        public LivingCost LivingCosts { get; set; }
        public InsuranceAndMonthlyCost InsuranceAndMonthlyCosts { get; set; }
        public TravellingCost TravellingCosts { get; set; }
        public LoansAndSavingsCost LoansAndSavingsCosts { get; set; }

        public class LivingCost
        {
            public int Id { get; set; }
        }

        public class InsuranceAndMonthlyCost
        {
            public int Id { get; set; }
        }

        public class TravellingCost
        {
            public int Id { get; set; }
        }

        public class LoansAndSavingsCost
        {
            public int Id { get; set; }
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

        public VariableCost()
        {
            this.TotalVariableCosts = FoodAndDailyEquipments + DoctorAndMedicines + Clothing +
                Freetime + FurnitureAndDecoration + Vacation + OtherVariableCosts;
        }
    }

    
}
