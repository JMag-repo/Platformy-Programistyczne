using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static platformy_NET.Models.SpotSearch;

namespace platformy_NET.Models.Helpers
{
    public static class SpotifySearch
    {
        /// <summary>
        /// Klasa odpowiedzialna za połączenie sie z API Spotify
        /// </summary>

        public static Token token { get; set; }
        /// <summary>
        /// Metoda odpowiedzialana za autoryzowanie połączenia z Api
        /// </summary>
        /// <returns>token weryfikacji</returns>
        

        public static async Task GetTokenAsync()
        {
           
            #region SecretVault
            string clientID= "ea8a3bc83c5a439b9a60fb58afa5cd73";
            string clientSecret = "90a96656de934b5982e67f42ae25913a";
            #endregion

            string auth = Convert.ToBase64String(Encoding.UTF8.GetBytes(clientID + ":" + clientSecret));
            List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string,string>("grant_type", "client_credentials")
            };

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {auth}");
            HttpContent content = new FormUrlEncodedContent(args);
            HttpResponseMessage resp = await client.PostAsync("https://accounts.spotify.com/api/token", content);
            string msg = await resp.Content.ReadAsStringAsync();
            token = JsonConvert.DeserializeObject<Token>(msg);
        }
        /// <summary>
        /// Metoda odpowiedzalna za wysłanie żądania wyszkania artysty,uwtoru,albumu do API Spotify
        /// </summary>
        /// <param name="searchWord">Szukana fraza</param>
        /// <returns>zwraca zdeserializowany z JSONA obiekt wyszukiwania</returns>
        public static SpotifyResult SearchArtist(string searchWord) 
        {
            var client = new RestClient("https://api.spotify.com/v1/search");
            client.AddDefaultHeader("Authorization", $"Bearer {token.access_token}");
            var request = new RestRequest($"?q={searchWord}&type=artist%2Calbum%2Ctrack&market=PL", Method.GET);
            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var result = JsonConvert.DeserializeObject<SpotifyResult>(response.Content);
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
