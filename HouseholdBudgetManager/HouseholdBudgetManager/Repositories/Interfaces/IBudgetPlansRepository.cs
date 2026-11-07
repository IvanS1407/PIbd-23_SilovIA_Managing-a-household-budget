using HouseholdBudgetManager.Entities;

namespace HouseholdBudgetManager.Repositories.Interfaces;

internal interface IBudgetPlansRepository
{
    IEnumerable<BudgetPlans> ReadBudgetPlans(DateTime? dateFrom = null);
    BudgetPlans ReadBudgetPlanById(int id);
    void CreateBudgetPlan(BudgetPlans plan);
    void UpdateBudgetPlan(BudgetPlans plan);
    void DeleteBudgetPlan(int id);
}
