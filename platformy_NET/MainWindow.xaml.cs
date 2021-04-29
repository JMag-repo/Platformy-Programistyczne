using platformy_NET.Models;
using platformy_NET.Models.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace platformy_NET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Klasa inicjująca main window
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            
        }
        /// <summary>
        /// Klikniecie przycisku do zamykania programu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Kliknięcie przycisku do minimalizowania okna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeButtonClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        
    }
}
