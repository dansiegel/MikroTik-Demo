using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;
using ModemConfigurator.Services;
using tik4net.Objects.System;
using tik4net.Objects;
using System.ComponentModel;

namespace ModemConfigurator.ViewModels
{
    public class ModemSettingsPageViewModel : ViewModelBase
    {
        public ModemSettingsPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IModemSettings modemSettings, Shiny.Net.IConnectivity connectivity, IDeviceService deviceService) 
            : base(navigationService, pageDialogService, modemSettings, connectivity, deviceService)
        {
            Title = "Modem Settings";
            if (ModemSettings is INotifyPropertyChanged inpc)
            {
                inpc.PropertyChanged += OnModemSettingsPropertyChanged;
            }
        }

        public IModemSettings ModemSettings => _modemSettings;

        private void OnModemSettingsPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            try
            {
                CheckConnection();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
        }

        public override void Destroy()
        {
            if(ModemSettings is INotifyPropertyChanged inpc)
            {
                inpc.PropertyChanged -= OnModemSettingsPropertyChanged;
            }
        }
    }
}
