using ProductInformationApp.Models;
using ProductInformationApp.ViewModels;

namespace ProductInformationApp.Views;

public partial class ProductPage : ContentPage
{
	public ProductPage(MainViewModel mainViewModel)
	{
		InitializeComponent();
		BindingContext = mainViewModel;
	}
}