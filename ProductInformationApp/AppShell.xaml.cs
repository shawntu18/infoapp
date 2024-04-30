using ProductInformationApp.Views;

namespace ProductInformationApp {
    public partial class AppShell : Shell {
        public AppShell() {
            InitializeComponent();
            Routing.RegisterRoute("product", typeof(ProductPage));
        }
    }
}
