namespace Assignment8Sln.Models;

public partial class Search : ContentPage
{
    public Search()
    {
        InitializeComponent();

        SearchBar.TextChanged += OnSearchTextChanged;
    }

    private void OnSearchTextChanged(object sender, TextChangedEventArgs e)
    {
        // Get the search text from the SearchBar
        string searchText = e.NewTextValue;
    }

}