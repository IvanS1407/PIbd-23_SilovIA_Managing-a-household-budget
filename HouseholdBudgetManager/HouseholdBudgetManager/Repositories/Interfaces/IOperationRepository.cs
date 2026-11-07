using HouseholdBudgetManager.Entities;

namespace HouseholdBudgetManager.Repositories.Interfaces;

internal interface IOperationRepository
{
    IEnumerable<Operation> ReadOperations(
                                        DateTime? dateFrom = null,
                                        DateTime? dateTo = null,
                                        int? familyMemberId = null,
                                        int? categoryId = null);
    Operation ReadOperationById(int id);
    void CreateOperation(Operation operation);
}
