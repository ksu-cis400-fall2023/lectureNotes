using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventExample
{
    /// <summary>
    /// Interaction logic for ColorControl.xaml
    /// </summary>
    public partial class ColorControl : UserControl
    {
        //declare a custom event
        //public event EventHandler<CustomArgType> EventName;
        public event EventHandler<ColorEventArgs> ColorClicked;

        //will need custom args

        public ColorControl()
        {
            InitializeComponent();
        }

        public void ClickColor(object sender, RoutedEventArgs e)
        {
            //goal: display "Red" or "Blue" in the TextBlock in the main window
            //button names are "RedButton" and "BlueButton"

            if (sender is Button b)
            {
                string info = "";
                if (b.Name == "RedButton") 
                {
                    info = "red";
                }
                else if (b.Name == "BlueButton")
                {
                    info = "blue";
                }
                //invoke your event
                ColorClicked?.Invoke(this, new ColorEventArgs(info));
            }
        }
    }
}
