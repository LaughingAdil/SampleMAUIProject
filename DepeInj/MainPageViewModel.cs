using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DepeInj.View;
using DepeInj.ViewModel;

namespace DepeInj
{
    public partial class MainPageViewModel : ObservableObject
    {
        
      //  int count = 0;
        //----------------------------------------------Navigation Block

        private readonly INavigation _navigation;
        public MainPageViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        //----------------------------------------

        [ObservableProperty]
        string messageBindable1 = "Click me";

        [ObservableProperty]
        string messageBindable2 = "Welcome to .NET Multi-platform App UI";

        [ObservableProperty]
        string imageSourceBindable = "dotnet_bot.png";

        [ObservableProperty]
        string messageBindable3 = "Click me" ;
        

        [RelayCommand]
         void Clicked()
        {
            //count++;
            //MessageBindable3 = $"Clicked {count} times";
            //Vibration.Vibrate(1);


             _navigation.PushAsync(new PersonDisplay());

        }



    }
}


