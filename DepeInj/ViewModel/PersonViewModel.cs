using System;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DepeInj.View;

namespace DepeInj.ViewModel
{
	public partial class PersonViewModel: ObservableObject
	{

        private readonly INavigation _navigation;
        public PersonViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        [ObservableProperty]
		string personName = "null";

        [ObservableProperty]
        string personAge = "null";

        [ObservableProperty]
        string personOccupation = "null";

        [RelayCommand]
        void FetchData()
        {
            
            PersonName = "Adil";
            PersonAge = "35";
            PersonOccupation = "Engineer";
        }


        [RelayCommand]
        void NavigateBtn()
        {
            //count++;
            //MessageBindable3 = $"Clicked {count} times";
            //Vibration.Vibrate(1);


            _navigation.PushAsync(new CarView());

        }
    }
}

