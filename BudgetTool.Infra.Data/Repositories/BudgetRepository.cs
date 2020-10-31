using BudgetTool.Domain.Interfaces;
using BudgetTool.Infra.Data.Context;
using BudgetTool.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTool.Infra.Data.Repositories
{
    public class BudgetRepository : IBudgetRepository
    {
        public BudgetToolDbContext _context;
        public BudgetRepository(BudgetToolDbContext context)
        {
            _context = context;
        }
        public IEnumerable<BudgetModel> GetBudgets()
        {
            return _context.BudgetModels;
        }
    }
}
