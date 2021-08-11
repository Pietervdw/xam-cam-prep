using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace BlankApp1.ViewModels
{
    public class SharpnadoPage1ViewModel : ViewModelBase
    {
        private int _selectedIndex;
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set { SetProperty(ref _selectedIndex, value); }
        }
        public SharpnadoPage1ViewModel(INavigationService navigationService) : base(navigationService)
        {
            SelectedIndex = 0;
        }
    }
}
