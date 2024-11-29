using Demo.ViewModels;

namespace Demo.Views;

public partial class StepsPage : ContentPage
{
    INavigation navigation { get; set; }
    int count = 0;
    MainViewModel mainViewModel;
    public StepsPage()
    {
        mainViewModel = new MainViewModel();
        BindingContext = mainViewModel;
        InitializeComponent();
    }

}
