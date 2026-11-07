namespace HouseholdBudgetManager
{
    partial class FormBudgetManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripHeader = new MenuStrip();
            catalogToolStripMenuItemEntities = new ToolStripMenuItem();
            familyMembersToolStripMenuItem = new ToolStripMenuItem();
            operationToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            budgetCategoriesToolStripMenuItem = new ToolStripMenuItem();
            operationsBudgetToolStripMenuItem = new ToolStripMenuItem();
            budgetPlansToolStripMenuItem = new ToolStripMenuItem();
            menuStripHeader.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripHeader
            // 
            menuStripHeader.ImageScalingSize = new Size(18, 18);
            menuStripHeader.Items.AddRange(new ToolStripItem[] { catalogToolStripMenuItemEntities, operationToolStripMenuItem, reportsToolStripMenuItem });
            menuStripHeader.Location = new Point(0, 0);
            menuStripHeader.Name = "menuStripHeader";
            menuStripHeader.Size = new Size(908, 27);
            menuStripHeader.TabIndex = 0;
            menuStripHeader.Text = "menuStripHeader";
            // 
            // catalogToolStripMenuItemEntities
            // 
            catalogToolStripMenuItemEntities.DropDownItems.AddRange(new ToolStripItem[] { familyMembersToolStripMenuItem, budgetCategoriesToolStripMenuItem });
            catalogToolStripMenuItemEntities.Name = "catalogToolStripMenuItemEntities";
            catalogToolStripMenuItemEntities.Size = new Size(109, 23);
            catalogToolStripMenuItemEntities.Text = "Справочники";
            // 
            // familyMembersToolStripMenuItem
            // 
            familyMembersToolStripMenuItem.Name = "familyMembersToolStripMenuItem";
            familyMembersToolStripMenuItem.Size = new Size(206, 24);
            familyMembersToolStripMenuItem.Text = "Члены семьи";
            // 
            // operationToolStripMenuItem
            // 
            operationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { operationsBudgetToolStripMenuItem, budgetPlansToolStripMenuItem });
            operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            operationToolStripMenuItem.Size = new Size(88, 23);
            operationToolStripMenuItem.Text = "Операции";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(71, 23);
            reportsToolStripMenuItem.Text = "Отчеты";
            // 
            // budgetCategoriesToolStripMenuItem
            // 
            budgetCategoriesToolStripMenuItem.Name = "budgetCategoriesToolStripMenuItem";
            budgetCategoriesToolStripMenuItem.Size = new Size(206, 24);
            budgetCategoriesToolStripMenuItem.Text = "Статьи бюджета";
            // 
            // operationsBudgetToolStripMenuItem
            // 
            operationsBudgetToolStripMenuItem.Name = "operationsBudgetToolStripMenuItem";
            operationsBudgetToolStripMenuItem.Size = new Size(206, 24);
            operationsBudgetToolStripMenuItem.Text = "Операции";
            // 
            // budgetPlansToolStripMenuItem
            // 
            budgetPlansToolStripMenuItem.Name = "budgetPlansToolStripMenuItem";
            budgetPlansToolStripMenuItem.Size = new Size(206, 24);
            budgetPlansToolStripMenuItem.Text = "Планы бюджета";
            // 
            // FromBudgetManager
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 486);
            Controls.Add(menuStripHeader);
            MainMenuStrip = menuStripHeader;
            Name = "FromBudgetManager";
            Text = "Form1";
            menuStripHeader.ResumeLayout(false);
            menuStripHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripHeader;
        private ToolStripMenuItem catalogToolStripMenuItemEntities;
        private ToolStripMenuItem familyMembersToolStripMenuItem;
        private ToolStripMenuItem operationToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem budgetCategoriesToolStripMenuItem;
        private ToolStripMenuItem operationsBudgetToolStripMenuItem;
        private ToolStripMenuItem budgetPlansToolStripMenuItem;
    }
}
