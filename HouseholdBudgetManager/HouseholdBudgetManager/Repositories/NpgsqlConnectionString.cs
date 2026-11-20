using HouseholdBudgetManager.Repositories.Interfaces;

namespace HouseholdBudgetManager.Repositories;

public class NpgsqlConnectionString : IConnectionString
{
    public string ConnectionString => "Host=localhost;Port=5432;Database=household_budget;Username=postgres;Password=12345678";
}
