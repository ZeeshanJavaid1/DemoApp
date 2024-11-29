namespace Demo.Views
{
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
            string selectedPlan = e.Parameter.ToString();

            // Reset all frames' borders and hide ticks
            OneMonthPlan.BorderColor = Colors.Transparent;
            TwelveMonthsPlan.BorderColor = Colors.Transparent;
            SixMonthsPlan.BorderColor = Colors.Transparent;

            TickOneMonth.IsVisible = false;
            TickTwelveMonths.IsVisible = false;
            TickSixMonths.IsVisible = false;

            // Highlight the selected frame and show the tick
            selectedFrame.BorderColor = Colors.Black;

            switch (selectedPlan)
            {
                case "OneMonthPlan":
                    TickOneMonth.IsVisible = true;
                    mostPopular.IsVisible = false;
                    break;

                case "TwelveMonthsPlan":
                    TickTwelveMonths.IsVisible = true;
                    mostPopular.IsVisible = true;
                    break;

                case "SixMonthsPlan":
                    TickSixMonths.IsVisible = true;
                    mostPopular.IsVisible = false;
                    break;
            }
        }
    }
}
