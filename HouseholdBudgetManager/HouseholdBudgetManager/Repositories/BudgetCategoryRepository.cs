using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Entities.Enums;
using HouseholdBudgetManager.Repositories.Interfaces;

namespace HouseholdBudgetManager.Repositories;

public class BudgetCategoryRepository : IBudgetCategoryRepository
{
    public void CreateBudgetCategory(BudgetCategory category)
    {
    }

    public void DeleteBudgetCategory(int id)
    {
    }

    public IEnumerable<BudgetCategory> ReadBudgetCategories()
    {
        return [];
    }

    public BudgetCategory ReadBudgetCategoryById(int id)
    {
        return BudgetCategory.CreateCategory(
                0,
                string.Empty,
                CategoryType.None,
                PaymentMethods.None
            );
    }

    public void UpdateBudgetCategory(BudgetCategory category)
    {
        throw new NotImplementedException();
    }
}
