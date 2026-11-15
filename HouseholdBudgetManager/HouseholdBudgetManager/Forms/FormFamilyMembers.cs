using HouseholdBudgetManager.Repositories.Interfaces;
using Unity;

namespace HouseholdBudgetManager.Forms;

public partial class FormFamilyMembers : Form
{
    private readonly IUnityContainer _container;
    private readonly IFamilyMemberRepository _memberRepository;
    public FormFamilyMembers(IUnityContainer container, IFamilyMemberRepository memberRepository)
    {
        InitializeComponent();
        _container = container ?? throw new ArgumentNullException(nameof(container));
        _memberRepository = memberRepository ?? throw new ArgumentNullException(nameof(memberRepository));
    }

    private void LoadList() => dataGridViewFamilyMembers.DataSource = _memberRepository.ReadFamilyMembers();

    private void FormFamilyMembers_Load(object sender, EventArgs e)
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

    private bool TryGetIdentifierFromSelectedRow(out int id)
    {
        id = 0;
        if (dataGridViewFamilyMembers.SelectedRows.Count < 1)
        {
            MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        id = Convert.ToInt32(dataGridViewFamilyMembers.SelectedRows[0].Cells["id"].Value);
        return true;
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        try
        {
            _container.Resolve<FormFamilyMember>().ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
        if (!TryGetIdentifierFromSelectedRow(out var findInd))
        {
            return;
        }

        try
        {
            var form = _container.Resolve<FormFamilyMember>();
            form.Id = findInd;
            form.ShowDialog();
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _memberRepository.DeleteFamilyMember(findInd);
            LoadList();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при удалении.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
