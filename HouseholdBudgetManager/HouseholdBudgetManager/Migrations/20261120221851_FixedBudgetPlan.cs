using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseholdBudgetManager.Migrations
{
    /// <inheritdoc />
    public partial class FixedBudgetPlan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BudgetPlanCategories_BudgetPlans_BudgetPlanId1",
                table: "BudgetPlanCategories");

            migrationBuilder.DropIndex(
                name: "IX_BudgetPlanCategories_BudgetPlanId1",
                table: "BudgetPlanCategories");

            migrationBuilder.DropColumn(
                name: "BudgetPlanId1",
                table: "BudgetPlanCategories");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BudgetPlanId1",
                table: "BudgetPlanCategories",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BudgetPlanCategories_BudgetPlanId1",
                table: "BudgetPlanCategories",
                column: "BudgetPlanId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetPlanCategories_BudgetPlans_BudgetPlanId1",
                table: "BudgetPlanCategories",
                column: "BudgetPlanId1",
                principalTable: "BudgetPlans",
                principalColumn: "Id");
        }
    }
}
