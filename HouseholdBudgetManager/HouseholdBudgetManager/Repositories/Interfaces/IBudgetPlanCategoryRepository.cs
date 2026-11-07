using HouseholdBudgetManager.Entities;

namespace HouseholdBudgetManager.Repositories.Interfaces;

internal interface IBudgetPlanCategoryRepository
{
    IEnumerable<BudgetPlanCategory> ReadBudgetPlanCategory(
                                                           int? budgetPlanId = null,
                                                           int? categoryId = null);
    void CreateBudgetPlanCategory(BudgetPlanCategory budgetPlanCategory);
    void UpdateBudgetPlanCategory(BudgetPlanCategory budgetPlanCategory);
    void DeleteBudgetPlanCategory(int id);
}
