using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace platformy_NET.Models
{
    /// <summary>
    /// Klasa przechowująca obiekty z Api SPotify
    /// </summary>
    public class SpotSearch
    {
        /// <summary>
        /// Klasa przechowująca obiekty linki zewnętrzne
        /// </summary>
        public class ExternalUrls
        {

            public string spotify { get; set; }
        }
        /// <summary>
        /// Klasa przechowująca zewnętrzne ID
        /// </summary>
        public class ExternalID
        {
            public string ean { get; set; }
            public string isrc { get; set; }
            public string upc { get; set; }

        }
        /// <summary>
        /// Klasa przechowująca obserwujących
        /// </summary>
        public class Followers
        {
            public string href { get; set; }
            public int total { get; set; }
        }
        /// <summary>
        /// Klasa przechowująca obrazy
        /// </summary>
        public class ImageSP
        {
            [Key]
            public int width { get; set; }
            public string url { get; set; }
            public int height { get; set; }
        }
        /// <summary>
        /// Klasa przechowująca prawa autorskie
        /// </summary>
        public class Copyright
        {
            public string text { get; set; }
            public string type { get; set; }
        }
        /// <summary>
        /// Klasa przechowująca restrykcje związane z albumami
        /// </summary>
        public class AlbumRestrictionObject
        {
            public string reason { get; set; }
        }
        /// <summary>
        /// Klasa przechowująca połączone utwory
        /// </summary>
        public class LinkedTrackObject
        {
            public ExternalUrls external_urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
        }
        /// <summary>
        /// Klasa prezchowująca restrykcje związane z utworami
        /// </summary>
        public class TrackRestrictionObject
        {
            public string reason { get; set; }
        }
        /// <summary>
        /// Klasa przechowująca uproszony obiekt artysty
        /// </summary>
        public class SimplifiedArtistObject
        {
            public ExternalUrls external_urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string uri { get; set; }

        }
        /// <summary>
        /// Klasa przechowująca uproszony obiekt utwór
        /// </summary>
        public class SimplifiedTrackObject
        {
            public List<SimplifiedArtistObject> artists { get; set; }
            public List<string> available_markets { get; set; }
            public int disc_number { get; set; }
            public int duration_ms { get; set; }
            public bool Explicit { get; set; }
            public ExternalUrls external_urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public bool is_local { get; set; }
            public bool is_playable { get; set; }
            public LinkedTrackObject linked_from { get; set; }
            public string name { get; set; }
            public string preview_url { get; set; }
            public TrackRestrictionObject restrictions { get; set; }
            public int track_number { get; set; }
            public string type { get; set; }
            public string uri { get; set; }

            

        }
        /// <summary>
        /// Klasa przechowująca uproszony obiekt album
        /// </summary>
        public class SimplifiedAlbumObject
        {
            public string album_group { get; set; }
            public string albym_type { get; set; }
            public List<SimplifiedArtistObject> artists { get; set; }
            public List<string> available_markets { get; set; }
            public ExternalUrls external_urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public List<ImageSP> images { get; set; }
            public string name { get; set; }
            public string release_date { get; set; }
            public string release_date_precision { get; set; }
            public AlbumRestrictionObject restrictions { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
        }
        /// <summary>
        /// Klasa przechowująca obiekt Artysta
        /// </summary>
        public class Artist
        {
            public ExternalUrls external_urls { get; set; }
            public Followers followers { get; set; }
            public List<string> genres { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public List<ImageSP> images { get; set; }
            public string name { get; set; }
            public int popularity { get; set; }
            public string type { get; set; }
            public string uri { get; set; }

            
        }
        /// <summary>
        /// Klasa przechowująca obiekt artystów służąca do wyświetlania wyników wyszukiwania
        /// </summary>
        public class Artists
        {
            public string href { get; set; }
            public List<Artist> items { get; set; }
            public int limit { get; set; }
            public string next { get; set; }
            public int offset { get; set; }
            public object previous { get; set; }
            public int total { get; set; }
        }

        /// <summary>
        /// Klasa przechowujaca obiekt album
        /// </summary>
        public class Album
        {
            public string album_type { get; set; }
            public List<Artist> artists { get; set; }
            public List<string> available_markets { get; set; }
            public List<Copyright> copyrights { get; set; }
            public ExternalID external_ids { get; set; }
            public ExternalUrls externmal_urls { get; set; }
            public List<String> genres { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public List<ImageSP> images { get; set; }
            public string label { get; set; }
            public string name { get; set; }
            public int popularity { get; set; }
            public string release_date { get; set; }
            public string release_date_precision { get; set; }
            public AlbumRestrictionObject restrictions { get; set; }
            public List<SimplifiedTrackObject> tracks { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
            /// <summary>
            /// Metoda łącząca nazwy artystów z listy w jednego stringa
            /// </summary>
            /// <returns>string z nazwami autorów</returns>
            public string GetArtists()
            {
                string names=string.Empty;
                foreach(var art in artists)
                {
                    names += (art.name+" ");
                }
                return names;
            }
        }
        /// <summary>
        /// Klasa przechowujaca obiekt albumów służąca do wyświetlania wyników wyszukiwania 
        /// </summary>
        public class Albums
        {
            public string href { get; set; }
            public List<Album> items { get; set; }
            public int limit { get; set; }
            public string next { get; set; }
            public int offset { get; set; }
            public object previous { get; set; }
            public int total { get; set; }
        }
        /// <summary>
        /// Klasa przechowująca obiekt utwór
        /// </summary>
        public class Track
        {
            public SimplifiedAlbumObject album { get; set; }
            public List<Artist> artists { get; set; }
            public List<string> available_markets { get; set; }
            public int disc_number { get; set; }
            public int duration_ms { get; set; }
            public bool Explicit { get; set; }
            public ExternalID external_ids { get; set; }
            public ExternalUrls external_urls { get; set; }
            public string href { get; set; }
            public string id { get; set; }
            public bool is_local { get; set; }
            public bool is_playlable { get; set; }
            public LinkedTrackObject linked_from { get; set; }
            public string name { get; set; }
            public int popularity { get; set; }
            public string preview_url { get; set; }
            public int track_number { get; set; }
            public string type { get; set; }
            public string uri { get; set; }
            /// <summary>
            /// Metoda łącząca nazwy artystów z listy w jednego stringa
            /// </summary>
            /// <returns>string z nazwami artystów</returns>
            public string GetArtists()
            {
                string names = string.Empty;
                foreach (var art in artists)
                {
                    names += (art.name + " ");
                }
                return names;
            }

        }
        /// <summary>
        /// Klasa przechowuąca obiekt utworów służąca do wyświetlania wyników wyszukiwania
        /// </summary>
        public class Tracks
        {
            public string href { get; set; }
            public List<Track> items { get; set; }
            public int limit { get; set; }
            public string next { get; set; }
            public int offset { get; set; }
            public object previous { get; set; }
            public int total { get; set; }
        }

        /// <summary>
        /// Klasa przedstawiająca wynik wyszukiwania
        /// </summary>
        public class SpotifyResult
        {
            public Artists artists { get; set; }
            public Tracks tracks { get; set; }
            public Albums albums { get; set; }
        }
    }
}
