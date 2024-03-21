namespace Assignment8Sln.Models;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    
    private void ProductBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ProductsPage());
    }

    private void ToolsBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ToolsPage());
    }


}