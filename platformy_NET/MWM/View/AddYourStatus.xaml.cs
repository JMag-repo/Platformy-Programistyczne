using platformy_NET.Models;
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
using System.Windows.Shapes;

namespace platformy_NET.MWM.View
{
    /// <summary>
    /// Logika interakcji dla klasy AddYourStatus.xaml
    /// </summary>
    public partial class AddYourStatus : Window
    {   
        /// <summary>
        /// Klasa inicjalizująca okno
        /// </summary>
        public AddYourStatus()
        {
            InitializeComponent();
        }
        public DataBaseService service;
        
        /// <summary>
        /// Działanie przycisku Button1 zapisuje dane z TextBoxa do bazy danych z odpowiadająca jej datą, po wykonaniu zamyka okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            service = new DataBaseService();
            SocialStatus status = new SocialStatus()
            {
                StatusText = txtbox1.Text,
                Date=DateTime.Now
            };
            service.AddStatus(status);

            
            Close();
        }
        
    }
}
