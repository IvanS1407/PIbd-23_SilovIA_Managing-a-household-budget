using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Entities.Enums;
using HouseholdBudgetManager.Repositories.Interfaces;
using System.ComponentModel;

namespace HouseholdBudgetManager.Forms;

public partial class FormBudgetCategory : Form
{
    private readonly IBudgetCategoryRepository _repository;

    private int? _budgetCategoryId;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var budgetCategory = _repository.ReadBudgetCategoryById(value);
                if (budgetCategory is null)
                {
                    throw new InvalidDataException(nameof(budgetCategory));
                }

                textBoxNameBudgetCategory.Text = budgetCategory.Name;
                comboBoxBudgetCategory.SelectedItem = budgetCategory.CategoryType;
                foreach (PaymentMethods method in Enum.GetValues(typeof(PaymentMethods)))
                {
                    if (method != PaymentMethods.None && budgetCategory.PaymentMethods.HasFlag(method))
                    {
                        checkedListBoxBudgetCategoryPaymentMethods.SetItemChecked(
                            checkedListBoxBudgetCategoryPaymentMethods.Items.IndexOf(method), true);
                    }
                }
                _budgetCategoryId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public FormBudgetCategory(IBudgetCategoryRepository repository)
    {
        InitializeComponent();
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        comboBoxBudgetCategory.DataSource = Enum.GetValues<CategoryType>()
                                                .Where(x => x != CategoryType.None)
                                                .ToList();
        comboBoxBudgetCategory.SelectedIndex = -1;
        foreach (PaymentMethods method in Enum.GetValues(typeof(PaymentMethods)))
        {
            if (method != PaymentMethods.None)
            {
                checkedListBoxBudgetCategoryPaymentMethods.Items.Add(method);
            }
        }
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxNameBudgetCategory.Text) ||
                comboBoxBudgetCategory.SelectedIndex < 0 ||
                checkedListBoxBudgetCategoryPaymentMethods.CheckedItems.Count == 0)
            {
                throw new Exception("Имеются незаполненные поля");
            }
            if (_budgetCategoryId.HasValue)
            {
                _repository.UpdateBudgetCategory(CreateBudgetCategory(_budgetCategoryId.Value));
            }
            else
            {
                _repository.CreateBudgetCategory(CreateBudgetCategory(0));
            }
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e) => Close();

    private BudgetCategory CreateBudgetCategory(int id)
    {
        PaymentMethods paymentMethods = PaymentMethods.None;
        foreach(var item in checkedListBoxBudgetCategoryPaymentMethods.CheckedItems)
        {
            paymentMethods |= (PaymentMethods)item;
        }
        return BudgetCategory.CreateCategory(
            id,
            textBoxNameBudgetCategory.Text,
            (CategoryType)comboBoxBudgetCategory.SelectedItem!,
            paymentMethods
        );
    }
}
