using HelloWorld.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlatformInfo : ContentPage
    {
        public PlatformInfo()
        {
            InitializeComponent();
            var platformInfoService = DependencyService.Get<IPlatformInfo>();
            this.ModelLbl.Text = platformInfoService.GetModel();
            this.VersionLbl.Text = platformInfoService.GetVersion();
        }
    }
}