namespace HouseholdBudgetManager.Entities;

public class BudgetPlanCategory
{
    public int Id { get; private set; }
    public int CategoryId { get; private set; }
    public int BudgetPlanId { get; private set; }
    public decimal PlannedAmount { get; private set; }

    public static BudgetPlanCategory CreateBudgetPlanCategory(int id, int categoryId, int budgetPlanId, decimal plannedAmount)
    {
        return new BudgetPlanCategory { Id = id, CategoryId = categoryId, BudgetPlanId = budgetPlanId, PlannedAmount = plannedAmount };
    }
}
