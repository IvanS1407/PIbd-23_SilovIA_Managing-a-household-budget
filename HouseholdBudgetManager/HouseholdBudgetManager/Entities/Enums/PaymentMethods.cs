namespace HouseholdBudgetManager.Entities.Enums;

[Flags]
public enum PaymentMethods
{
    None = 0,
    Cash = 1,
    Card = 2,
    BankTransfer = 4,
    Online = 8
}
