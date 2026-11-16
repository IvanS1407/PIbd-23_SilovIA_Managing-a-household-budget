using HouseholdBudgetManager.Entities;

namespace HouseholdBudgetManager.Repositories.Interfaces;

public interface IBudgetPlanRepository
{
    IEnumerable<BudgetPlan> ReadBudgetPlans(DateTime? dateFrom = null);
    void CreateBudgetPlan(BudgetPlan plan);
    void DeleteBudgetPlan(int id);
}
