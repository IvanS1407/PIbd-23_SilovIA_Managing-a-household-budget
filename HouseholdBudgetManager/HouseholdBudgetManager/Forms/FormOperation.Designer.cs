namespace HouseholdBudgetManager.Forms
{
    partial class FormOperation
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
            comboBoxFamilyMember = new ComboBox();
            comboBoxCategory = new ComboBox();
            labelFamilyMember = new Label();
            labelCategory = new Label();
            numericUpDownAmount = new NumericUpDown();
            labelAmount = new Label();
            dateTimePickerOperation = new DateTimePicker();
            labelDate = new Label();
            textBoxComment = new TextBox();
            labelComment = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // comboBoxFamilyMember
            // 
            comboBoxFamilyMember.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFamilyMember.FormattingEnabled = true;
            comboBoxFamilyMember.Location = new Point(12, 83);
            comboBoxFamilyMember.Name = "comboBoxFamilyMember";
            comboBoxFamilyMember.Size = new Size(220, 27);
            comboBoxFamilyMember.TabIndex = 0;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(242, 83);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(222, 27);
            comboBoxCategory.TabIndex = 1;
            // 
            // labelFamilyMember
            // 
            labelFamilyMember.AutoSize = true;
            labelFamilyMember.Location = new Point(12, 61);
            labelFamilyMember.Name = "labelFamilyMember";
            labelFamilyMember.Size = new Size(82, 19);
            labelFamilyMember.TabIndex = 2;
            labelFamilyMember.Text = "Член семьи";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(242, 61);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(112, 19);
            labelCategory.TabIndex = 3;
            labelCategory.Text = "Статья бюджета";
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(12, 32);
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(138, 26);
            numericUpDownAmount.TabIndex = 4;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(12, 9);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(52, 19);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "Сумма";
            // 
            // dateTimePickerOperation
            // 
            dateTimePickerOperation.Location = new Point(470, 84);
            dateTimePickerOperation.Name = "dateTimePickerOperation";
            dateTimePickerOperation.Size = new Size(229, 26);
            dateTimePickerOperation.TabIndex = 6;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(470, 61);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(105, 19);
            labelDate.TabIndex = 7;
            labelDate.Text = "Дата операции";
            // 
            // textBoxComment
            // 
            textBoxComment.Location = new Point(13, 204);
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(686, 26);
            textBoxComment.TabIndex = 8;
            // 
            // labelComment
            // 
            labelComment.AutoSize = true;
            labelComment.Location = new Point(13, 182);
            labelComment.Name = "labelComment";
            labelComment.Size = new Size(97, 19);
            labelComment.TabIndex = 9;
            labelComment.Text = "Комментарий";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(13, 303);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(86, 26);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(608, 303);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 26);
            buttonCancel.TabIndex = 11;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormOperation
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 341);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelComment);
            Controls.Add(textBoxComment);
            Controls.Add(labelDate);
            Controls.Add(dateTimePickerOperation);
            Controls.Add(labelAmount);
            Controls.Add(numericUpDownAmount);
            Controls.Add(labelCategory);
            Controls.Add(labelFamilyMember);
            Controls.Add(comboBoxCategory);
            Controls.Add(comboBoxFamilyMember);
            Name = "FormOperation";
            Text = "FormOperation";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxFamilyMember;
        private ComboBox comboBoxCategory;
        private Label labelFamilyMember;
        private Label labelCategory;
        private NumericUpDown numericUpDownAmount;
        private Label labelAmount;
        private DateTimePicker dateTimePickerOperation;
        private Label labelDate;
        private TextBox textBoxComment;
        private Label labelComment;
        private Button buttonSave;
        private Button buttonCancel;
    }
}