using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DoToo.ViewModels;

namespace DoToo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        public MainView(MainViewModel viewModel)
        {
            InitializeComponent();

            viewModel.Navigation = Navigation;
            BindingContext = viewModel;
            ItemsListView.ItemSelected += (s, e) =>
            ItemsListView.SelectedItem = null;
        }
    }
}