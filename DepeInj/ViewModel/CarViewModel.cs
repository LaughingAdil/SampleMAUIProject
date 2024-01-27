using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
using DepeInj.View;

namespace DepeInj.ViewModel
{
	public partial class CarViewModel : ObservableObject
	{
        private readonly INavigation _navigation;
        public CarViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        [ObservableProperty]
        string carHonda = "Honda";
        [ObservableProperty]
        string carHondaYear = "2019";

        [ObservableProperty]
        string carHyundai = "Hyundai";
        [ObservableProperty]
        string carHyundaiYear = "2025";

        [RelayCommand]
        void NavigationtoCollection()
        {
            _navigation.PushAsync(new ListingView());
        }
    }
}

