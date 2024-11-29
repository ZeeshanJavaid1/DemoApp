namespace Demo.Views;

public partial class SubscriptionPage : ContentPage
{
	public SubscriptionPage()
	{
		InitializeComponent();
	}
    private void OnPlanTapped(object sender, TappedEventArgs e)
    {
        // Get the selected frame
        var selectedFrame = (Frame)sender;

        // Reset all frames' borders to transparent
        OneMonthPlan.BorderColor = Colors.Transparent;
        TwelveMonthsPlan.BorderColor = Colors.Transparent;
        SixMonthsPlan.BorderColor = Colors.Transparent;

        // Highlight the selected frame
        selectedFrame.BorderColor = Colors.Black;
        
    }
}
