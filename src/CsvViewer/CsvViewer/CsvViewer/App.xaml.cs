using CsvViewer.Modules.ModuleName;
using CsvViewer.Services;
using CsvViewer.Services.Interfaces;
using CsvViewer.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;

namespace CsvViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ModuleNameModule>();
        }
    }
}
