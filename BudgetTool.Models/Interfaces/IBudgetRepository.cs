using BudgetTool.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTool.Domain.Interfaces
{
    public interface IBudgetRepository
    {
        IEnumerable<BudgetModel> GetBudgets();
    }
}
