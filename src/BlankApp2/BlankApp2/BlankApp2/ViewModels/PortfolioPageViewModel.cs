using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace BlankApp2.ViewModels
{
    public class PortfolioPageViewModel : ViewModelBase
    {
        public PortfolioPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
