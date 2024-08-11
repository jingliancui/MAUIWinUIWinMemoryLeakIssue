namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NewWindowsBtn_Clicked(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(PageNumber.Text); i++)
            {
                Application.Current?.OpenWindow(new Window(new WebPage()));
            }
        }

        private void CloseWindowsBtn_Clicked(object sender, EventArgs e)
        {
            var wins = Application.Current!.Windows.Where(d => d.Page is WebPage).ToList();
            var count = wins.Count();
            for (int i = 0; i < count; i++)
            {
                Application.Current.CloseWindow(wins[i]);
            }
        }
    }

}
