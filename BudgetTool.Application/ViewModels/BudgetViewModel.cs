using BudgetTool.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTool.Application.VIewModels
{
    public class BudgetViewModel
    {
        public IEnumerable<BudgetModel> BudgetVM { get; set; }
    }
}
