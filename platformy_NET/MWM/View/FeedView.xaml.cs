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
    /// Logika interakcji dla klasy FeedView.xaml
    /// </summary>
    public partial class FeedView : UserControl
    {   /// <summary>
    /// klasa odpowiadająca za inicjalizacje okna społecznośći
    /// </summary>
        public FeedView()
        {
            InitializeComponent();
            statusList= service.GetStatus();
            this.DataListBox.ItemsSource = statusList;
            
            
            
                
        }
        private DataBaseService service = new DataBaseService();
        private List<SocialStatus> statusList;
        /// <summary>
        /// Funkcja odświeżająca ListBoxa ze statusami
        /// </summary>
        public void Update()
        {
            DataListBox.ItemsSource = service.GetStatus();
        }
        /// <summary>
        /// Funkcja która po double-clicku usuwa dany element z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SocialStatus status = new SocialStatus();
            
            var index = DataListBox.SelectedIndex;
            SocialStatus statusToDelete = new SocialStatus();
            statusToDelete = statusList[index];
            DataBaseContext db = new DataBaseContext();
            if (MessageBox.Show("Czy chcesz usunąć wpis?","Question",MessageBoxButton.YesNoCancel)==MessageBoxResult.Yes)
            {
               
                db.SocialFeed.Attach(statusToDelete);
                db.SocialFeed.Remove(statusToDelete);
                db.SaveChanges();
               

            }

            Update();
        }
        /// <summary>
        /// Funkcja przedstawiająca działanie przycisku, otwiera nowe okno AddYourStatus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            AddYourStatus NewWindow = new AddYourStatus();
            NewWindow.Owner =Application.Current.MainWindow;
            NewWindow.Show();
            
            
        }

        
    }
}
