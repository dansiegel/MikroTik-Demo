# MikroTik Demo

This demo app is built around the MikroTik .NET Library Tik4Net. This is broken up into two parts:

- Entity Builder
- ModemConfigurator

The Entity Builder is a .NET Core app that will dynamically build Views/ViewModels as well an extension for Prism's IContainerRegistry to register what has been generated. If a newer version of Tik4Net is available just update the NuGet package and re-run the Entity Builder, the ModemConfigurator project will automatically update to use any newly generated entities.

The ModemConfigurator is fairly simple Xamarin.Forms app using Prism. For [@PrismLib](https://twitter.com/PrismLib) fans you'll notice an excess of 100 Views/ViewModels which get registered while still providing an incredibly short hit to the total initialization time.

## Build Note

The ModemConfigurator relies on the [Mobile.BuildTools](https://github.com/dansiegel/Mobile.BuildTools) to inject the App Center app secret. This is intentionally left out of Source Control. To build the app you will need to add a file to the ModemConfigurator project in the same directory as the `App.xaml` named `secrets.json` like the following sample json.

```json
{
  "AppCenterSecret": "{Your App Center Secret}"
}
```