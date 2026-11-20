using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HouseholdBudgetManager.Repositories;

public class BudgetPlanRepository : IBudgetPlanRepository
{
    private readonly ILogger _logger;
    private readonly DataContext _context;

    public BudgetPlanRepository(DataContext context, ILogger logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void CreateBudgetPlan(BudgetPlan plan)
    {
        _logger.LogInformation("Добавляем объект");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(plan));
        try
        {
            using var transaction = _context.Database.BeginTransaction();
            _context.BudgetPlans.Add(plan);
            _context.SaveChanges();
            transaction.Commit();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка создания плана");
            throw;
        }
    }

    public void DeleteBudgetPlan(int id)
    {
        _logger.LogInformation("Удаляем объект");
        _logger.LogDebug("ID объект: {id}", id);
        try
        {
            var plan = _context.BudgetPlans.Find(id) ?? throw new InvalidOperationException($"Запись ID {id} не найдена");
            _context.BudgetPlans.Remove(plan);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка удаления");
            throw;
        }
    }

    public IEnumerable<BudgetPlan> ReadBudgetPlans(DateTime? dateFrom = null)
    {
        _logger.LogInformation("Чтение планов бюджета.");
        try
        {
            var query = _context.BudgetPlans
                                .Include(x => x.BudgetPlanCategories)
                                .AsNoTracking()
                                .AsQueryable();
            if (dateFrom.HasValue)
            {
                query = query.Where(x => x.StartMonth >= dateFrom.Value);
            }
            var plans = query.ToList();
            _logger.LogDebug("Полученные объекты {json}", JsonConvert.SerializeObject(plans));
            return plans;

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка чтения планов");
            throw;
        }
    }
}
