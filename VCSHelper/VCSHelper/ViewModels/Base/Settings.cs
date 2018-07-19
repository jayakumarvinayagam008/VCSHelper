using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace VCSHelper.ViewModels.Base
{
    public static class Settings
    {
        public static string UrlBase { get; internal set; }

        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }
    }
}
