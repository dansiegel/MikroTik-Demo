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
using tik4net.Objects.User;

namespace ModemConfigurator.ViewModels
{
    public class UserGroupDetailPageViewModel : BaseDetailViewModel<UserGroup>
    {
        public UserGroupDetailPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService, Services.IModemSettings modemSettings) 
            : base(navigationService, pageDialogService, modemSettings)
        {
            Title = "User Group Detail";
        }
    }
}
