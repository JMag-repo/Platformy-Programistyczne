using platformy_NET.Models;
using platformy_NET.Models.Helpers;
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

namespace platformy_NET.MWM.View
{
    /// <summary>
    /// Logika interakcji dla klasy ArtistView.xaml
    /// </summary>
    public partial class ArtistView : UserControl
    {  
    /// <summary>
    /// Klasa inicjalizująca okno
    /// </summary>
        public ArtistView()
        {
            InitializeComponent();
            Task.Run(async () => await SpotifySearch.GetTokenAsync());


        }

        private List<SpotifyArtist> Artists = new List<SpotifyArtist>();
        /// <summary>
        /// Funkcja odpowiedzialna za wypełnianie ListBoxa danymi odpowiadającymi TextBoxowi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBox1_KeyUp(object sender, KeyEventArgs e)
        {
           if ( TxtBox1.Text == string.Empty)
            {
                
                ArtistListBox.ItemsSource = null;
                return;
            }

            var result = SpotifySearch.SearchArtist(TxtBox1.Text);

            if (result == null)
            {
                return;
            }
            var listArtist = new List<SpotifyArtist>();
            

            foreach (var item in result.artists.items)
            {
                listArtist.Add(new SpotifyArtist()
                {
                    ID = item.id,
                    Image = item.images.Any() ? item.images[0].url : "https://user-images.githubusercontent.com/24848110/33519396-7e56363c-d79d-11e7-969b-09782f5ccbab.png",
                    Name = item.name,
                    Popularity = $"{item.popularity}% popularność",
                    Followers = $"{item.followers.total.ToString("N")} obserwujących",
                    
                });
                    
            }

            
            ArtistListBox.ItemsSource = listArtist;
            Artists = listArtist;

        }

        /// <summary>
        /// Funkcja odpowiadająca za dodanie artysty do bazy danych po double-clicku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArtistListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SpotifyArtist artist = new SpotifyArtist();
            var index = ArtistListBox.SelectedIndex;
            artist = Artists[index];
            DataBaseService service = new DataBaseService();
            service.AddArtist(artist);
            MessageBox.Show("Dodano artyste do biblioteki");

        }

    }

    
}
