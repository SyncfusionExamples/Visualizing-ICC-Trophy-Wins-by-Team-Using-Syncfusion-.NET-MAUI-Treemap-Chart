using Syncfusion.Maui.TreeMap;

namespace TreeMapChart
{
    public partial class MainPage : ContentPage
    {
        private readonly ViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();
            _viewModel = new ViewModel();
            this.BindingContext = _viewModel;

            treeMapChart.LeafItemBrushSettings = new TreeMapPaletteBrushSettings()
            {
                Brushes = new List<Brush>()
                {
                    new SolidColorBrush(Color.FromArgb("#FFB100")),
                    new SolidColorBrush(Color.FromArgb("#1E90FF")),
                    new SolidColorBrush(Color.FromArgb("#800000")),
                    new SolidColorBrush(Color.FromArgb("#006600")),
                    new SolidColorBrush(Color.FromArgb("#35CAFE")),
                    new SolidColorBrush(Color.FromArgb("#0033A0")),
                    new SolidColorBrush(Color.FromArgb("#2F4F4F")),
                    new SolidColorBrush(Color.FromArgb("#228B22")),
                }
            };
        }

        private void TreeMapChart_SelectionChanged(object sender, TreeMapSelectionChangedEventArgs e)
        {
            if (sender is SfTreeMap treeMap)
            {
                // Retrieve the selected item's country name
                string? selectedCountry = treeMap.SelectedItems.FirstOrDefault()?.PrimaryValueText;
                
                if (selectedCountry != null)
                {
                    // Update data based on the selected country
                    UpdateDataBasedOnSelection(selectedCountry);
                    _viewModel.SelectedCountry = selectedCountry;

                    // Navigate to DrillDownPage with updated data
                    Navigation.PushAsync(new TitleBreakDownPage(_viewModel));
                }
            }
        }

        /// <summary>
        /// Updates the ViewModel's data based on the selected country.
        /// </summary>
        /// <param name="country">The selected country.</param>
        private void UpdateDataBasedOnSelection(string country)
        {
            _viewModel.SelectedCountryTotalTitles = country switch
            {
                "Australia" => 10,
                "India" => 7,
                "England" => 3,
                "West Indies" => 5,
                "Pakistan" => 3,
                "Sri Lanka" => 3,
                "South Africa" => 2,
                "New Zealand" => 2,
                _ => 0
            };

            _viewModel.SelectedCountryDetails = country switch
            {
                "Australia" =>
                [
                    new() { Category = "ODI World Cups", Titles = 6 },
                    new() { Category = "T20 World Cups", Titles = 1 },
                    new() { Category = "Champions Trophies", Titles = 2 },
                    new() { Category = "WTC", Titles = 1 }
                ],
                "India" =>
                [
                    new() { Category = "ODI World Cups", Titles = 2 },
                    new() { Category = "T20 World Cups", Titles = 2 },
                    new() { Category = "Champions Trophies", Titles = 3 },
                ],
                "England" =>
                [
                    new() { Category = "ODI World Cups", Titles = 1 },
                    new() { Category = "T20 World Cups", Titles = 2 },
                ],
                "West Indies" =>
                [
                    new() { Category = "ODI World Cups", Titles = 2 },
                    new() { Category = "T20 World Cups", Titles = 2 },
                    new() { Category = "Champions Trophies", Titles = 1 },
                ],
                "Pakistan" =>
                [
                    new() { Category = "ODI World Cups", Titles = 1 },
                    new() { Category = "T20 World Cups", Titles = 1 },
                    new() { Category = "Champions Trophies", Titles = 1 },
                ],
                "Sri Lanka" =>
                [
                    new() { Category = "ODI World Cups", Titles = 1 },
                    new() { Category = "T20 World Cups", Titles = 1 },
                    new() { Category = "Champions Trophies", Titles = 1 },
                ],
                "South Africa" =>
                [
                    new() { Category = "Champions Trophies", Titles = 1 },
                    new() { Category = "WTC", Titles = 1 }
                ],
                "New Zealand" =>
                [
                    new() { Category = "Champions Trophies", Titles = 1 },
                    new() { Category = "WTC", Titles = 1 }
                ],
                _ => throw new NotImplementedException()
            };
        }
    }
}
