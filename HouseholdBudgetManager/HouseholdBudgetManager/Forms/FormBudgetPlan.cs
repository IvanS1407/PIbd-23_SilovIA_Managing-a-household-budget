using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Repositories.Interfaces;

namespace HouseholdBudgetManager.Forms;

public partial class FormBudgetPlan : Form
{
    private readonly IBudgetPlanRepository _budgetPlanRepository;
    public FormBudgetPlan(IBudgetPlanRepository budgetPlanRepository, IBudgetCategoryRepository budgetCategoryRepository)
    {
        InitializeComponent();
        _budgetPlanRepository = budgetPlanRepository ?? throw new ArgumentNullException(nameof(budgetPlanRepository));

        ColumnCategory.DataSource = budgetCategoryRepository.ReadBudgetCategories().ToList();
        ColumnCategory.DisplayMember = "Name";
        ColumnCategory.ValueMember = "Id";
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            dataGridViewCategories.EndEdit();
            var categories = CreateListBudgetPlanCategoryFromDataGrid();
            if (string.IsNullOrWhiteSpace(textBoxBudgetPlanName.Text) ||
                categories.Count == 0)
            {
                throw new Exception("Имеются незаполненные поля.");
            }
            _budgetPlanRepository.CreateBudgetPlan(BudgetPlan.CreateBudgetPlan(
                0,
                textBoxBudgetPlanName.Text,
                dateTimePickerStart.Value,
                Convert.ToInt32(numericUpDownMonth.Value),
                categories
                ));
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e) => Close();

    private List<BudgetPlanCategory> CreateListBudgetPlanCategoryFromDataGrid()
    {
        var list = new List<BudgetPlanCategory>();
        foreach(DataGridViewRow row in dataGridViewCategories.Rows)
        {
            var category = row.Cells["ColumnCategory"].Value;
            var amountText = row.Cells["ColumnPlannedAmount"].Value;
            if (category is null && amountText is null)
            {
                continue;
            }
            if (category is null || amountText is null)
            {
                throw new Exception("В каждой строке нужно указать статью и сумму.");
            }
            if (!decimal.TryParse(amountText.ToString(), out var amount) || amount < 0)
            {
                throw new Exception("Плановая сумма указана неверно.");
            }
            list.Add(BudgetPlanCategory.CreateBudgetPlanCategory(0, Convert.ToInt32(category), 0, amount));
        }

        return list
               .GroupBy(x => x.CategoryId, x => x.PlannedAmount,
               (id, amounts) => BudgetPlanCategory.CreateBudgetPlanCategory(0, id, 0, amounts.Sum()))
               .ToList();
    }
}
