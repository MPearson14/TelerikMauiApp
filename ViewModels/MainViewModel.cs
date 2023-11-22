using System.Windows.Input;

namespace TelerikMauiApp.ViewModels
{
    public class MainViewModel : MvvmHelpers.BaseViewModel
    {
        public MainViewModel() { }
        
        public ICommand ComboButtonCommand => new MvvmHelpers.Commands.AsyncCommand(ComboButtonAsync);

        private async Task ComboButtonAsync()
        {
            await Shell.Current.GoToAsync($"/{nameof(ComboPage)}");
        }
    }
}
