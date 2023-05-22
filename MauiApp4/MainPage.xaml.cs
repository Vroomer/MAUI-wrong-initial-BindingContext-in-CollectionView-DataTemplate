using System.Collections.ObjectModel;

namespace MauiApp4;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel mainPageViewModel)
	{
		InitializeComponent();

		BindingContext = mainPageViewModel;
	}
}