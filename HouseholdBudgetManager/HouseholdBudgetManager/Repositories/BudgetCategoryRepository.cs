using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HouseholdBudgetManager.Repositories;

public class BudgetCategoryRepository : IBudgetCategoryRepository
{
    private readonly ILogger _logger;
    private readonly DataContext _context;

    public BudgetCategoryRepository(DataContext context, ILogger logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void CreateBudgetCategory(BudgetCategory category)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект :{json}", JsonConvert.SerializeObject(category));
        try
        {
            _context.BudgetCategories.Add(category);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при добавлении объекта");
            throw;
        }
    }

    public void DeleteBudgetCategory(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("ID объекта :{id}", id);
        try
        {
            var budgetCategory = _context.BudgetCategories.Find(id) ?? throw new InvalidOperationException($"Запись с ID {id} не найдена");
            _context.BudgetCategories.Remove(budgetCategory);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка удаления объекта");
            throw;
        }
    }

    public IEnumerable<BudgetCategory> ReadBudgetCategories()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var budgetCategories = _context.BudgetCategories.AsNoTracking().ToList();
            _logger.LogDebug("Объекты: {json}", JsonConvert.SerializeObject(budgetCategories));
            return budgetCategories;
        }
        catch (Exception ex)
        {
            _logger.LogError("Ошибка при чтении объектов");
            throw;
        }
    }

    public BudgetCategory ReadBudgetCategoryById(int id)
    {
        _logger.LogInformation("Поиск объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var budgetCategory = _context.BudgetCategories.AsNoTracking().First(x => x.Id == id);
            _logger.LogDebug("Найденный объект: {json}", JsonConvert.SerializeObject(budgetCategory));
            return budgetCategory;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public void UpdateBudgetCategory(BudgetCategory category)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект :{json}", JsonConvert.SerializeObject(category));
        try
        {
            _context.BudgetCategories.Update(category);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при редактировании объекта");
        }
    }
}
