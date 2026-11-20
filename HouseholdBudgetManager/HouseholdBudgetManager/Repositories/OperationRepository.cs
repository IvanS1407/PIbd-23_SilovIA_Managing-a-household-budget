using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HouseholdBudgetManager.Repositories;

public class OperationRepository : IOperationRepository
{
    private readonly ILogger _logger;
    private readonly DataContext _context;

    public OperationRepository(DataContext context, ILogger logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public void CreateOperation(Operation operation)
    {
        _logger.LogInformation("Добавляем объект");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(operation));
        try
        {
            _context.Operations.Add(operation);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка создания объекта");
            throw;
        }
    }

    public IEnumerable<Operation> ReadOperations(DateTime? dateFrom = null, DateTime? dateTo = null, int? familyMemberId = null, int? categoryId = null)
    {
        _logger.LogInformation("Чтение операций");
        try
        {
            var query = _context.Operations.AsNoTracking().AsQueryable();
            if (dateFrom.HasValue)
            {
                query = query.Where(x => x.OperationDate >= dateFrom.Value);
            }
            if (dateTo.HasValue)
            {
                query = query.Where(x => x.OperationDate <= dateTo.Value);
            }
            if (familyMemberId.HasValue)
            {
                query = query.Where(x => x.FamilyMemberId == familyMemberId.Value);
            }
            if (categoryId.HasValue)
            {
                query = query.Where(x => x.CategoryId == categoryId.Value);
            }

            var operations = query.ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonConvert.SerializeObject(operations));
            return operations;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка чтения операций");
            throw;
        }
    }
}
