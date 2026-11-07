namespace HouseholdBudgetManager.Forms
{
    partial class FormFamilyMember
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
            labelName = new Label();
            labelSurname = new Label();
            labelLastname = new Label();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            textBoxLastname = new TextBox();
            comboBoxRoles = new ComboBox();
            labelRole = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            labelBirthDate = new Label();
            dateTimePickerBirthDate = new DateTimePicker();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 56);
            labelName.Name = "labelName";
            labelName.Size = new Size(36, 19);
            labelName.TabIndex = 0;
            labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(12, 9);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(66, 19);
            labelSurname.TabIndex = 1;
            labelSurname.Text = "Фамилия";
            // 
            // labelLastname
            // 
            labelLastname.AutoSize = true;
            labelLastname.Location = new Point(10, 105);
            labelLastname.Name = "labelLastname";
            labelLastname.Size = new Size(68, 19);
            labelLastname.TabIndex = 2;
            labelLastname.Text = "Отчество";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(117, 6);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(199, 26);
            textBoxSurname.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(117, 53);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(199, 26);
            textBoxName.TabIndex = 4;
            // 
            // textBoxLastname
            // 
            textBoxLastname.Location = new Point(117, 102);
            textBoxLastname.Name = "textBoxLastname";
            textBoxLastname.Size = new Size(199, 26);
            textBoxLastname.TabIndex = 5;
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Location = new Point(117, 158);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(139, 27);
            comboBoxRoles.TabIndex = 6;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(12, 166);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(39, 19);
            labelRole.TabIndex = 7;
            labelRole.Text = "Роль";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(380, 162);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(86, 26);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(523, 162);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 26);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Location = new Point(380, 6);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(107, 19);
            labelBirthDate.TabIndex = 10;
            labelBirthDate.Text = "Дата рождения";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Location = new Point(380, 37);
            dateTimePickerBirthDate.MaxDate = new DateTime(2026, 11, 7, 0, 0, 0, 0);
            dateTimePickerBirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(229, 26);
            dateTimePickerBirthDate.TabIndex = 11;
            dateTimePickerBirthDate.Value = new DateTime(2026, 11, 7, 0, 0, 0, 0);
            // 
            // FormFamilyMember
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 271);
            Controls.Add(dateTimePickerBirthDate);
            Controls.Add(labelBirthDate);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(labelRole);
            Controls.Add(comboBoxRoles);
            Controls.Add(textBoxLastname);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSurname);
            Controls.Add(labelLastname);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Name = "FormFamilyMember";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Член семьи";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelSurname;
        private Label labelLastname;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private TextBox textBoxLastname;
        private ComboBox comboBoxRoles;
        private Label labelRole;
        private Button buttonSave;
        private Button buttonCancel;
        private Label labelBirthDate;
        private DateTimePicker dateTimePickerBirthDate;
    }
}