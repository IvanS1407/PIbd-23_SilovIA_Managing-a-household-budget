namespace HouseholdBudgetManager.Forms
{
    partial class FormOperations
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
            panelOperaionsButtons = new Panel();
            buttonAdd = new Button();
            dataGridViewOperations = new DataGridView();
            panelOperaionsButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOperations).BeginInit();
            SuspendLayout();
            // 
            // panelOperaionsButtons
            // 
            panelOperaionsButtons.Controls.Add(buttonAdd);
            panelOperaionsButtons.Dock = DockStyle.Right;
            panelOperaionsButtons.Location = new Point(643, 0);
            panelOperaionsButtons.Name = "panelOperaionsButtons";
            panelOperaionsButtons.Size = new Size(157, 450);
            panelOperaionsButtons.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackgroundImage = Properties.Resources.free_icon_add_button_5974633;
            buttonAdd.BackgroundImageLayout = ImageLayout.Stretch;
            buttonAdd.Location = new Point(3, 3);
            buttonAdd.MaximumSize = new Size(150, 150);
            buttonAdd.MinimumSize = new Size(150, 150);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 150);
            buttonAdd.TabIndex = 1;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewOperations
            // 
            dataGridViewOperations.AllowUserToAddRows = false;
            dataGridViewOperations.AllowUserToDeleteRows = false;
            dataGridViewOperations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOperations.Dock = DockStyle.Fill;
            dataGridViewOperations.Location = new Point(0, 0);
            dataGridViewOperations.MultiSelect = false;
            dataGridViewOperations.Name = "dataGridViewOperations";
            dataGridViewOperations.ReadOnly = true;
            dataGridViewOperations.RowHeadersVisible = false;
            dataGridViewOperations.RowHeadersWidth = 47;
            dataGridViewOperations.Size = new Size(643, 450);
            dataGridViewOperations.TabIndex = 1;
            // 
            // FormOperations
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewOperations);
            Controls.Add(panelOperaionsButtons);
            Name = "FormOperations";
            Text = "Операции";
            Load += FormOperations_Load;
            panelOperaionsButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOperations).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelOperaionsButtons;
        private Button buttonAdd;
        private DataGridView dataGridViewOperations;
    }
}