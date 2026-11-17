namespace HouseholdBudgetManager.Forms
{
    partial class FormBudgetPlans
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
            dataGridViewBudgetPlans = new DataGridView();
            panelBudgetPlans = new Panel();
            buttonDelete = new Button();
            buttonAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudgetPlans).BeginInit();
            panelBudgetPlans.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewBudgetPlans
            // 
            dataGridViewBudgetPlans.AllowUserToAddRows = false;
            dataGridViewBudgetPlans.AllowUserToDeleteRows = false;
            dataGridViewBudgetPlans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBudgetPlans.Dock = DockStyle.Fill;
            dataGridViewBudgetPlans.Location = new Point(0, 0);
            dataGridViewBudgetPlans.MultiSelect = false;
            dataGridViewBudgetPlans.Name = "dataGridViewBudgetPlans";
            dataGridViewBudgetPlans.ReadOnly = true;
            dataGridViewBudgetPlans.RowHeadersVisible = false;
            dataGridViewBudgetPlans.RowHeadersWidth = 47;
            dataGridViewBudgetPlans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBudgetPlans.Size = new Size(638, 450);
            dataGridViewBudgetPlans.TabIndex = 2;
            // 
            // panelBudgetPlans
            // 
            panelBudgetPlans.Controls.Add(buttonDelete);
            panelBudgetPlans.Controls.Add(buttonAdd);
            panelBudgetPlans.Dock = DockStyle.Right;
            panelBudgetPlans.Location = new Point(638, 0);
            panelBudgetPlans.Name = "panelBudgetPlans";
            panelBudgetPlans.Size = new Size(162, 450);
            panelBudgetPlans.TabIndex = 3;
            // 
            // buttonDelete
            // 
            buttonDelete.BackgroundImage = Properties.Resources.free_icon_delete_button_5974771;
            buttonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDelete.Location = new Point(6, 159);
            buttonDelete.MaximumSize = new Size(150, 150);
            buttonDelete.MinimumSize = new Size(150, 150);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 150);
            buttonDelete.TabIndex = 1;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources.free_icon_add_button_5974633;
            buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd.Location = new Point(6, 3);
            buttonAdd.MaximumSize = new Size(150, 150);
            buttonAdd.MinimumSize = new Size(150, 150);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 150);
            buttonAdd.TabIndex = 0;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // FormBudgetPlans
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewBudgetPlans);
            Controls.Add(panelBudgetPlans);
            Name = "FormBudgetPlans";
            Text = "Планировка бюджета";
            Load += FormBudgetPlans_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBudgetPlans).EndInit();
            panelBudgetPlans.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewBudgetPlans;
        private Panel panelBudgetPlans;
        private Button buttonAdd;
        private Button buttonDelete;
    }
}