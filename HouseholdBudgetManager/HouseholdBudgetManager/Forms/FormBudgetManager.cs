using HouseholdBudgetManager.Forms;
using Unity;

namespace HouseholdBudgetManager;

public partial class FormBudgetManager : Form
{
    private readonly IUnityContainer _container;

    public FormBudgetManager(IUnityContainer container)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
    }

    private void familyMembersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormFamilyMembers>().ShowDialog();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void budgetCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormBudgetCategories>().ShowDialog();
        }
        catch(Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
