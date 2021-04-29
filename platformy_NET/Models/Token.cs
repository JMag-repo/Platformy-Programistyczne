using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace platformy_NET.Models
{
    /// <summary>
    /// Klasa przechowuje token autoryzacji do Api
    /// acces_token - token dostepu do kona spotify
    /// token_type -  typ tokenu
    /// expires_in - liczba czasu kiedy token wygaśnie
    /// </summary>
    public class Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
    }
}
