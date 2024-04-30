using ProductInformationApp.ViewModels;
using System.Diagnostics;

namespace ProductInformationApp {
    public partial class MainPage : ContentPage {

        public MainPage(MainViewModel mainViewModel) {
            InitializeComponent();
            BindingContext = mainViewModel;
        }

        
        protected override void OnAppearing() {
            base.OnAppearing();
        }

    }

}
