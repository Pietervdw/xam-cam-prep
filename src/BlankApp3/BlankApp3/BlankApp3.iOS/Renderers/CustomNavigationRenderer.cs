using BlankApp3.Custom;
using BlankApp3.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomNavigationPage), typeof(CustomNavigationRenderer))]
namespace BlankApp3.iOS.Renderers
{
    public class CustomNavigationRenderer : NavigationRenderer
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            

            NavigationController?.SetNavigationBarHidden(true, true);
            UINavigationBar.Appearance.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);
            UINavigationBar.Appearance.ShadowImage = new UIImage();
            UINavigationBar.Appearance.BackgroundColor = UIColor.Clear;
            UINavigationBar.Appearance.TintColor = UIColor.Clear;
            UINavigationBar.Appearance.BarTintColor = UIColor.Clear;
            UINavigationBar.Appearance.Translucent = true;
        }

 
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }

            base.Dispose(disposing);
        }
    }
}