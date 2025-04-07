using Module10Assignment.Views;

namespace Module10Assignment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AddStudentPage());
        }
    }
}
