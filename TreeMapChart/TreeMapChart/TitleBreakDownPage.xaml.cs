using Microsoft.Maui.Controls.Shapes;

namespace TreeMapChart;

public partial class TitleBreakDownPage : ContentPage
{
	public TitleBreakDownPage(ViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;

        if (viewModel.SelectedCountry != null)
        {
            series.PaletteBrushes = UpdateDataBasedOnSelection(viewModel.SelectedCountry);
            pathData.Data = (Geometry?)(new PathGeometryConverter().ConvertFromInvariantString("M10.42167,25.733974L21.693511,25.733974 23.089492,31.219968 9.0256896,31.219968z M25.682455,4.4889958L25.682455,4.5879955C25.483458,6.9819931 25.084463,9.9749901 24.086477,12.966987 24.386473,12.966987 28.675413,13.365987 30.171391,5.7849941 30.071393,5.8849942 30.27139,4.4889957 28.87441,4.4889958L28.774411,4.4889958z M3.1407728,4.4889958C1.7437916,4.4889957 1.9437895,5.8849942 1.9437895,5.8849943 3.3397694,12.766987 7.0307174,13.066987 7.8287063,13.066987 7.1307163,10.871989 6.5317245,8.1789919 6.3327274,4.7879953L6.3327274,4.4889958 3.3397694,4.4889958z M6.232729,0L25.682455,0C25.682455,0,25.782454,0.89799929,25.782454,2.4939973L25.782454,2.6929972 28.974408,2.6929972C28.974408,2.6929975 32.365361,2.9919972 31.966367,5.8849943 31.966367,5.8849942 30.806497,15.067173 23.729957,14.973529L23.400065,14.962376 23.515435,14.692866C23.574677,14.550345,23.63236,14.407361,23.688483,14.263986L23.787481,13.864986 23.388487,14.961985 23.400065,14.962376 23.333035,15.118966C22.460016,17.100264,21.281517,18.976481,19.797538,20.547979L18.401557,20.547979 18.401557,24.137975 13.813622,24.137975 13.813622,20.547979 12.51664,20.547979C12.51664,20.547979,10.521668,19.050981,8.8256922,15.160985L8.7266936,14.961985 8.4266977,14.961985C1.2457991,15.160985 0.048815727,5.8849942 0.048815727,5.8849943 -0.45017719,2.8929973 3.0407734,2.6929975 3.0407734,2.6929972L6.232729,2.6929972 6.232729,2.1939979z"));
            label.Text = "Total Titles : " + viewModel.SelectedCountryTotalTitles.ToString();
        }
    }

	private void Button_Clicked(object sender, EventArgs e)
	{
		 Navigation.PopAsync();
    }

    private List<Brush> UpdateDataBasedOnSelection(string country)
    {
        return country switch
        {
            "Australia" =>
            [
                 new SolidColorBrush(Color.FromArgb("#ffb300")),
                 new SolidColorBrush(Color.FromArgb("#ffc933")), 
                 new SolidColorBrush(Color.FromArgb("#ffd966")), 
                 new SolidColorBrush(Color.FromArgb("#ffe699")), 
            ],
            "India" =>
            [
                 new SolidColorBrush(Color.FromArgb("#1f8fff")),
                 new SolidColorBrush(Color.FromArgb("#4da6ff")),
                 new SolidColorBrush(Color.FromArgb("#80bdff")),
            ],
            "England" =>
            [
                 new SolidColorBrush(Color.FromArgb("#41b0f1")), 
                 new SolidColorBrush(Color.FromArgb("#6ec0f7")), 
            ],
            "West Indies" =>
            [
                 new SolidColorBrush(Color.FromArgb("#800000")), 
                 new SolidColorBrush(Color.FromArgb("#b13939")), 
                 new SolidColorBrush(Color.FromArgb("#cc6666")), 
            ],
            "Pakistan" =>
            [
                 new SolidColorBrush(Color.FromArgb("#004d00")), 
                 new SolidColorBrush(Color.FromArgb("#339933")), 
                 new SolidColorBrush(Color.FromArgb("#66cc66")), 
            ],
            "Sri Lanka" =>
            [
                 new SolidColorBrush(Color.FromArgb("#00329e")), 
                 new SolidColorBrush(Color.FromArgb("#0056d6")), 
                 new SolidColorBrush(Color.FromArgb("#3388ff")), 
            ],
            "New Zealand" =>
            [
                 new SolidColorBrush(Color.FromArgb("#305050")), 
                 new SolidColorBrush(Color.FromArgb("#6a8a8a")),
            ],
            "South Africa" =>
            [
                 new SolidColorBrush(Color.FromArgb("#228c22")),
                 new SolidColorBrush(Color.FromArgb("#69bf69")), 
            ],
            _ => throw new NotImplementedException()
        };
    }
}