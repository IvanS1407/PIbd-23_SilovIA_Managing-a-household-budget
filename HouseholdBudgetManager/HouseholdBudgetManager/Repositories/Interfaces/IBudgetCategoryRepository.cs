using HouseholdBudgetManager.Entities;

namespace HouseholdBudgetManager.Repositories.Interfaces;

internal interface IBudgetCategoryRepository
{
    IEnumerable<BudgetCategory> ReadBudgetCategories();
    BudgetCategory ReadBudgetCategoryById(int id);
    void CreateBudgetCategory(BudgetCategory category);
    void UpdateBudgetCategory(BudgetCategory category);
    void DeleteBudgetCategory(int id);
}
