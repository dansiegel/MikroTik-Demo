using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ModemConfigurator.Services;
using MvvmHelpers;
using Prism.Commands;
using Prism.Logging;
using Prism.Navigation;
using Prism.Services;
using tik4net.Objects;
using tik4net.Objects.System;
using System.Text.RegularExpressions;
using Humanizer;

namespace ModemConfigurator.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IModemSettings modemSettings, Shiny.Net.IConnectivity connectivity, IDeviceService deviceService) 
            : base(navigationService, pageDialogService, modemSettings, connectivity, deviceService)
        {
            Title = "Menu";
            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
            MenuItems = new ObservableRangeCollection<Grouping<string, MasterMenuItem>>();
            MenuItems.Add(new Grouping<string, MasterMenuItem>("App Settings", new MasterMenuItem[] { new MasterMenuItem
                {
                    Group = "App Settings",
                    FriendlyName = "Modem Connection Settings",
                    Uri = "NavigationPage/ModemSettingsPage",
                    TypeName = "AppSettings"
                }}));

            var types = typeof(SystemResource).Assembly.ExportedTypes.Where(t => t.GetCustomAttributes().Any(a => a is TikEntityAttribute));
            List<MasterMenuItem> menuItems = new List<MasterMenuItem>();
            foreach(var type in types)
            {
                menuItems.Add(new MasterMenuItem
                {
                    Group = Regex.Replace(type.Namespace, @"tik4net\.Objects\.", ""),
                    FriendlyName = type.Name.Humanize(LetterCasing.Title),
                    Uri = $"NavigationPage/{type.Name}Page",
                    TypeName = type.Name
                });
            }

            var groups = from item in menuItems
                         orderby item.Group, item.FriendlyName
                         group item by item.Group into itemGroup
                         select new Grouping<string, MasterMenuItem>(itemGroup.Key, itemGroup);
            MenuItems.AddRange(groups);
        }

        public ObservableRangeCollection<Grouping<string, MasterMenuItem>> MenuItems { get; set; }

        //public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IModemSettings modemSettings) 
        //    : base(navigationService, pageDialogService, modemSettings)
        //{
        //}

        public DelegateCommand<string> NavigateCommand { get; }

        private async void OnNavigateCommandExecuted(string path)
        {
            var result = await NavigationService.NavigateAsync(path);
            if(!result.Success)
            {
                Console.WriteLine(result.Exception);
                await _pageDialogService.DisplayAlertAsync(result.Exception.GetType().Name, result.Exception.Message, "Ok");
            }
        }
    }

    public class MasterMenuItem
    {
        public string Group { get; set; }

        public string FriendlyName { get; set; }

        public string Uri { get; set; }

        public string TypeName { get; set; }
    }
}
