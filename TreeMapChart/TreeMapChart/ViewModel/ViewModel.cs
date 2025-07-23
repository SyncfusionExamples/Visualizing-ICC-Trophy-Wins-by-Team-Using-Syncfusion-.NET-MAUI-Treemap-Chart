using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TreeMapChart
{
    /// <summary>
    /// ViewModel class responsible for managing cricket data and notifying views of changes.
    /// </summary>
    public partial class ViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<WorldCupStats>? _countryTitles;

        /// <summary>
        /// Gets or sets the collection of WorldCupStats data for overall country title statistics.
        /// </summary>
        public ObservableCollection<WorldCupStats>? CountryTitles
        {
            get => _countryTitles;
            set
            {
                if (_countryTitles != value)
                {
                    _countryTitles = value;
                    OnPropertyChanged(nameof(CountryTitles));
                }
            }
        }

        private string? _selectedCountry;
        public string? SelectedCountry
        {
            get => _selectedCountry;
            set
            {
                if (_selectedCountry != value)
                {
                    _selectedCountry = value;
                    OnPropertyChanged(nameof(SelectedCountry));
                }
            }
        }

        private int? _selectedCountryTotalTitles;
        public int? SelectedCountryTotalTitles
        {
            get => _selectedCountryTotalTitles;
            set
            {
                if (_selectedCountryTotalTitles != value)
                {
                    _selectedCountryTotalTitles = value;
                    OnPropertyChanged(nameof(SelectedCountryTotalTitles));
                }
            }
        }

        private ObservableCollection<WorldCupStats>? _selectedCountryDetails;

        /// <summary>
        /// Gets or sets the collection for the selected country's detailed title breakdown.
        /// </summary>
        public ObservableCollection<WorldCupStats>? SelectedCountryDetails
        {
            get => _selectedCountryDetails;
            set
            {
                if (_selectedCountryDetails != value)
                {
                    _selectedCountryDetails = value;
                    OnPropertyChanged(nameof(SelectedCountryDetails));
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the ViewModel class and loads initial data.
        /// </summary>
        public ViewModel()
        {
            CountryTitles = LoadCountryTitles();
        }

        /// <summary>
        /// Static method to get the initial collection of cricket titles.
        /// </summary>
        private static ObservableCollection<WorldCupStats> LoadCountryTitles()
        {
            // Initialize collection with predefined cricket statistics
            return
            [
                new WorldCupStats { Country = "Australia", TotalTitles = 10 },
                new WorldCupStats { Country = "India", TotalTitles = 7 },
                new WorldCupStats { Country = "West Indies", TotalTitles = 5 },
                new WorldCupStats { Country = "Pakistan", TotalTitles = 3 },
                new WorldCupStats { Country = "England", TotalTitles = 3 },
                new WorldCupStats { Country = "Sri Lanka", TotalTitles = 3 },
                new WorldCupStats { Country = "New Zealand", TotalTitles = 2 },
                new WorldCupStats { Country = "South Africa", TotalTitles = 2 },
            ];
        }

        #region INotifyPropertyChanged Implementation

        /// <summary>
        /// Event to notify clients that a property value has changed.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Raises the PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed.</param>
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}