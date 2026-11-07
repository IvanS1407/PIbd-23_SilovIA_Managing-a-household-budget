namespace HouseholdBudgetManager.Entities;

public class BudgetPlans
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public DateTime StartMonth { get; private set; }
    public int MonthsCount { get; private set; }
    public DateTime CreatedDate { get; private set; }

    public static BudgetPlans CreateBudgetPlan(int id, string name, DateTime startMonth, int monthsCount)
    {
        return new BudgetPlans { Id = id, Name = name, StartMonth = startMonth, MonthsCount = monthsCount, CreatedDate = DateTime.Now };
    }
}
