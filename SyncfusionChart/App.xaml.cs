namespace SyncfusionChart
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var viewmodel = new ViewModel();
            MainPage = new MainPage(viewmodel);
        }
    }
}
