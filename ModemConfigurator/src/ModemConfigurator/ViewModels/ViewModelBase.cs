using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using ModemConfigurator.Services;
using tik4net;
using Prism.Services;
using Xamarin.Forms;
using Prism.AppModel;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using Shiny.Net;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Disposables;
using Shiny;

namespace ModemConfigurator.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible, IPageLifecycleAware
    {
        protected CompositeDisposable DestroyWith { get; } = new CompositeDisposable();

        protected INavigationService NavigationService { get; }

        protected IModemSettings _modemSettings { get; }

        protected IPageDialogService _pageDialogService { get; }

        protected IConnectivity _connectivity { get; }

        public ViewModelBase(INavigationService navigationService, IPageDialogService pageDialogService, IModemSettings modemSettings, IConnectivity connectivity, IDeviceService deviceService)
        {
            NavigationService = navigationService;
            _modemSettings = modemSettings;
            _pageDialogService = pageDialogService;
            _connectivity = connectivity;
            IsConnected = _connectivity.IsDirectConnect();
            _connectivity.WhenInternetStatusChanged()
                .Subscribe(x => deviceService.BeginInvokeOnMainThread(CheckConnection))
                .DisposedBy(DestroyWith);
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _isConnected;
        public bool IsConnected
        {
            get => _isConnected;
            set => SetProperty(ref _isConnected, value, () => IsNotConnected = !value);
        }

        private bool _isNotConnected = true;
        public bool IsNotConnected
        {
            get => _isNotConnected;
            set => SetProperty(ref _isNotConnected, value, () => IsConnected = !value);
        }

        protected ITikConnection CreateConnection()
        {
            var connection = ConnectionFactory.CreateConnection(TikConnectionType.Api);
            connection.Open(_modemSettings.Host, _modemSettings.User, _modemSettings.Password);
            return connection;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
            CheckConnection();
        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {

        }

        public virtual void Destroy()
        {
            DestroyWith.Dispose();
        }

        public void OnAppearing()
        {
            CheckConnection();
        }

        public void OnDisappearing()
        {
        }

        protected void CheckConnection()
        {
            try
            {
                if(_connectivity.Access == NetworkAccess.Ethernet &&
                    !string.IsNullOrWhiteSpace(_modemSettings.Host) &&
                    PingHost(_modemSettings.Host))
                {
                    using (var connection = CreateConnection())
                    {
                        IsConnected = connection.IsOpened;
                    }
                }
                else
                {
                    IsConnected = false;
                }
            }
            catch
            {
                IsConnected = false;
            }
        }

        private static bool PingHost(string nameOrAddress)
        {
            bool pingable = false;
            Ping pinger = null;

            try
            {
                pinger = new Ping();
                PingReply reply = pinger.Send(nameOrAddress);
                pingable = reply.Status == IPStatus.Success;
            }
            catch (PingException ex)
            {
                Console.WriteLine(ex);
                // Discard PingExceptions and return false;
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }

            return pingable;
        }
    }
}
