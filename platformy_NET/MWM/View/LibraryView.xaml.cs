using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using platformy_NET.Models;
using platformy_NET.Models.Helpers;

namespace platformy_NET.MWM.View
{
    /// <summary>
    /// Logika interakcji dla klasy LibraryView.xaml
    /// </summary>
    public partial class LibraryView : UserControl
    {   
        /// <summary>
        /// Funkcja inicjalizująca okno oraz przypisanie ItemSoruce do listboxów
        /// </summary>
        public LibraryView()
        {
            InitializeComponent();
            Artists = service.GetArtist();
            Albums = service.GetAlbum();
            Tracks = service.GetTrack();
            this.ArtistListBox.ItemsSource = Artists;
            this.ListBoxAlbum.ItemsSource = Albums;
            this.ListBoxSong.ItemsSource = Tracks;
        }
        
        private List<SpotifyArtist> Artists;
        private List<SpotifyAlbum> Albums;
        private List<SpotifyTrack> Tracks;
        private DataBaseService service = new DataBaseService();
        /// <summary>
        /// Funkcja odpowiadająca za usunięcie artysty z bazy danych po double-clicku itemu w listboxie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArtistListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SpotifyArtist artist = new SpotifyArtist();

            var index = ArtistListBox.SelectedIndex;
            artist = Artists[index];
            DataBaseContext db = new DataBaseContext();
            if (MessageBox.Show("Czy chcesz usunąć Artyste?", "Question", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {

                db.FavoriteArtists.Attach(artist);
                db.FavoriteArtists.Remove(artist);
                db.SaveChanges();
                Artists = service.GetArtist();


            }
            ArtistListBox.ItemsSource = service.GetArtist();

        }
        /// <summary>
        /// Funkcja odpowiadająca za usunięcie albumu z bazy danych po double-clicku itemu w listboxie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxAlbum_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SpotifyAlbum album = new SpotifyAlbum();

            var index = ListBoxAlbum.SelectedIndex;
            album = Albums[index];
            DataBaseContext db = new DataBaseContext();
            if (MessageBox.Show("Czy chcesz usunąć Album?", "Question", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {

                db.FavoriteAlbums.Attach(album);
                db.FavoriteAlbums.Remove(album);
                db.SaveChanges();
                Albums = service.GetAlbum();

            }
            ListBoxAlbum.ItemsSource = service.GetAlbum();

        }
        /// <summary>
        /// Funkcja odpowiadająca za usunięcie utworu z bazy danych po double-clicku itemu w listboxie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxSong_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SpotifyTrack track = new SpotifyTrack();

            var index = ListBoxSong.SelectedIndex;
            track = Tracks[index];
            DataBaseContext db = new DataBaseContext();
            if (MessageBox.Show("Czy chcesz usunąć utwór?", "Question", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
            {

                db.FavoriteTracks.Attach(track);
                db.FavoriteTracks.Remove(track);
                db.SaveChanges();
                Tracks = service.GetTrack();

            }
            ListBoxSong.ItemsSource = service.GetTrack();

        }
    }
}
