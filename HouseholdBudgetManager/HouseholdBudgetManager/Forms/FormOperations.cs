using HouseholdBudgetManager.Repositories.Interfaces;
using Unity;

namespace HouseholdBudgetManager.Forms;

public partial class FormOperations : Form
{
    private readonly IUnityContainer _container;
    private readonly IOperationRepository _operationRepository;

    public FormOperations(IUnityContainer container, IOperationRepository operationRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _operationRepository = operationRepository ?? throw new ArgumentNullException(nameof(operationRepository));
    }

    private void FormOperations_Load(object sender, EventArgs e)
    {
        try
        {
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при загрузке.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormOperation>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при добавлении.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadList() => dataGridViewOperations.DataSource = _operationRepository.ReadOperations();
}
