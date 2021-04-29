using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace platformy_NET.Models
{
    /// <summary>
    /// Klasa przechowująca parametry artysty
    /// Id -identyfikator artysty
    /// Name - nazwa artysty
    /// Image - Url do obrazu artysty z serwisu spotify
    /// Followers - liczba obserwującychh w serwisie spotify
    /// Popularity - %wartość popularności z serwisu spotify
    /// </summary>
    public class SpotifyArtist
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Followers { get; set; }
        public string Popularity { get; set; }
       
    }
}
