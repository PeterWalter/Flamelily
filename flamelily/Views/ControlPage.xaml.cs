using Prism.Navigation;
using Xamarin.Forms;

namespace flamelily.Views
{
    public partial class ControlPage : MasterDetailPage, IMasterDetailPageOptions
    {
        public ControlPage()
        {
            InitializeComponent();
        }

        public bool IsPresentedAfterNavigation => Device.Idiom != TargetIdiom.Phone;
    }
}