using HouseholdBudgetManager.Entities.Enums;

namespace HouseholdBudgetManager.Entities;

public class BudgetCategory
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public CategoriesTypes CategoryType { get; private set; }
    public PaymentMethods PaymentMethods { get; private set; }

    public static BudgetCategory CreateCategory(int id, string name, CategoriesTypes type, PaymentMethods paymentMethods)
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
