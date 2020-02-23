using System;
using Xamarin.Forms.Internals;

namespace ModemConfigurator.Services
{
    public class FormsLogListener : LogListener
    {
        public override void Warning(string category, string message)
        {
            Console.WriteLine($"**** {category}: {message}");
        }
    }
}
