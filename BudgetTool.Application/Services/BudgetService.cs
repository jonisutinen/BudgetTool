using BudgetTool.Application.Interfaces;
using BudgetTool.Application.VIewModels;
using BudgetTool.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTool.Application.Services
{
    public class BudgetService : IBudgetService
    {
        public IBudgetRepository _budgetRepository;
        public BudgetService(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        public BudgetViewModel GetBudgets()
        {
            //return _budgetRepository.GetBudgets();
            return new BudgetViewModel()
            {
                BudgetVM = _budgetRepository.GetBudgets()
            };
        }
    }
}
