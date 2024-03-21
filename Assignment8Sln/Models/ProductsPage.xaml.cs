using Assignment8Sln.DataSQL;

namespace Assignment8Sln.Models;

public partial class ProductsPage : ContentPage
{

	public ProductsPage()
	{
		InitializeComponent();
		this.BindingContext = new ProductItemView(this.Navigation);
	}
	private void ProductBtn_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ProductsPage());
	}

	private Products _currentProduct;

	public Products CurrentProduct
	{ 
		get { return _currentProduct; }
		set
		{
			_currentProduct = value;

			OnPropertyChanged();
		}
	}
}