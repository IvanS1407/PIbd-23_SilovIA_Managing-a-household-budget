using HouseholdBudgetManager.Entities.Enums;

namespace HouseholdBudgetManager.Entities;

internal class FamilyMember
{
    public int Id { get; private set; }
    public string Surname { get; private set; } = string.Empty;
    public string Name { get; private set; } = string.Empty;
    public string LastName { get; private set;  } = string.Empty;
    public DateTime BirthDate { get; private set; }
    public FamilyRole Role { get; private set; }

    public static FamilyMember CreateMember(int id, string name, string surname, string lastname, DateTime birthdate, FamilyRole role)
    {
        return new FamilyMember
        {
            Id = id,
            Surname = surname,
            Name = name,
            LastName = lastname ?? string.Empty,
            BirthDate = birthdate,
            Role = role
        };
    }

}
