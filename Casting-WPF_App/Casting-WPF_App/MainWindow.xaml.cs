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

namespace Casting_WPF_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // 'sender' object is the source of the button click
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // you need to downcast sender in order to access the button properties
            var button = (Button)sender;

            // OR
            var button2 = sender as Button;
            if (button2 != null)
            {
                MessageBox.Show(button2.ActualHeight.ToString());
            }

            MessageBox.Show("Hello World");
        }
    }
}
