using System;
using Xamarin.Forms;

namespace ModemConfigurator.Controls
{
    public class Picker<T> : Picker
    {
        public Picker()
        {
            foreach(var value in Enum.GetValues(typeof(T)))
            {
                ItemsSource.Add(value);
            }
        }
    }
}
