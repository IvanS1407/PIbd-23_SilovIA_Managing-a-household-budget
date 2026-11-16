namespace HouseholdBudgetManager.Entities;

public class BudgetPlan
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public DateTime StartMonth { get; private set; }
    public int MonthsCount { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public IEnumerable<BudgetPlanCategory> BudgetPlanCategories { get; private set; }

    public static BudgetPlan CreateBudgetPlan(int id, string name, DateTime startMonth, int monthsCount, IEnumerable<BudgetPlanCategory> budgetPlanCategories)
    {
        return new BudgetPlan
        {
            Id = id,
            Name = name,
            StartMonth = startMonth,
            MonthsCount = monthsCount,
            CreatedDate = DateTime.Now,
            BudgetPlanCategories = budgetPlanCategories
        };
    }
}
