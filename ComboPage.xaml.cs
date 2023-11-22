using TelerikMauiApp.ViewModels;

namespace TelerikMauiApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ComboPage : ContentPage
    {
        public ComboPage()
        {
            InitializeComponent();
            BindingContext = new ComboViewModel();
        }
    }
}