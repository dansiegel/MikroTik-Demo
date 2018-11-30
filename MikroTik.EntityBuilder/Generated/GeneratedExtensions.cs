using ModemConfigurator.Views;
using ModemConfigurator.ViewModels;
using Prism.Ioc;

namespace ModemConfigurator
{
    public static class GeneratedExtensions
    {
        public static void RegisterAutoGeneratedViews(this IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<LogPage, LogPageViewModel>();
            containerRegistry.RegisterForNavigation<LogDetailPage, LogDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ToolPingPage, ToolPingPageViewModel>();
            containerRegistry.RegisterForNavigation<ToolPingDetailPage, ToolPingDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ToolTorchPage, ToolTorchPageViewModel>();
            containerRegistry.RegisterForNavigation<ToolTorchDetailPage, ToolTorchDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ToolTraceroutePage, ToolTraceroutePageViewModel>();
            containerRegistry.RegisterForNavigation<ToolTracerouteDetailPage, ToolTracerouteDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<SystemResourcePage, SystemResourcePageViewModel>();
            containerRegistry.RegisterForNavigation<SystemResourceDetailPage, SystemResourceDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<QueueSimplePage, QueueSimplePageViewModel>();
            containerRegistry.RegisterForNavigation<QueueSimpleDetailPage, QueueSimpleDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<QueueTreePage, QueueTreePageViewModel>();
            containerRegistry.RegisterForNavigation<QueueTreeDetailPage, QueueTreeDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<QueueTypePage, QueueTypePageViewModel>();
            containerRegistry.RegisterForNavigation<QueueTypeDetailPage, QueueTypeDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<PppAaaPage, PppAaaPageViewModel>();
            containerRegistry.RegisterForNavigation<PppAaaDetailPage, PppAaaDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<PppActivePage, PppActivePageViewModel>();
            containerRegistry.RegisterForNavigation<PppActiveDetailPage, PppActiveDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<PppProfilePage, PppProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<PppProfileDetailPage, PppProfileDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<PppSecretPage, PppSecretPageViewModel>();
            containerRegistry.RegisterForNavigation<PppSecretDetailPage, PppSecretDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<AccountingSnapshotPage, AccountingSnapshotPageViewModel>();
            containerRegistry.RegisterForNavigation<AccountingSnapshotDetailPage, AccountingSnapshotDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<AccountingUncountedPage, AccountingUncountedPageViewModel>();
            containerRegistry.RegisterForNavigation<AccountingUncountedDetailPage, AccountingUncountedDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<AccountingWebAccessPage, AccountingWebAccessPageViewModel>();
            containerRegistry.RegisterForNavigation<AccountingWebAccessDetailPage, AccountingWebAccessDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<DhcpServerConfigPage, DhcpServerConfigPageViewModel>();
            containerRegistry.RegisterForNavigation<DhcpServerConfigDetailPage, DhcpServerConfigDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<IpAccountingPage, IpAccountingPageViewModel>();
            containerRegistry.RegisterForNavigation<IpAccountingDetailPage, IpAccountingDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<IpAddressPage, IpAddressPageViewModel>();
            containerRegistry.RegisterForNavigation<IpAddressDetailPage, IpAddressDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<IpArpPage, IpArpPageViewModel>();
            containerRegistry.RegisterForNavigation<IpArpDetailPage, IpArpDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<IpDhcpClientPage, IpDhcpClientPageViewModel>();
            containerRegistry.RegisterForNavigation<IpDhcpClientDetailPage, IpDhcpClientDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<IpDhcpRelayPage, IpDhcpRelayPageViewModel>();
            containerRegistry.RegisterForNavigation<IpDhcpRelayDetailPage, IpDhcpRelayDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<IpDhcpServerPage, IpDhcpServerPageViewModel>();
            containerRegistry.RegisterForNavigation<IpDhcpServerDetailPage, IpDhcpServerDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<IpDnsPage, IpDnsPageViewModel>();
            containerRegistry.RegisterForNavigation<IpDnsDetailPage, IpDnsDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<IpPoolPage, IpPoolPageViewModel>();
            containerRegistry.RegisterForNavigation<IpPoolDetailPage, IpPoolDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<HotspotActivePage, HotspotActivePageViewModel>();
            containerRegistry.RegisterForNavigation<HotspotActiveDetailPage, HotspotActiveDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<HotspotUserPage, HotspotUserPageViewModel>();
            containerRegistry.RegisterForNavigation<HotspotUserDetailPage, HotspotUserDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<HotspotUserProfilePage, HotspotUserProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<HotspotUserProfileDetailPage, HotspotUserProfileDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<FirewallAddressListPage, FirewallAddressListPageViewModel>();
            containerRegistry.RegisterForNavigation<FirewallAddressListDetailPage, FirewallAddressListDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<FirewallConnectionPage, FirewallConnectionPageViewModel>();
            containerRegistry.RegisterForNavigation<FirewallConnectionDetailPage, FirewallConnectionDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ConnectionTrackingPage, ConnectionTrackingPageViewModel>();
            containerRegistry.RegisterForNavigation<ConnectionTrackingDetailPage, ConnectionTrackingDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<FirewallFilterPage, FirewallFilterPageViewModel>();
            containerRegistry.RegisterForNavigation<FirewallFilterDetailPage, FirewallFilterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<FirewallManglePage, FirewallManglePageViewModel>();
            containerRegistry.RegisterForNavigation<FirewallMangleDetailPage, FirewallMangleDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<FirewallNatPage, FirewallNatPageViewModel>();
            containerRegistry.RegisterForNavigation<FirewallNatDetailPage, FirewallNatDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<DnsCachePage, DnsCachePageViewModel>();
            containerRegistry.RegisterForNavigation<DnsCacheDetailPage, DnsCacheDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<DnsCacheAllPage, DnsCacheAllPageViewModel>();
            containerRegistry.RegisterForNavigation<DnsCacheAllDetailPage, DnsCacheAllDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<DnsStaticPage, DnsStaticPageViewModel>();
            containerRegistry.RegisterForNavigation<DnsStaticDetailPage, DnsStaticDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<DhcpServerAlertPage, DhcpServerAlertPageViewModel>();
            containerRegistry.RegisterForNavigation<DhcpServerAlertDetailPage, DhcpServerAlertDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<DhcpServerLeasePage, DhcpServerLeasePageViewModel>();
            containerRegistry.RegisterForNavigation<DhcpServerLeaseDetailPage, DhcpServerLeaseDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<DhcpServerNetworkPage, DhcpServerNetworkPageViewModel>();
            containerRegistry.RegisterForNavigation<DhcpServerNetworkDetailPage, DhcpServerNetworkDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<DhcpServerOptionPage, DhcpServerOptionPageViewModel>();
            containerRegistry.RegisterForNavigation<DhcpServerOptionDetailPage, DhcpServerOptionDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<InterfacePage, InterfacePageViewModel>();
            containerRegistry.RegisterForNavigation<InterfaceDetailPage, InterfaceDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<InterfaceBridgePage, InterfaceBridgePageViewModel>();
            containerRegistry.RegisterForNavigation<InterfaceBridgeDetailPage, InterfaceBridgeDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<InterfaceEthernetPage, InterfaceEthernetPageViewModel>();
            containerRegistry.RegisterForNavigation<InterfaceEthernetDetailPage, InterfaceEthernetDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<InterfaceMonitorTrafficPage, InterfaceMonitorTrafficPageViewModel>();
            containerRegistry.RegisterForNavigation<InterfaceMonitorTrafficDetailPage, InterfaceMonitorTrafficDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<InterfaceWirelessPage, InterfaceWirelessPageViewModel>();
            containerRegistry.RegisterForNavigation<InterfaceWirelessDetailPage, InterfaceWirelessDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<WirelessAccessListPage, WirelessAccessListPageViewModel>();
            containerRegistry.RegisterForNavigation<WirelessAccessListDetailPage, WirelessAccessListDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<WirelessChannelsPage, WirelessChannelsPageViewModel>();
            containerRegistry.RegisterForNavigation<WirelessChannelsDetailPage, WirelessChannelsDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<WirelessRegistrationTablePage, WirelessRegistrationTablePageViewModel>();
            containerRegistry.RegisterForNavigation<WirelessRegistrationTableDetailPage, WirelessRegistrationTableDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<WirelessSecurityProfilePage, WirelessSecurityProfilePageViewModel>();
            containerRegistry.RegisterForNavigation<WirelessSecurityProfileDetailPage, WirelessSecurityProfileDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<WirelessSnifferPage, WirelessSnifferPageViewModel>();
            containerRegistry.RegisterForNavigation<WirelessSnifferDetailPage, WirelessSnifferDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<BridgeFilterPage, BridgeFilterPageViewModel>();
            containerRegistry.RegisterForNavigation<BridgeFilterDetailPage, BridgeFilterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<BridgeNatPage, BridgeNatPageViewModel>();
            containerRegistry.RegisterForNavigation<BridgeNatDetailPage, BridgeNatDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<BridgePortPage, BridgePortPageViewModel>();
            containerRegistry.RegisterForNavigation<BridgePortDetailPage, BridgePortDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<BridgeSettingsPage, BridgeSettingsPageViewModel>();
            containerRegistry.RegisterForNavigation<BridgeSettingsDetailPage, BridgeSettingsDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<CapsManRegistrationTablePage, CapsManRegistrationTablePageViewModel>();
            containerRegistry.RegisterForNavigation<CapsManRegistrationTableDetailPage, CapsManRegistrationTableDetailPageViewModel>();

        }
    }
}