namespace HouseholdBudgetManager.Forms
{
    partial class FormFamilyMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewFamilyMembers = new DataGridView();
            panelFamilyMembersButtons = new Panel();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFamilyMembers).BeginInit();
            panelFamilyMembersButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewFamilyMembers
            // 
            dataGridViewFamilyMembers.AllowUserToAddRows = false;
            dataGridViewFamilyMembers.AllowUserToDeleteRows = false;
            dataGridViewFamilyMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFamilyMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFamilyMembers.Dock = DockStyle.Fill;
            dataGridViewFamilyMembers.Location = new Point(0, 0);
            dataGridViewFamilyMembers.MultiSelect = false;
            dataGridViewFamilyMembers.Name = "dataGridViewFamilyMembers";
            dataGridViewFamilyMembers.ReadOnly = true;
            dataGridViewFamilyMembers.RowHeadersVisible = false;
            dataGridViewFamilyMembers.RowHeadersWidth = 47;
            dataGridViewFamilyMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFamilyMembers.Size = new Size(673, 369);
            dataGridViewFamilyMembers.TabIndex = 0;
            // 
            // panelFamilyMembersButtons
            // 
            panelFamilyMembersButtons.Controls.Add(buttonDelete);
            panelFamilyMembersButtons.Controls.Add(buttonUpdate);
            panelFamilyMembersButtons.Controls.Add(buttonAdd);
            panelFamilyMembersButtons.Dock = DockStyle.Right;
            panelFamilyMembersButtons.Location = new Point(673, 0);
            panelFamilyMembersButtons.Name = "panelFamilyMembersButtons";
            panelFamilyMembersButtons.Size = new Size(127, 369);
            panelFamilyMembersButtons.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = Properties.Resources.free_icon_delete_button_5974771;
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.Location = new Point(6, 245);
            buttonDelete.MaximumSize = new Size(115, 115);
            buttonDelete.MinimumSize = new Size(115, 115);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(115, 115);
            buttonDelete.TabIndex = 2;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackgroundImage = Properties.Resources.free_icon_edit_button_6325975;
            buttonUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUpdate.Location = new Point(6, 124);
            buttonUpdate.MaximumSize = new Size(115, 115);
            buttonUpdate.MinimumSize = new Size(115, 115);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(115, 115);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources.free_icon_add_button_5974633;
            buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd.Location = new Point(6, 3);
            buttonAdd.MaximumSize = new Size(115, 115);
            buttonAdd.MinimumSize = new Size(115, 115);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(115, 115);
            buttonAdd.TabIndex = 0;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormFamilyMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 369);
            Controls.Add(dataGridViewFamilyMembers);
            Controls.Add(panelFamilyMembersButtons);
            Name = "FormFamilyMembers";
            Text = "FormFamilyMembers";
            ((System.ComponentModel.ISupportInitialize)dataGridViewFamilyMembers).EndInit();
            panelFamilyMembersButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewFamilyMembers;
        private Panel panelFamilyMembersButtons;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
    }
}