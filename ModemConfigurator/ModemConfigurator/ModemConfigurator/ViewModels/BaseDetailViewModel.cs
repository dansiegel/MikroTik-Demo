using System;
using ModemConfigurator.Services;
using Prism.Navigation;
using Prism.Services;
using Prism.Commands;
using tik4net.Objects;

namespace ModemConfigurator.ViewModels
{
    public class BaseDetailViewModel<TEntity> : ViewModelBase
        where TEntity : new()
    {
        public BaseDetailViewModel(INavigationService navigationService, IPageDialogService pageDialogService, IModemSettings modemSettings) 
            : base(navigationService, pageDialogService, modemSettings)
        {
        }

        public TEntity Entity { get; set; }

        public DelegateCommand SaveCommand { get; }

        public override void OnNavigatingTo(INavigationParameters parameters)
        {
            Entity = parameters.GetValue<TEntity>("Entity");
        }

        private void OnSaveCommandExecuted()
        {
            using(var connection = CreateConnection())
            {
                connection.Save(Entity);
            }
        }
    }
}
