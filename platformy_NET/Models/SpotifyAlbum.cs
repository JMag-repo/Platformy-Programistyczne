using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace platformy_NET.Models
{
    /// <summary>
    /// Klasa przechowująca parametry Albumu
    /// ID - identyfikator albumu
    /// Artist - autorzy albumu
    /// Name - nazwa albumu
    /// Image - Url do obrazu z Api przedstawiajacy okładke albumu
    /// Release_Date - Data wydania
    /// Popularity - popularność w % z serwisu spotify
    /// </summary>
    public class SpotifyAlbum
    {
        public string ID { get; set; }
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Release_date { get; set; }
        public string Popularity { get; set; }
        
    }
}
