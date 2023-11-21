namespace SyncfusionChart
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage(ViewModel viewmodel)
        {
            InitializeComponent();
            BindingContext = viewmodel;
        }
    }

}
