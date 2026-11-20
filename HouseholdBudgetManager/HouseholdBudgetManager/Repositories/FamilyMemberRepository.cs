using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Entities.Enums;
using HouseholdBudgetManager.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HouseholdBudgetManager.Repositories;

public class FamilyMemberRepository : IFamilyMemberRepository
{
    private readonly IConnectionString _connectionString;
    private readonly ILogger _logger;

    public FamilyMemberRepository(IConnectionString connectionString, ILogger logger)
    {
        _connectionString = connectionString;
        _logger = logger;
    }

    public void CreateFamilyMember(FamilyMember familyMember)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(familyMember));
    }

    public void DeleteFamilyMember(int id)
    {
    }

    public FamilyMember ReadFamilyMemberById(int id)
    {
        return FamilyMember.CreateMember(
            0,
            string.Empty,
            string.Empty,
            string.Empty,
            DateTime.Today,
            FamilyRole.None
        );
    }

    public IEnumerable<FamilyMember> ReadFamilyMembers()
    {
        return [];
    }

    public void UpdateFamilyMember(FamilyMember familyMember)
    {
    }
}
