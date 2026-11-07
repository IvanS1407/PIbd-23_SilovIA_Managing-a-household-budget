using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Repositories.Interfaces;

namespace HouseholdBudgetManager.Repositories;

internal class OperationsRepository : IOperationRepository
{
    public void CreateOperation(Operation operation)
    {
        throw new NotImplementedException();
    }

    public Operation ReadOperationById(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Operation> ReadOperations(DateTime? dateFrom = null, DateTime? dateTo = null, int? familyMemberId = null, int? categoryId = null)
    {
        throw new NotImplementedException();
    }
}
