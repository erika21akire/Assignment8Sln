using Assignment8Sln.DataSQL;

namespace Assignment8Sln.Models;

public partial class ToolsPage : ContentPage
{
    public ToolsPage()
    {
        InitializeComponent();
        this.BindingContext = new ToolItemView(this.Navigation);
    }
    private void ToolsBtn_Clicked(object sender, EventArgs e)
    {
       Navigation.PushAsync(new ToolsPage());
    }

    private Tools _currentTool;

    public Tools CurrentTool
    {
        get { return _currentTool; }
        set
        {
            _currentTool = value;

            OnPropertyChanged();
        }
    }
}