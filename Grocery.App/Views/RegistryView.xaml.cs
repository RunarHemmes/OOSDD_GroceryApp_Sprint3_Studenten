using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class RegistryView : ContentPage
{
	public RegistryView(RegistryViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}