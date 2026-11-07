using HouseholdBudgetManager.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Unity;

namespace HouseholdBudgetManager.Forms;

public partial class FormFamilyMembers : Form
{
    private readonly IUnityContainer _container;
    private readonly IFamilyMemberRepository _memberRepository;
    public FormFamilyMembers(IUnityContainer container, IFamilyMemberRepository memberRepository)
    {
        InitializeComponent();
        _container = container ?? throw ArgumentNullException(nameof(memberRepository));
        _memberRepository = memberRepository ?? throw ArgumentNullException(nameof(memberRepository));
    }

    private void LoadList() => dataGridViewFamilyMembers.DataSource = _memberRepository.ReadFamilyMembers();
    private bool TryGetIdentifierFromSelectedRow(out int id)
    {
        id = 0;
        if (dataGridViewFamilyMembers.SelectedRows.Count < 1)
        {
            MessageBox.Show("Нет записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {

    }
}
