using BlankApp1.ViewModels;
using BlankApp1.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace BlankApp1
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDgyNzMwQDMxMzkyZTMyMmUzMGc3SVZ2Z1lsN2Y0dU05K3Vpa0kzSlRDQ28zM0VreFFDYXZiZUU3bSttdnc9");

            
            Sharpnado.Tabs.Initializer.Initialize(false, false);
            Sharpnado.Shades.Initializer.Initialize(loggerEnable: false);

            InitializeComponent();

            await NavigationService.NavigateAsync("TabbedMainPage");
            //await NavigationService.NavigateAsync("SharpnadoPage1");
            //await NavigationService.NavigateAsync("HomePage");
            //await NavigationService.NavigateAsync("SyncfusionTabPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            //containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<TabbedMainPage>();
            containerRegistry.RegisterForNavigation<SharpnadoPage1, SharpnadoPage1ViewModel>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<SyncfusionTabPage, SyncfusionTabPageViewModel>();
            containerRegistry.RegisterForNavigation<PrismTabbedPage1, PrismTabbedPage1ViewModel>();
            containerRegistry.RegisterForNavigation<NewsPage, NewsPageViewModel>();
        }
    }
}
