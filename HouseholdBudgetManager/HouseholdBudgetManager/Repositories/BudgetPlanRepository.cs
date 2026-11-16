using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Repositories.Interfaces;

namespace HouseholdBudgetManager.Repositories;

public class BudgetPlanRepository : IBudgetPlanRepository
{
    public void CreateBudgetPlan(BudgetPlan plan)
    {
    }

    public void DeleteBudgetPlan(int id)
    {
    }

    public IEnumerable<BudgetPlan> ReadBudgetPlans(DateTime? dateFrom = null)
    {
        return [];
    }
}
