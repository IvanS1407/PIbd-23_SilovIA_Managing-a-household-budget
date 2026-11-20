using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HouseholdBudgetManager.Repositories;

public class FamilyMemberRepository : IFamilyMemberRepository
{
    private readonly DataContext _context;
    private readonly ILogger _logger;

    public FamilyMemberRepository(DataContext context, ILogger logger)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public void CreateFamilyMember(FamilyMember familyMember)
    {
        _logger.LogInformation("Добавление объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(familyMember));
        try
        {
            _context.FamilyMembers.Add(familyMember);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка добавления данных.");
            throw;
        }
    }

    public void DeleteFamilyMember(int id)
    {
        _logger.LogInformation("Удаление объекта");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var familyMember = _context.FamilyMembers.Find(id) ?? throw new InvalidOperationException($"Запись с ID {id} не найдена");
            _context.FamilyMembers.Remove(familyMember);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при удалении объекта");
            throw;
        }
    }

    public FamilyMember ReadFamilyMemberById(int id)
    {
        _logger.LogInformation("Получение объекта по ID");
        _logger.LogDebug("Объект: {id}", id);
        try
        {
            var familyMember = _context.FamilyMembers.AsNoTracking().First(x => x.Id == id);
            _logger.LogDebug("Найденный объект: {json}", JsonConvert.SerializeObject(familyMember));
            return familyMember;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при поиске объекта");
            throw;
        }
    }

    public IEnumerable<FamilyMember> ReadFamilyMembers()
    {
        _logger.LogInformation("Получение всех объектов");
        try
        {
            var familyMembers = _context.FamilyMembers.AsNoTracking().ToList();
            _logger.LogDebug("Полученные объекты: {json}", JsonConvert.SerializeObject(familyMembers));
            return familyMembers;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Ошибка при чтении объектов");
            throw;
        }
    }

    public void UpdateFamilyMember(FamilyMember familyMember)
    {
        _logger.LogInformation("Редактирование объекта");
        _logger.LogDebug("Объект: {json}", JsonConvert.SerializeObject(familyMember));
        try
        {
            _context.FamilyMembers.Update(familyMember);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            _context.ChangeTracker.Clear();
            _logger.LogError(ex, "Ошибка при редактировании объекта");
            throw;
        }
    }
}
