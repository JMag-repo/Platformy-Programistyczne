using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using platformy_NET.Models;

namespace platformy_NETTests.Models
{
    class ArtistTests
    {
        private SpotifyArtist _spotifyartist;
        [SetUp]
        public void SetUp()
        {
            _spotifyartist = new SpotifyArtist();
            _spotifyartist.ID = "4";
            _spotifyartist.Image = "test";
            _spotifyartist.Name = "test";
            _spotifyartist.Popularity = "test";
            _spotifyartist.Followers = "test";
        }
        [Test()]
        public void Id_Artist_Getter_Test()
        {
            Assert.AreEqual("4", _spotifyartist.ID);
        }
        [Test()]
        public void Image_Artist_Getter_Test()
        {
            Assert.AreEqual("test", _spotifyartist.Image);
        }
        [Test()]
        public void Name_Artist_Getter_Test()
        {
            Assert.AreEqual("test", _spotifyartist.Name);
        }
        [Test()]
        public void Popularity_Artist_Getter_Test()
        {
            Assert.AreEqual("test", _spotifyartist.Popularity);
        }
        [Test()]
        public void Followers_Artist_Getter_Test()
        {
            Assert.AreEqual("test", _spotifyartist.Followers);
        }
    }
}
