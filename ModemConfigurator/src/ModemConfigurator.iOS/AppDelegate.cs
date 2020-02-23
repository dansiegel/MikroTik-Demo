using Foundation;
using Prism;
using Prism.Ioc;
using UIKit;


namespace ModemConfigurator.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary options)
        {
            try
            {
                Prism.DryIoc.PrismContainerExtension.Create();
                Shiny.iOSShinyHost.Init(new ModemStartup());
                global::Xamarin.Forms.Forms.Init();
                //Microsoft.AppCenter.Distribute.Distribute.DontCheckForUpdatesInDebug();

                var app = Xamarin.Forms.Application.Current;
                if(app is null)
                    app = new App();
                LoadApplication(app);
            }
            catch (System.Exception ex)
            {
                System.Diagnostics.Debugger.Break();
            }
            

            return base.FinishedLaunching(uiApplication, options);
        }
    }
}
