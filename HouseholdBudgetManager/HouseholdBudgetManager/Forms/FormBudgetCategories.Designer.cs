namespace HouseholdBudgetManager.Forms
{
    partial class FormBudgetCategories
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
            panelBudgetCategory = new Panel();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            dataGridViewBudgetCategory = new DataGridView();
            panelBudgetCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudgetCategory).BeginInit();
            SuspendLayout();
            // 
            // panelBudgetCategory
            // 
            panelBudgetCategory.Controls.Add(buttonDelete);
            panelBudgetCategory.Controls.Add(buttonUpdate);
            panelBudgetCategory.Controls.Add(buttonAdd);
            panelBudgetCategory.Dock = DockStyle.Right;
            panelBudgetCategory.Location = new Point(712, 0);
            panelBudgetCategory.Name = "panelBudgetCategory";
            panelBudgetCategory.Size = new Size(165, 476);
            panelBudgetCategory.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = Properties.Resources.free_icon_delete_button_5974771;
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.Location = new Point(6, 315);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 150);
            buttonDelete.TabIndex = 2;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackgroundImage = Properties.Resources.free_icon_edit_button_6325975;
            buttonUpdate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonUpdate.Location = new Point(3, 159);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(150, 150);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources.free_icon_add_button_5974633;
            buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 150);
            buttonAdd.TabIndex = 0;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewBudgetCategory
            // 
            dataGridViewBudgetCategory.AllowUserToAddRows = false;
            dataGridViewBudgetCategory.AllowUserToDeleteRows = false;
            dataGridViewBudgetCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBudgetCategory.Dock = DockStyle.Fill;
            dataGridViewBudgetCategory.Location = new Point(0, 0);
            dataGridViewBudgetCategory.MultiSelect = false;
            dataGridViewBudgetCategory.Name = "dataGridViewBudgetCategory";
            dataGridViewBudgetCategory.ReadOnly = true;
            dataGridViewBudgetCategory.RowHeadersVisible = false;
            dataGridViewBudgetCategory.RowHeadersWidth = 47;
            dataGridViewBudgetCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBudgetCategory.Size = new Size(712, 476);
            dataGridViewBudgetCategory.TabIndex = 1;
            // 
            // FormBudgetCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 476);
            Controls.Add(dataGridViewBudgetCategory);
            Controls.Add(panelBudgetCategory);
            Name = "FormBudgetCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статьи бюджета";
            Load += FormBudgetCategories_Load;
            panelBudgetCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudgetCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBudgetCategory;
        private DataGridView dataGridViewBudgetCategory;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
    }
}