using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EventExample
{
    public class ColorEventArgs : RoutedEventArgs
    {
        //what info is needed about the event?
        public string ColorValue { get; init; }

        //make a constructor to initialize
        public ColorEventArgs(string n)
        {
            ColorValue = n;
        }
    }
}
