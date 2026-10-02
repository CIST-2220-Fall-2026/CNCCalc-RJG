namespace CNCCalc;

using CNCCalc.Models;
public partial class FeedRateCalcPage : ContentPage
{
	public FeedRateCalcPage()
	{
		InitializeComponent();
	}

    private void submitButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Get the values from the entries  
            float spindleSpeed = float.Parse(spindleSpeedEntry.Text);
            float chipLoad = float.Parse(chipLoadEntry.Text);
            float numberOfFlutes = float.Parse(flutesEntry.Text);

            // Enter the values from the entries into the FeedRateCalc class and calculate the feed rate
            FeedRateCalc feedRateCalc = new FeedRateCalc(spindleSpeed, chipLoad, numberOfFlutes);

            // Display results in the resultLabel
            resultLabel.Text = $"Feed Rate: {feedRateCalc.FeedRate} in/min";
        }
        catch (FormatException)
        {
            resultLabel.Text = "Please enter valid numeric values.";
        }
        catch (Exception ex)
        {
            resultLabel.Text = $"An error occurred: {ex.Message}";
        }
    }
}