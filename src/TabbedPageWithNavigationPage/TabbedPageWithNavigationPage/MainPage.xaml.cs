using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using TabbedPage = Xamarin.Forms.TabbedPage;

namespace TabbedPageWithNavigationPage
{
	public partial class MainPage : TabbedPage
	{
		public MainPage ()
		{
			InitializeComponent ();

            //Xamarin.Forms.PlatformConfiguration.AndroidSpecific.TabbedPage.SetIsSwipePagingEnabled(this, false);
			//https://stackoverflow.com/questions/45820704/xamarin-forms-disable-swipe-between-pages-in-tabbedpage/47039814#47039814
            
		}
	}
}

