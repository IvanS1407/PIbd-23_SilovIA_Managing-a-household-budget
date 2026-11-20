using Unity;
using HouseholdBudgetManager.Repositories.Interfaces;
using HouseholdBudgetManager.Repositories;
using Unity.Lifetime;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Serilog;
using Unity.Microsoft.Logging;

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
            Application.Run(CreateContainer().Resolve<FormBudgetManager>());
        }

        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            container.AddExtension(new LoggingExtension(CreateLoggerFactory()));

            container.RegisterType<IConnectionString, NpqsqlConnectionString>(new SingletonLifetimeManager());
            container.RegisterType<IFamilyMemberRepository, FamilyMemberRepository>(new TransientLifetimeManager());
            container.RegisterType<IBudgetCategoryRepository, BudgetCategoryRepository>(new TransientLifetimeManager());
            container.RegisterType<IBudgetPlanRepository, BudgetPlanRepository>(new TransientLifetimeManager());
            container.RegisterType<IOperationRepository, OperationRepository>(new TransientLifetimeManager());

            return container;
        }

        private static LoggerFactory CreateLoggerFactory()
        {
            var loggerFactory = new LoggerFactory();
            loggerFactory.AddSerilog(new LoggerConfiguration()
                         .ReadFrom.Configuration(new ConfigurationBuilder()
                            .SetBasePath(AppContext.BaseDirectory)
                            .AddJsonFile("appsettings.json")
                            .Build())
                         .CreateLogger());

            return loggerFactory;
        }
    }
}