using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseholdBudgetManager.Entities;

[Index(nameof(BudgetPlanId), nameof(CategoryId), IsUnique = true)]
public class BudgetPlanCategory
{
    [Key]
    public int Id { get; private set; }

    public int CategoryId { get; private set; }

    public int BudgetPlanId { get; private set; }

    [Precision(12, 2)]
    public decimal PlannedAmount { get; private set; }

    public static BudgetPlanCategory CreateBudgetPlanCategory(int id, int categoryId, int budgetPlanId, decimal plannedAmount)
    {
        return new BudgetPlanCategory
        {
            Id = id,
            CategoryId = categoryId,
            BudgetPlanId = budgetPlanId,
            PlannedAmount = plannedAmount
        };
    }
}
