using Microsoft.EntityFrameworkCore.Design;

namespace HouseholdBudgetManager.Repositories;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        return new DataContext(new NpqsqlConnectionString());
    }
}
