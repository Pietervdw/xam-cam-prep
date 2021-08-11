using BlankApp2.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using NavigationPage = Xamarin.Forms.NavigationPage;

namespace BlankApp2.Views
{
    public class TabbedMainPage : Xamarin.Forms.TabbedPage
    {
        readonly Xamarin.Forms.Page newsPage;
        readonly Xamarin.Forms.Page productsPage;
        readonly Xamarin.Forms.Page portfolioPage;
        readonly Xamarin.Forms.Page profilePage;

        readonly Xamarin.Forms.NavigationPage navigationNewsPage;
        readonly Xamarin.Forms.NavigationPage navigationProductsPage;
        readonly Xamarin.Forms.NavigationPage navigationPortfolioPage;
        readonly Xamarin.Forms.NavigationPage navigationProfilePage;

        public TabbedMainPage()
        {
            newsPage = new NewsPage();
            productsPage = new ProductsPage();
            portfolioPage = new PortfolioPage();
            profilePage = new ProfilePage();

            navigationNewsPage = new NavigationPage(newsPage);
            navigationProductsPage = new NavigationPage(productsPage);
            navigationPortfolioPage = new NavigationPage(portfolioPage);
            navigationProfilePage = new NavigationPage(profilePage);

            On<iOS>().SetTranslucencyMode(TranslucencyMode.Opaque);
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

            navigationNewsPage.Title = "News";
            navigationNewsPage.IconImageSource = ImageSource.FromFile("newspaper.png");

            navigationProductsPage.Title = "Products";
            navigationProductsPage.IconImageSource = ImageSource.FromFile("list.png");

            navigationPortfolioPage.Title = "Portfolio";
            navigationPortfolioPage.IconImageSource = ImageSource.FromFile("graph.png");

            navigationProfilePage.Title = "Profile";

            UnselectedTabColor = Color.White;
            BarBackgroundColor = Color.FromHex("#1D3058");
            SelectedTabColor = Color.FromHex("#9FBEFF");

            Children.Add(navigationNewsPage);
            Children.Add(navigationProductsPage);
            Children.Add(navigationPortfolioPage);
            //Children.Add(navigationProfilePage);
        }
    }
}