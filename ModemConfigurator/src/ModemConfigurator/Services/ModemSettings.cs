using Prism.Mvvm;
namespace ModemConfigurator.Services
{
    public class ModemSettings : BindableBase, IModemSettings
    {
        public ModemSettings()
        {
            Host = "192.168.88.1";
            User = "admin";
            Password = string.Empty;
        }

        public string Host { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
    }
}
