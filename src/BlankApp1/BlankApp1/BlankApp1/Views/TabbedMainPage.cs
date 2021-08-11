
using BlankApp1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using NavigationPage = Xamarin.Forms.NavigationPage;


namespace BlankApp1.Views
{
    public class TabbedMainPage: Xamarin.Forms.TabbedPage
    {
        readonly Xamarin.Forms.Page newsPage;
        readonly Xamarin.Forms.Page productsPage;

        readonly Xamarin.Forms.NavigationPage navigationNewsPage;
        readonly Xamarin.Forms.NavigationPage navigationProductsPage;

        public TabbedMainPage()
        {
            newsPage = new NewsPage();
            navigationNewsPage = new Xamarin.Forms.NavigationPage(newsPage);
            NavigationPage.SetHasNavigationBar(navigationNewsPage, false);

            productsPage = new ProductsPage();
            navigationProductsPage = new Xamarin.Forms.NavigationPage(productsPage);

            On<iOS>().SetTranslucencyMode(TranslucencyMode.Opaque);

            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);

            navigationNewsPage.Title = "News";
            navigationProductsPage.Title = "Products";

            BarBackgroundColor = Color.FromHex("#60034C");
            

            Children.Add(navigationNewsPage);
            Children.Add(navigationProductsPage);
        }
    }
}