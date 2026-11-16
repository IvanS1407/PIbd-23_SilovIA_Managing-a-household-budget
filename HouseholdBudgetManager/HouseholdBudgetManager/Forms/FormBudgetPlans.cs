using HouseholdBudgetManager.Repositories.Interfaces;
using Unity;

namespace HouseholdBudgetManager.Forms;

public partial class FormBudgetPlans : Form
{
    private readonly IUnityContainer _container;
    private readonly IBudgetPlanRepository _budgetPlanRepository;
    public FormBudgetPlans(IUnityContainer container, IBudgetPlanRepository repository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentException(nameof(container));
        _budgetPlanRepository = repository ?? throw new ArgumentException(nameof(repository));
    }

    private void FormBudgetPlans_Load(object sender, EventArgs e)
    {
        try
        {
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка загрузки", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormBudgetPlan>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка добавления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findInd))
        {
            return;
        }
        if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
        {
            return;
        }
        try
        {
            _budgetPlanRepository.DeleteBudgetPlan(findInd);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList() => dataGridViewBudgetPlans.DataSource = _budgetPlanRepository.ReadBudgetPlans();

    private bool TryGetIdentifierFromSelectedRow(out int id)
    {
        id = 0;
        if (dataGridViewBudgetPlans.SelectedRows.Count < 1)
        {
            MessageBox.Show("Нет выбранной записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        id = Convert.ToInt32(dataGridViewBudgetPlans.SelectedRows[0].Cells["Id"].Value);
        return true;
    }

    
}
