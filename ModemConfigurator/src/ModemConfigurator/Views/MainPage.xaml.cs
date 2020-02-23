using Prism.Navigation;
using Xamarin.Forms;

namespace ModemConfigurator.Views
{
    public partial class MainPage : MasterDetailPage, IMasterDetailPageOptions
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public bool IsPresentedAfterNavigation
        {
            get { return Device.Idiom != TargetIdiom.Phone; }
        }
    }
}
