using Android.OS;
using HelloWorld.Services;
using Xamarin.Forms;

[assembly:Dependency(typeof(HelloWorld.Droid.Services.PlatformInfo))]
namespace HelloWorld.Droid.Services
{
    public class PlatformInfo : IPlatformInfo
    {
        public string GetModel()
        {
            return $"{Build.Manufacturer} {Build.Model}";
        }

        public string GetVersion()
        {
            return Build.VERSION.Release;
        }
    }
}