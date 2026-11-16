namespace HouseholdBudgetManager.Forms
{
    partial class FormBudgetCategory
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
            labelNameBudgetCategory = new Label();
            textBoxNameBudgetCategory = new TextBox();
            comboBoxBudgetCategory = new ComboBox();
            checkedListBoxBudgetCategoryPaymentMethods = new CheckedListBox();
            labelBudgetCategoryType = new Label();
            labelBudgetCategoryPaymentMethods = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelNameBudgetCategory
            // 
            labelNameBudgetCategory.AutoSize = true;
            labelNameBudgetCategory.Location = new Point(12, 9);
            labelNameBudgetCategory.Name = "labelNameBudgetCategory";
            labelNameBudgetCategory.Size = new Size(174, 19);
            labelNameBudgetCategory.TabIndex = 0;
            labelNameBudgetCategory.Text = "Название статьи бюджета";
            // 
            // textBoxNameBudgetCategory
            // 
            textBoxNameBudgetCategory.Location = new Point(12, 31);
            textBoxNameBudgetCategory.Name = "textBoxNameBudgetCategory";
            textBoxNameBudgetCategory.Size = new Size(174, 26);
            textBoxNameBudgetCategory.TabIndex = 1;
            // 
            // comboBoxBudgetCategory
            // 
            comboBoxBudgetCategory.FormattingEnabled = true;
            comboBoxBudgetCategory.Location = new Point(12, 118);
            comboBoxBudgetCategory.Name = "comboBoxBudgetCategory";
            comboBoxBudgetCategory.Size = new Size(139, 27);
            comboBoxBudgetCategory.TabIndex = 2;
            // 
            // checkedListBoxBudgetCategoryPaymentMethods
            // 
            checkedListBoxBudgetCategoryPaymentMethods.FormattingEnabled = true;
            checkedListBoxBudgetCategoryPaymentMethods.Location = new Point(267, 36);
            checkedListBoxBudgetCategoryPaymentMethods.Name = "checkedListBoxBudgetCategoryPaymentMethods";
            checkedListBoxBudgetCategoryPaymentMethods.Size = new Size(326, 109);
            checkedListBoxBudgetCategoryPaymentMethods.TabIndex = 3;
            // 
            // labelBudgetCategoryType
            // 
            labelBudgetCategoryType.AutoSize = true;
            labelBudgetCategoryType.Location = new Point(12, 96);
            labelBudgetCategoryType.Name = "labelBudgetCategoryType";
            labelBudgetCategoryType.Size = new Size(32, 19);
            labelBudgetCategoryType.TabIndex = 4;
            labelBudgetCategoryType.Text = "Тип";
            // 
            // labelBudgetCategoryPaymentMethods
            // 
            labelBudgetCategoryPaymentMethods.AutoSize = true;
            labelBudgetCategoryPaymentMethods.Location = new Point(267, 9);
            labelBudgetCategoryPaymentMethods.Name = "labelBudgetCategoryPaymentMethods";
            labelBudgetCategoryPaymentMethods.Size = new Size(116, 19);
            labelBudgetCategoryPaymentMethods.TabIndex = 5;
            labelBudgetCategoryPaymentMethods.Text = "Способы оплаты";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(267, 237);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(86, 26);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(507, 237);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 26);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormBudgetCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 275);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelBudgetCategoryPaymentMethods);
            Controls.Add(labelBudgetCategoryType);
            Controls.Add(checkedListBoxBudgetCategoryPaymentMethods);
            Controls.Add(comboBoxBudgetCategory);
            Controls.Add(textBoxNameBudgetCategory);
            Controls.Add(labelNameBudgetCategory);
            Name = "FormBudgetCategory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Создание статьи бюджета";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNameBudgetCategory;
        private TextBox textBoxNameBudgetCategory;
        private ComboBox comboBoxBudgetCategory;
        private CheckedListBox checkedListBoxBudgetCategoryPaymentMethods;
        private Label labelBudgetCategoryType;
        private Label labelBudgetCategoryPaymentMethods;
        private Button buttonSave;
        private Button buttonCancel;
    }
}