using CsvViewer.Core;
using CsvViewer.Modules.CsvOpener.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace CsvViewer.Modules.CsvOpener
{
    public class CsvOpenerModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public CsvOpenerModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RequestNavigate(RegionNames.ContentRegion, "ViewA");
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
        }
    }
}