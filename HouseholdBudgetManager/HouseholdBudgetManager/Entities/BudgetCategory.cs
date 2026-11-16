using HouseholdBudgetManager.Entities.Enums;

namespace HouseholdBudgetManager.Entities;

public class BudgetCategory
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public CategoryType CategoryType { get; private set; }
    public PaymentMethods PaymentMethods { get; private set; }

    public static BudgetCategory CreateCategory(int id, string name, CategoryType type, PaymentMethods paymentMethods)
    {
        return new BudgetCategory
        {
            Id = id,
            Name = name ?? string.Empty,
            CategoryType = type,
            PaymentMethods = paymentMethods
        };
    }
}
