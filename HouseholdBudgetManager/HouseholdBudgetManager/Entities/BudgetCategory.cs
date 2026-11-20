using HouseholdBudgetManager.Entities.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseholdBudgetManager.Entities;

[Index(nameof(Name), IsUnique = true)]
public class BudgetCategory
{
    [Key]
    public int Id { get; private set; }

    [Required]
    [MaxLength(150)]
    public string Name { get; private set; } = string.Empty;

    public CategoryType CategoryType { get; private set; }

    public PaymentMethods PaymentMethods { get; private set; }

    public static BudgetCategory CreateCategory(int id, string name, CategoryType type, PaymentMethods paymentMethods)
    {
        return new BudgetCategory
        {
            Id = id,
            Name = name ?? string.Empty,
            CategoryType = type,
            PaymentMethods = paymentMethods
        };
    }
}
