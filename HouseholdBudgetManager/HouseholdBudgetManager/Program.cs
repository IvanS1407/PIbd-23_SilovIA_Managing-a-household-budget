using Unity;
using HouseholdBudgetManager.Repositories.Interfaces;
using HouseholdBudgetManager.Repositories;
using Unity.Lifetime;

namespace HouseholdBudgetManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormBudgetManager());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IFamilyMemberRepository, FamilyMemberRepository>(new TransientLifetimeManager());
            container.RegisterType<IBudgetCategoryRepository, BudgetCategoryRepository>(new TransientLifetimeManager());
            container.RegisterType<IBudgetPlansRepository, BudgetPlansRepository>(new TransientLifetimeManager());
            container.RegisterType<IOperationRepository, OperationsRepository>(new TransientLifetimeManager());

            return container;
        }
    }
}