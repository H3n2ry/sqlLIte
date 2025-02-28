namespace sqlLIte
{
    public partial class App : Application
    {
        public App()
        {
                InitializeComponent();

                MainPage = new NavigationPage(new views.ListaProduto());
        }
    }
}
