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
using tik4net.Objects.Routing.Bgp;

namespace ModemConfigurator.ViewModels
{
    public class BgpAdvertisementsPageViewModel : BaseCollectionViewModel<BgpAdvertisements>
    {
        public BgpAdvertisementsPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, Services.IModemSettings modemSettings, Shiny.Net.IConnectivity connectivity, IDeviceService deviceService)
            : base(navigationService, pageDialogService, modemSettings, connectivity, deviceService)
        {
            Title = "Bgp Advertisements";
        }
    }
}
