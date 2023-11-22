using System.Collections.ObjectModel;
using TelerikMauiApp.Models;

namespace TelerikMauiApp.ViewModels
{
    public class ComboViewModel : MvvmHelpers.BaseViewModel
    {
        public ComboViewModel() { }

        private ObservableCollection<CityModel> _Cities = new ObservableCollection<CityModel> 
        { 
            new (1, "Aberdeen"), 
            new (2, "Dundee"), 
            new (3, "Edinburgh"), 
            new (4, "Glasgow") 
        };

        private ObservableCollection<object> _SelectedCities = [];        

        private ObservableCollection<object> _SelectedCitiesPlaceholder = [];

        public ObservableCollection<CityModel> Cities
        {
            get => _Cities;
            set => SetProperty(ref _Cities, value);
        }

        public ObservableCollection<object> SelectedCities
        {
            get => _SelectedCities;
            set
            {
                if (_SelectedCities != value)
                {
                    _SelectedCities = value;
                    OnPropertyChanged(nameof(SelectedCities));
                }
            }
        }

        public ObservableCollection<object> SelectedCitiesPlaceholder
        {
            get => _SelectedCitiesPlaceholder;
            set
            {
                if (_SelectedCitiesPlaceholder != value)
                {
                    _SelectedCitiesPlaceholder = value;

                    OnPropertyChanged(nameof(SelectedCitiesPlaceholder));
                }
            }
        }
    }
}
