using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter.Distribute;
using ModemConfigurator.Helpers;
using ModemConfigurator.Services;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ModemConfigurator
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override void Initialize()
        {
            var sw = new Stopwatch();
            sw.Start();
            base.Initialize();
            sw.Stop();
            Console.WriteLine($"Total Initialization: {sw.ElapsedMilliseconds} milliseconds");
        }

        protected override async void OnInitialized()
        {
            Xamarin.Forms.Internals.Log.Listeners.Add(new FormsLogListener());
            Distribute.ReleaseAvailable = OnReleaseAvailable;
            AppCenter.Start(Secrets.AppCenterSecret,
                            typeof(Analytics), typeof(Crashes), typeof(Distribute));
            //await NavigationService.NavigateAsync("/LoadingPage");

            var result = await NavigationService.NavigateAsync("/MainPage/NavigationPage/ModemSettingsPage");
            if (!result.Success)
            {
                Console.WriteLine(result.Exception);
                await NavigationService.NavigateAsync("/ErrorPage", ("exception", result.Exception));
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            InitializeComponent();
            containerRegistry.RegisterSingleton<IModemSettings, ModemSettings>();
            containerRegistry.RegisterForNavigation<Xamarin.Forms.NavigationPage>();
        }

        private bool OnReleaseAvailable(ReleaseDetails releaseDetails)
        {
            // Look at releaseDetails public properties to get version information, release notes text or release notes URL
            string versionName = releaseDetails.ShortVersion;
            string versionCodeOrBuildNumber = releaseDetails.Version;
            string releaseNotes = releaseDetails.ReleaseNotes;
            Uri releaseNotesUrl = releaseDetails.ReleaseNotesUrl;

            // custom dialog
            var title = "Version " + versionName + " available!";
            Task answer;

            // On mandatory update, user cannot postpone
            if (releaseDetails.MandatoryUpdate)
            {
                answer = Current.MainPage.DisplayAlert(title, releaseNotes, "Download and Install");
            }
            else
            {
                answer = Current.MainPage.DisplayAlert(title, releaseNotes, "Download and Install", "Maybe tomorrow...");
            }
            answer.ContinueWith((task) =>
            {
                // If mandatory or if answer was positive
                if (releaseDetails.MandatoryUpdate || (task as Task<bool>).Result)
                {
                    // Notify SDK that user selected update
                    Distribute.NotifyUpdateAction(UpdateAction.Update);
                }
                else
                {
                    // Notify SDK that user selected postpone (for 1 day)
                    // Note that this method call is ignored by the SDK if the update is mandatory
                    Distribute.NotifyUpdateAction(UpdateAction.Postpone);
                }
            });

            // Return true if you are using your own dialog, false otherwise
            return true;
        }
    }
}
