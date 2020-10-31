using BudgetTool.Application.VIewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTool.Application.Interfaces
{
    public interface IBudgetService
    {
        BudgetViewModel GetBudgets();
    }
}
