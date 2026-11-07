using HouseholdBudgetManager.Entities;

namespace HouseholdBudgetManager.Repositories.Interfaces;

public interface IOperationRepository
{
    IEnumerable<Operation> ReadOperations(
                                        DateTime? dateFrom = null,
                                        DateTime? dateTo = null,
                                        int? familyMemberId = null,
                                        int? categoryId = null);
    Operation ReadOperationById(int id);
    void CreateOperation(Operation operation);
}
