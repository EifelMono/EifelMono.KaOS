using EifelMono.KaOS;
using EifelMono.KaOS.Implementation;
using Foundation;

[assembly: BackDoor(typeof(EifelMono.KaOS.macOS.Application))]
namespace EifelMono.KaOS.macOS
{
    public class Application : ApplicationCore
    {
        public override bool IsAvailable { get => true; }

        public override string Name
        {
            get
            {
                return Config("CFBundleDisplayName");
            }
        }

        public override string Version
        {
            get
            {
                return Config("CFBundleShortVersionString");
            }
        }

        public override string Build
        {
            get
            {
                return Config("CFBundleVersion");
            }
        }

        public string Config(string key)
        {
            try
            {
                return NSBundle.MainBundle.ObjectForInfoDictionary(key).ToString();
            }
            catch
            {
                return "";
            }
        }
    }
}