using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Repositories.Interfaces;

namespace HouseholdBudgetManager.Repositories;

internal class BudgetPlansRepository : IBudgetPlansRepository
{
    public void CreateBudgetPlan(BudgetPlans plan)
    {
        throw new NotImplementedException();
    }

    public void DeleteBudgetPlan(int id)
    {
        throw new NotImplementedException();
    }

    public BudgetPlans ReadBudgetPlanById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<BudgetPlans> ReadBudgetPlans(DateTime? dateFrom = null)
    {
        throw new NotImplementedException();
    }

    public void UpdateBudgetPlan(BudgetPlans plan)
    {
        throw new NotImplementedException();
    }
}
