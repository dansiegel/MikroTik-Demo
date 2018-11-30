using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;
using Prism.Logging;
using Prism.Services;

namespace ModemConfigurator.ViewModels
{
    public class ErrorPageViewModel : ViewModelBase
    {
        public ErrorPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, Services.IModemSettings modemSettings) 
            : base(navigationService, pageDialogService, modemSettings)
        {
        }

        public string ErrorText { get; set; }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            ErrorText = parameters.GetValue<Exception>("exception").ToString();
        }
    }
}
