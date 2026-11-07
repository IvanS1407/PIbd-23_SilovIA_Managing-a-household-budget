namespace HouseholdBudgetManager.Entities;

public class Operation
{
    public int Id { get; private set; }
    public int FamilyMemberId { get; private set; }
    public int CategoryId { get; private set; }
    public decimal Amount { get; private set; }
    public DateTime OperationDate { get; private set; }
    public string Comment { get; private set; } = string.Empty;
    public static Operation CreateOperation(int id, int familyMemberId, int categoryId, decimal amount,DateTime dateOperation, string comment)
    {
        return new Operation
        {
            Id = id,
            FamilyMemberId = familyMemberId,
            CategoryId = categoryId,
            Amount = amount,
            OperationDate = dateOperation,
            Comment = comment ?? string.Empty
        };
    }
}
