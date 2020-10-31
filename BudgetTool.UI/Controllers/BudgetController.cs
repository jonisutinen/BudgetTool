using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BudgetTool.Application.Interfaces;
using BudgetTool.Application.VIewModels;
using Microsoft.AspNetCore.Mvc;

namespace BudgetTool.UI.Controllers
{
    public class BudgetController : Controller
    {

        private IBudgetService _budgetService;
        public BudgetController(IBudgetService budgetService)
        {
            _budgetService = budgetService;
        }

        public IActionResult Index()
        {
            BudgetViewModel model = _budgetService.GetBudgets();
            return View(model);
        }
    }
}
