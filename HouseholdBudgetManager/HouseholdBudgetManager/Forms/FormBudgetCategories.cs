using HouseholdBudgetManager.Repositories.Interfaces;
using Unity;

namespace HouseholdBudgetManager.Forms;

public partial class FormBudgetCategories : Form
{
    private readonly IUnityContainer _container;
    private readonly IBudgetCategoryRepository _repository;

    public FormBudgetCategories(IUnityContainer container, IBudgetCategoryRepository repository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    private void FormBudgetCategories_Load(object sender, EventArgs e)
    {
        try
        {
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList() => dataGridViewBudgetCategory.DataSource = _repository.ReadBudgetCategories();

    private bool TryGetIdentifierFromSelectionRow(out int id)
    {
        id = 0;
        if (dataGridViewBudgetCategory.SelectedRows.Count < 1)
        {
            MessageBox.Show("Нет выбранной записи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        id = Convert.ToInt32(dataGridViewBudgetCategory.SelectedRows[0].Cells["id"].Value);
        return true;
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormBudgetCategory>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectionRow(out var findId))
        {
            return;
        }
        try
        {
            var form = _container.Resolve<FormBudgetCategory>();
            form.Id = findId;
            form.ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при изменении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectionRow(out var findId))
        {
            return;
        }
        if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
        {
            return;
        }
        try
        {
            _repository.DeleteBudgetCategory(findId);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
