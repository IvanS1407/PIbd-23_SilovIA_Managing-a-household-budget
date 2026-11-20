using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseholdBudgetManager.Entities;

public class BudgetPlan
{
    [Key]
    public int Id { get; private set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; private set; } = string.Empty;

    [Column(TypeName = "date")]
    public DateTime StartMonth { get; private set; }

    public int MonthsCount { get; private set; }

    [Column(TypeName = "timestamp")]
    public DateTime CreatedDate { get; private set; }

    [ForeignKey(nameof(BudgetPlanCategory.BudgetPlanId))]
    public IEnumerable<BudgetPlanCategory> BudgetPlanCategories { get; private set; }

    public static BudgetPlan CreateBudgetPlan(int id, string name, DateTime startMonth, int monthsCount, IEnumerable<BudgetPlanCategory> budgetPlanCategories)
    {
        return new BudgetPlan
        {
            Id = id,
            Name = name,
            StartMonth = startMonth,
            MonthsCount = monthsCount,
            CreatedDate = DateTime.Now,
            BudgetPlanCategories = budgetPlanCategories
        };
    }
}
