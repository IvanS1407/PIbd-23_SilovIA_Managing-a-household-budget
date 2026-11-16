using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Entities.Enums;
using HouseholdBudgetManager.Repositories.Interfaces;

namespace HouseholdBudgetManager.Repositories;

public class FamilyMemberRepository : IFamilyMemberRepository
{
    public void CreateFamilyMember(FamilyMember familyMember)
    {
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
