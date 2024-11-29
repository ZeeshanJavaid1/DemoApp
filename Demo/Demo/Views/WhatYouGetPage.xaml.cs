namespace Demo.Views;

public partial class WhatYouGetPage : ContentPage
{
	public WhatYouGetPage()
	{
		InitializeComponent();
	}
    private void OnContinueClicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new StepsPage());
    }

    private void OnRestoreSubscriptionClicked(object sender, EventArgs e)
    {
        // Restore subscription logic
    }
}
