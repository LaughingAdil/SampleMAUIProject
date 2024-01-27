namespace DepeInj.View;
using DepeInj.ViewModel;


public partial class PersonDisplay : ContentPage
{
    

    public PersonDisplay()
	{

		InitializeComponent();
        var personViewModel = new PersonViewModel(Navigation);

        BindingContext = personViewModel;

    }
}
