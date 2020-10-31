using System;
using System.Collections.Generic;
using System.Text;
using BudgetTool.Models.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace BudgetTool.Infra.Data.Context
{
    public class BudgetToolDbContext : IdentityDbContext
    {
        public BudgetToolDbContext(DbContextOptions options) : base(options) { }
        public DbSet<BudgetModel> BudgetModels { get; set; }
    }
}
