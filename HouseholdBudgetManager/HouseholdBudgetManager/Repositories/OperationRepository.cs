using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Repositories.Interfaces;

namespace HouseholdBudgetManager.Repositories;

public class OperationRepository : IOperationRepository
{
    public void CreateOperation(Operation operation)
    {
    }

    public IEnumerable<Operation> ReadOperations(DateTime? dateFrom = null, DateTime? dateTo = null, int? familyMemberId = null, int? categoryId = null)
    {
        return [];
    }
}
