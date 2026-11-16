namespace HouseholdBudgetManager.Forms
{
    partial class FormBudgetPlan
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
            textBoxBudgetPlanName = new TextBox();
            buttonSave = new Button();
            labelBudgetPlanName = new Label();
            buttonCancel = new Button();
            dateTimePickerStart = new DateTimePicker();
            labelDate = new Label();
            dateTimePickerCreated = new DateTimePicker();
            labelDateCreated = new Label();
            numericUpDownMonth = new NumericUpDown();
            labelMonthsFurher = new Label();
            groupBoxCategpries = new GroupBox();
            dataGridViewCategories = new DataGridView();
            ColumnCategory = new DataGridViewComboBoxColumn();
            ColumnPlannedAmount = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonth).BeginInit();
            groupBoxCategpries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            SuspendLayout();
            // 
            // textBoxBudgetPlanName
            // 
            textBoxBudgetPlanName.Location = new Point(163, 5);
            textBoxBudgetPlanName.Name = "textBoxBudgetPlanName";
            textBoxBudgetPlanName.Size = new Size(145, 26);
            textBoxBudgetPlanName.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 160);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(86, 26);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelBudgetPlanName
            // 
            labelBudgetPlanName.AutoSize = true;
            labelBudgetPlanName.Location = new Point(12, 12);
            labelBudgetPlanName.Name = "labelBudgetPlanName";
            labelBudgetPlanName.Size = new Size(145, 19);
            labelBudgetPlanName.TabIndex = 2;
            labelBudgetPlanName.Text = "Наименование плана";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(104, 160);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 26);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.Location = new Point(163, 44);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(115, 26);
            dateTimePickerStart.TabIndex = 4;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(12, 50);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(87, 19);
            labelDate.TabIndex = 5;
            labelDate.Text = "Дата начала";
            // 
            // dateTimePickerCreated
            // 
            dateTimePickerCreated.Enabled = false;
            dateTimePickerCreated.Location = new Point(12, 301);
            dateTimePickerCreated.Name = "dateTimePickerCreated";
            dateTimePickerCreated.Size = new Size(229, 26);
            dateTimePickerCreated.TabIndex = 6;
            // 
            // labelDateCreated
            // 
            labelDateCreated.AutoSize = true;
            labelDateCreated.Location = new Point(12, 279);
            labelDateCreated.Name = "labelDateCreated";
            labelDateCreated.Size = new Size(101, 19);
            labelDateCreated.TabIndex = 7;
            labelDateCreated.Text = "Дата создания";
            // 
            // numericUpDownMonth
            // 
            numericUpDownMonth.Location = new Point(163, 83);
            numericUpDownMonth.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            numericUpDownMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMonth.Name = "numericUpDownMonth";
            numericUpDownMonth.Size = new Size(47, 26);
            numericUpDownMonth.TabIndex = 8;
            numericUpDownMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelMonthsFurher
            // 
            labelMonthsFurher.AutoSize = true;
            labelMonthsFurher.Location = new Point(12, 90);
            labelMonthsFurher.Name = "labelMonthsFurher";
            labelMonthsFurher.Size = new Size(136, 19);
            labelMonthsFurher.TabIndex = 9;
            labelMonthsFurher.Text = "На сколько месяцев";
            // 
            // groupBoxCategpries
            // 
            groupBoxCategpries.Controls.Add(dataGridViewCategories);
            groupBoxCategpries.Location = new Point(333, 5);
            groupBoxCategpries.Name = "groupBoxCategpries";
            groupBoxCategpries.Size = new Size(455, 322);
            groupBoxCategpries.TabIndex = 10;
            groupBoxCategpries.TabStop = false;
            groupBoxCategpries.Text = "Статьи плана";
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Columns.AddRange(new DataGridViewColumn[] { ColumnCategory, ColumnPlannedAmount });
            dataGridViewCategories.Dock = DockStyle.Fill;
            dataGridViewCategories.Location = new Point(3, 22);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowHeadersVisible = false;
            dataGridViewCategories.RowHeadersWidth = 47;
            dataGridViewCategories.Size = new Size(449, 297);
            dataGridViewCategories.TabIndex = 0;
            // 
            // ColumnCategory
            // 
            ColumnCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnCategory.HeaderText = "Статья бюджета";
            ColumnCategory.MinimumWidth = 6;
            ColumnCategory.Name = "ColumnCategory";
            // 
            // ColumnPlannedAmount
            // 
            ColumnPlannedAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColumnPlannedAmount.HeaderText = "Плановая сумма в месяц";
            ColumnPlannedAmount.MinimumWidth = 6;
            ColumnPlannedAmount.Name = "ColumnPlannedAmount";
            // 
            // FormBudgetPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 335);
            Controls.Add(groupBoxCategpries);
            Controls.Add(labelMonthsFurher);
            Controls.Add(numericUpDownMonth);
            Controls.Add(labelDateCreated);
            Controls.Add(dateTimePickerCreated);
            Controls.Add(labelDate);
            Controls.Add(dateTimePickerStart);
            Controls.Add(buttonCancel);
            Controls.Add(labelBudgetPlanName);
            Controls.Add(buttonSave);
            Controls.Add(textBoxBudgetPlanName);
            Name = "FormBudgetPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бюджетный план";
            ((System.ComponentModel.ISupportInitialize)numericUpDownMonth).EndInit();
            groupBoxCategpries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxBudgetPlanName;
        private Button buttonSave;
        private Label labelBudgetPlanName;
        private Button buttonCancel;
        private DateTimePicker dateTimePickerStart;
        private Label labelDate;
        private DateTimePicker dateTimePickerCreated;
        private Label labelDateCreated;
        private NumericUpDown numericUpDownMonth;
        private Label labelMonthsFurher;
        private GroupBox groupBoxCategpries;
        private DataGridView dataGridViewCategories;
        private DataGridViewComboBoxColumn ColumnCategory;
        private DataGridViewComboBoxColumn ColumnPlannedAmount;
    }
}