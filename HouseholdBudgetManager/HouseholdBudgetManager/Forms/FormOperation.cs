using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Repositories.Interfaces;

namespace HouseholdBudgetManager.Forms;

public partial class FormOperation : Form
{
    private readonly IOperationRepository _operationRepository;
    public FormOperation(IOperationRepository operationRepository,
                         IFamilyMemberRepository familyRepository,
                         IBudgetCategoryRepository categoryRepository)
    {
        InitializeComponent();
        _operationRepository = operationRepository ?? throw new ArgumentNullException(nameof(operationRepository));
        comboBoxFamilyMember.DataSource = familyRepository.ReadFamilyMembers().ToList();
        comboBoxFamilyMember.DisplayMember = "Surname";
        comboBoxFamilyMember.ValueMember = "Id";
        comboBoxFamilyMember.SelectedIndex = -1;

        comboBoxCategory.DataSource = categoryRepository.ReadBudgetCategories().ToList();
        comboBoxCategory.DisplayMember = "Name";
        comboBoxCategory.ValueMember = "Id";
        comboBoxCategory.SelectedIndex = -1;

        dateTimePickerOperation.MaxDate = DateTime.Today;
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (comboBoxFamilyMember.SelectedIndex < 0 || comboBoxCategory.SelectedIndex < 0)
            {
                throw new Exception("Есть не заполненные поля.");
            }
            _operationRepository.CreateOperation(Operation.CreateOperation(
                    0,
                    (int)comboBoxFamilyMember.SelectedValue!,
                    (int)comboBoxCategory.SelectedValue!,
                    numericUpDownAmount.Value,
                    dateTimePickerOperation.Value.Date,
                    textBoxComment.Text
                )
            );
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e) => Close();
}
