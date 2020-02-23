using System;
using System.Collections.ObjectModel;
using Prism.Navigation;
using tik4net.Objects;
using Prism.Services;
using Prism.Commands;

namespace ModemConfigurator.ViewModels
{
    public class BaseCollectionViewModel<TEntity> : ViewModelBase
        where TEntity : new()
    {
        public BaseCollectionViewModel(INavigationService navigationService, IPageDialogService pageDialogService, Services.IModemSettings modemSettings, Shiny.Net.IConnectivity connectivity, IDeviceService deviceService) 
            : base(navigationService, pageDialogService, modemSettings, connectivity, deviceService)
        {
            Items = new ObservableCollection<TEntity>();
            ItemSelectedCommand = new DelegateCommand<TEntity>(OnItemSelectedCommandExecuted);
            AddItemCommand = new DelegateCommand(OnAddItemCommandExecuted);
        }

        public ObservableCollection<TEntity> Items { get; }

        public DelegateCommand<TEntity> ItemSelectedCommand { get; }

        public DelegateCommand AddItemCommand { get; }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            try
            {
                using(var connection = CreateConnection())
                {
                    Items.Clear();
                    foreach(var item in connection.LoadAll<TEntity>())
                    {
                        Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                _pageDialogService.DisplayAlertAsync(ex.GetType().Name, ex.Message, "Ok");
                Console.WriteLine(ex);
            }
        }

        public void OnAddItemCommandExecuted() => OnItemSelectedCommandExecuted(default(TEntity));

        private async void OnItemSelectedCommandExecuted(TEntity entity)
        {
            await NavigationService.NavigateAsync($"{typeof(TEntity).Name}DetailPage", new NavigationParameters
            {
                { "Entity", entity }
            });
        }
    }
}
