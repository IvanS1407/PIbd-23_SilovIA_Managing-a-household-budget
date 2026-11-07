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
            dataGridViewFamilyMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFamilyMembers.Dock = DockStyle.Fill;
            dataGridViewFamilyMembers.Location = new Point(0, 0);
            dataGridViewFamilyMembers.Name = "dataGridViewFamilyMembers";
            dataGridViewFamilyMembers.RowHeadersWidth = 47;
            dataGridViewFamilyMembers.Size = new Size(609, 450);
            dataGridViewFamilyMembers.TabIndex = 0;
            // 
            // panelFamilyMembersButtons
            // 
            panelFamilyMembersButtons.Controls.Add(buttonDelete);
            panelFamilyMembersButtons.Controls.Add(buttonUpdate);
            panelFamilyMembersButtons.Controls.Add(buttonAdd);
            panelFamilyMembersButtons.Dock = DockStyle.Right;
            panelFamilyMembersButtons.Location = new Point(609, 0);
            panelFamilyMembersButtons.Name = "panelFamilyMembersButtons";
            panelFamilyMembersButtons.Size = new Size(191, 450);
            panelFamilyMembersButtons.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(3, 76);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(134, 26);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(3, 44);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(134, 26);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Редактировать";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(6, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(131, 26);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormFamilyMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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