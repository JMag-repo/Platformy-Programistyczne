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
    /// Logika interakcji dla klasy SongView.xaml
    /// </summary>
    public partial class SongView : UserControl
    {   
        /// <summary>
        /// Klasa inicjalizująca okno
        /// </summary>
        public SongView()
        {
            InitializeComponent();
            Task.Run(async () => await SpotifySearch.GetTokenAsync());
        }
        
        private List<SpotifyTrack> Tracks = new List<SpotifyTrack>();
        /// <summary>
        /// Funkcja odpowiadająca za wypełnianie ListBoxa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (TxtBox1.Text == string.Empty)
            {

                ListBoxSong.ItemsSource = null;
                return;
            }

            var result = SpotifySearch.SearchArtist(TxtBox1.Text);

            if (result == null)
            {
                return;
            }
            var listTracks = new List<SpotifyTrack>();


            foreach (var item in result.tracks.items)
            {
                listTracks.Add(new SpotifyTrack()
                {
                    ID = item.id,
                    Name = item.name,
                    Album = item.album.name,
                    Artist = item.GetArtists(),
                    Popularity = item.popularity
                    

                });

            }


            ListBoxSong.ItemsSource = listTracks;
            Tracks = listTracks;

        }
        /// <summary>
        /// Funkcja która po double-click na elemencie w listBoxie dodaje go do bazy danych(biblioteki)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxSong_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SpotifyTrack track = new SpotifyTrack();
            var index = ListBoxSong.SelectedIndex;
            track = Tracks[index];
            DataBaseService service = new DataBaseService();
            service.AddTrack(track);
            MessageBox.Show("Dodano utwór do biblioteki");

        }
    }
}
