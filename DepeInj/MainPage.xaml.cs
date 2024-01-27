namespace DepeInj;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
		var mainPageViewModel = new MainPageViewModel(Navigation);

        BindingContext = mainPageViewModel;

		
	}

    

}


