using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace platformy_NET.Models
{
    /// <summary>
    /// Klasa przechowująca parametry utworu
    /// ID - identyfikator utworu
    /// Album - nazwa albumu w którym utwór się znajduje
    /// Artist - wykonawcy utworu
    /// Name - nazwa utworu
    /// Popularity - % wartość popularności utworu w seriwisie spotify
    /// </summary>
    public class SpotifyTrack
    {
        public string ID { get; set; }
        public string Album { get; set; }
        public string Artist { get; set; }
        public string Name { get; set; }
        public int Popularity { get; set; }
        
        
    }
}
