using HouseholdBudgetManager.Entities;
using HouseholdBudgetManager.Entities.Enums;
using HouseholdBudgetManager.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HouseholdBudgetManager.Forms;

public partial class FormFamilyMember : Form
{
    private readonly IFamilyMemberRepository _repository;
    private int? _memberId;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int Id
    {
        set
        {
            try
            {
                var member = _repository.ReadFamilyMemberById(value);
                if (member is null)
                {
                    throw new InvalidDataException(nameof(member));
                }
                textBoxSurname.Text = member.Surname;
                textBoxName.Text = member.Name;
                textBoxLastname.Text = member.LastName;
                comboBoxRoles.SelectedItem = member.Role;
                _memberId = value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }

    public FormFamilyMember(IFamilyMemberRepository memberRepository)
    {
        InitializeComponent();
        comboBoxRoles.DataSource = Enum.GetValues(typeof(FamilyRole));
        _repository = memberRepository ?? throw new ArgumentNullException(nameof(memberRepository));
    }

    private void buttonSave_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(textBoxSurname.Text) || string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastname.Text) || comboBoxRoles.SelectedIndex < 1)
            {
                throw new Exception("Имеются не заполненные поля.");
            }
            if (_memberId.HasValue)
            {
                _repository.UpdateFamilyMember(CreateMember(_memberId.Value));
            }
            else
            {
                _repository.CreateFamilyMember(CreateMember(0));
            }

            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonCancel_Click(object sender, EventArgs e) => Close();

    private FamilyMember CreateMember(int id) =>
        FamilyMember.CreateMember(
                                    id,
                                    textBoxName.Text,
                                    textBoxSurname.Text,
                                    textBoxLastname.Text,
                                    dateTimePickerBirthDate.Value.Date,
                                    (FamilyRole)comboBoxRoles.SelectedItem!
        );
}
