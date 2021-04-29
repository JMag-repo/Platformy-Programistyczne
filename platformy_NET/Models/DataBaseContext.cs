using System.Data.Entity;

namespace platformy_NET.Models
{   
   /// <summary>
   /// Klasa generująca context bazy danych
   /// </summary>
    public class DataBaseContext : DbContext
    {
        /// <summary>
        /// Metoda ustalająca nazwe bazy danych i tworząca ją
        /// </summary>
        public DataBaseContext() : base("BibliotekaDB")
        {
           
        }

        public DbSet<SpotifyAlbum> FavoriteAlbums { get; set; }
        public DbSet<SpotifyArtist> FavoriteArtists { get; set; }
        public DbSet<SpotifyTrack> FavoriteTracks { get; set; }
        public DbSet<SocialStatus> SocialFeed { get; set; }
        /// <summary>
        /// Metoda do tworzenia nowego contextu bazy danych
        /// </summary>
        /// <returns>nowy obiekt typu Databasecontext</returns>
        public static DataBaseContext Create()
        {
            return new DataBaseContext();
        }
    }
}
