using DepeInj.ViewModel;

namespace DepeInj.View;

public partial class CarView : ContentPage
{
	public CarView()
	{
		InitializeComponent();
		var carViewModel = new CarViewModel(Navigation);
		BindingContext = carViewModel;
	}
}
