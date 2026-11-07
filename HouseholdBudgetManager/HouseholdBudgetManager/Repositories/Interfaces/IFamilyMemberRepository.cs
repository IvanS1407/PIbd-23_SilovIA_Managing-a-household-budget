using HouseholdBudgetManager.Entities;

namespace HouseholdBudgetManager.Repositories.Interfaces;

public interface IFamilyMemberRepository
{
    IEnumerable<FamilyMember> ReadFamilyMembers();
    FamilyMember ReadFamilyMemberById(int id);
    void CreateFamilyMember(FamilyMember familyMember);
    void UpdateFamilyMember(FamilyMember familyMember);
    void DeleteFamilyMember(int id);
}
