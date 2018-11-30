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
using tik4net.Objects.Ip.Hotspot;

namespace ModemConfigurator.ViewModels
{
    public class HotspotActiveDetailPageViewModel : BaseDetailViewModel<HotspotActive>
    {
        public HotspotActiveDetailPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, Services.IModemSettings modemSettings) 
            : base(navigationService, pageDialogService, modemSettings)
        {
            Title = "Hotspot Active Detail";
        }
    }
}
