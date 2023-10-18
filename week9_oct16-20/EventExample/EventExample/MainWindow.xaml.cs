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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //"MyControl" is the name of my ColorControl object
            MyControl.ColorEvent += HandleColorChange;

            //need to subscribe to MyControl's custom event
        }

        //want: a method that executes when I click a ColorControl button
        //ColorText is the name of the text block to put the color name
        private void HandleColorChange(object? sender, ColorEventArgs e)
        {
            ColorText.Text = e.ColorValue;
        }
    }
}
