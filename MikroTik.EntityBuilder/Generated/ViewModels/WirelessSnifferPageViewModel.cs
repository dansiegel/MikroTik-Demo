using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using System.Collections.ObjectModel;
using tik4net.Objects;
using tik4net.Objects.Interface.Wireless;

namespace ModemConfigurator.ViewModels
{
    public class WirelessSnifferPageViewModel : BaseCollectionViewModel<WirelessSniffer>
    {
        public WirelessSnifferPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, Services.IModemSettings modemSettings, Shiny.Net.IConnectivity connectivity, IDeviceService deviceService)
            : base(navigationService, pageDialogService, modemSettings, connectivity, deviceService)
        {
            Title = "Wireless Sniffer";
        }
    }
}
