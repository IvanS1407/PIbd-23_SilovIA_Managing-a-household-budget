using HouseholdBudgetManager.Repositories.Interfaces;
using HouseholdBudgetManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace HouseholdBudgetManager.Repositories;

public class DataContext : DbContext
{
    private readonly IConnectionString _connectionString;

    public DataContext(IConnectionString connectionString)
    {
        _connectionString = connectionString;
    }

    public DbSet<FamilyMember> FamilyMembers => Set<FamilyMember>();
    public DbSet<BudgetCategory> BudgetCategories => Set<BudgetCategory>();
    public DbSet<Operation> Operations => Set<Operation>();
    public DbSet<BudgetPlan> BudgetPlans => Set<BudgetPlan>();
    public DbSet<BudgetPlanCategory> BudgetPlanCategories => Set<BudgetPlanCategory>();


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_connectionString.ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FamilyMember>(entity =>
        {
            entity.Property(x => x.Surname).IsRequired().HasMaxLength(100);
            entity.Property(x => x.Name).IsRequired().HasMaxLength(100);
            entity.Property(x => x.LastName).IsRequired(false).HasMaxLength(100);
            entity.Property(x => x.BirthDate).IsRequired().HasColumnType("date");
        });

        modelBuilder.Entity<BudgetCategory>(entity =>
        {
            entity.Property(x => x.Name).IsRequired().HasMaxLength(150);
            entity.HasIndex(x => x.Name).IsUnique();
        });

        modelBuilder.Entity<Operation>(entity =>
        {
            entity.Property(x => x.Amount).HasPrecision(12, 2);
            entity.Property(x => x.OperationDate).HasColumnType("timestamp");
            entity.HasOne<FamilyMember>()
                         .WithMany()
                         .HasForeignKey(x => x.FamilyMemberId)
                         .OnDelete(DeleteBehavior.Restrict);
            entity.HasOne<BudgetCategory>()
                         .WithMany()
                         .HasForeignKey(x => x.CategoryId)
                         .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<BudgetPlan>(entity =>
        {
            entity.Property(x => x.Name).IsRequired().HasMaxLength(150);
            entity.Property(x => x.StartMonth).HasColumnType("date");
            entity.Property(x => x.CreatedDate).HasColumnType("timestamp");
        });

        modelBuilder.Entity<BudgetPlanCategory>(entity =>
        {
            entity.HasOne<BudgetPlan>()
                         .WithMany()
                         .HasForeignKey(x => x.BudgetPlanId)
                         .OnDelete(DeleteBehavior.Cascade);
            entity.HasOne<BudgetCategory>()
                         .WithMany()
                         .HasForeignKey(x => x.CategoryId)
                         .OnDelete(DeleteBehavior.Restrict);
            entity.HasIndex(x => new { x.BudgetPlanId, x.CategoryId }).IsUnique();
        });
    }
}
