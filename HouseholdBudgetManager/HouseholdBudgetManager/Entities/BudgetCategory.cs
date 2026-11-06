using HouseholdBudgetManager.Entities.Enums;

namespace HouseholdBudgetManager.Entities;

internal class BudgetCategory
{
    public int Id { get; private set; }
    public CategoriesTypes CategoryType { get; private set; }
    public PaymentMethods PaymentMethods { get; private set; }

    public static BudgetCategory CreateCategory(int id, CategoriesTypes type, PaymentMethods paymentMethods)
    {
        return new BudgetCategory
        {
            Id = id,
            CategoryType = type,
            PaymentMethods = paymentMethods
        };
    }
}
