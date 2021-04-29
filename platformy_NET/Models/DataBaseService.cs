using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace platformy_NET.Models
{
    /// <summary>
    /// Klasa przechowująca metody związane z obsługą bazy danych
    /// </summary>
    public class DataBaseService
    {   
        private DataBaseContext db;

        /// <summary>
        /// Konstruktor tworzący nowy element dbcontext do obsługi bazy danych
        /// </summary>
        public DataBaseService() => db = new DataBaseContext();
        /// <summary>
        /// Dodaje element klasy album do bazy danych
        /// </summary>
        /// <param name="album">Obiekt typu album do dodania</param>
        public void AddAlbum(SpotifyAlbum album)
        {
            db.FavoriteAlbums.Add(album);
            db.SaveChanges();
        }
        /// <summary>
        /// Dodaje element klasy artist do bazy danych
        /// </summary>
        /// <param name="artist">Obiekt typu artist do dodania</param>
        public void AddArtist(SpotifyArtist artist)
        {
            db.FavoriteArtists.Add(artist);
            db.SaveChanges();
        }
        /// <summary>
        /// Dodaje element klasy track do bazy danych
        /// </summary>
        /// <param name="track">Obiekt typu track do dodania</param>
        public void AddTrack(SpotifyTrack track)
        {
            db.FavoriteTracks.Add(track);
            db.SaveChanges();
        }
        /// <summary>
        /// Dodaje element klasy status do bazy danych
        /// </summary>
        /// <param name="status">Obiekt typu status do dodania</param>
        public void AddStatus(SocialStatus status)
        {
            db.SocialFeed.Add(status);
            db.SaveChanges();
        }
       /// <summary>
       /// Metoda zapisująca zawartość tabeli w bazie danych jak lista statusów
       /// </summary>
       /// <returns>Lista statusów reprezentująca baze danych</returns>
        public List<SocialStatus> GetStatus()
        {
            var listStatus = new List<SocialStatus>();
            var allstatuses =  db.SocialFeed.ToList();
            if(allstatuses?.Any() == true)
            {
                foreach (var status in allstatuses)
                {
                    listStatus.Add(new SocialStatus()
                    {
                        Id=status.Id,
                        StatusText=status.StatusText,
                        Date=status.Date
                    });
                }
            }
            return listStatus;
            
        }
        /// <summary>
        /// Metoda zwracająca albumy zapisane w bazie danych w postaci listy
        /// </summary>
        /// <returns>Lista reprezentująca albumy w bazie danych</returns>
        public List<SpotifyAlbum> GetAlbum()
        {
            var listAlbums = new List<SpotifyAlbum>();
            var allAlbums = db.FavoriteAlbums.ToList();
            if(allAlbums?.Any() == true)
            {
                foreach (var album in allAlbums)
                {
                    listAlbums.Add(new SpotifyAlbum()
                    {
                        ID = album.ID,
                        Name = album.Name,
                        Artist = album.Artist,
                        Release_date = album.Release_date,
                        Image = album.Image,
                        Popularity = album.Popularity
                    }) ;
                }
            }
            return listAlbums;
        }
        /// <summary>
        /// Metoda zwracająca liste utworów z bazy danych
        /// </summary>
        /// <returns>Lista reprezentująca utwory w bazie danych</returns>
        public List<SpotifyTrack> GetTrack()
        {
            var listTracks = new List<SpotifyTrack>();
            var allTracks = db.FavoriteTracks.ToList();
            if (allTracks?.Any() == true)
            {
                foreach (var track in allTracks)
                {
                    listTracks.Add(new SpotifyTrack()
                    {
                        ID = track.ID,
                        Album = track.Album,
                        Artist = track.Artist,
                        Name = track.Name,
                        Popularity = track.Popularity
                    });
                }
            }
            return listTracks;
        }
        /// <summary>
        /// Metoda zwracająca artystów z bazdy danych i zapisująca je jako lista
        /// </summary>
        /// <returns>Lista reprezentująca artystów zapisanych w bazie danych</returns>
        public List<SpotifyArtist> GetArtist()
        {
            var listArtists = new List<SpotifyArtist>();
            var allArtists = db.FavoriteArtists.ToList();
            if (allArtists?.Any() == true)
            {
                foreach (var artist in allArtists)
                {
                    listArtists.Add(new SpotifyArtist()
                    {
                        ID = artist.ID,
                        Image = artist.Image,
                        Popularity = artist.Popularity,
                        Followers = artist.Followers,
                        Name = artist.Name
                    });
                }
            }
            return listArtists;
        }

        
        
       
        
    }
}
