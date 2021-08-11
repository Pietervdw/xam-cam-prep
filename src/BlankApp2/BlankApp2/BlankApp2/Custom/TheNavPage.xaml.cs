using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlankApp2.Custom
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TheNavPage : NavigationPage
    {
        public TheNavPage()
        {
            InitializeComponent();
        }
    }
}