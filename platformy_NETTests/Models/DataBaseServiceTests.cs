
using platformy_NET.Models;
using NUnit.Framework;
using System;

namespace platformy_NET.Models.Tests
{
    [TestFixture()]
    public class DataBaseServiceTests
    {

        DataBaseService service = new DataBaseService();
        [Test()]
        public void GetStatusTestCount()
        {
            
            var list = service.GetStatus();
            Assert.AreEqual(list.Count, 1);
        }
        [Test()]
        public void GetStatusIdTest()
        {
            var list = service.GetStatus();
            Assert.AreEqual(1, list[0].Id);
        }

        [Test()]
        public void GetAlbumTestCount()
        {
            var list = service.GetAlbum();
            Assert.AreEqual(list.Count, 1);
        }

        [Test()]
        public void GetAlbumIdTest()
        {
            var list = service.GetStatus();
            Assert.AreEqual(1, list[0].Id);
        }

        [Test()]
        public void AddArtistTest()
        {
            SpotifyArtist artist = new SpotifyArtist()
            {
            ID="555755",
            Followers="10",
            Name="Oliver"
            };
            service.AddArtist(artist);
            var list = service.GetArtist();
            Assert.AreEqual("555755", list[0].ID);
            Assert.AreEqual("10", list[0].Followers);
            Assert.AreEqual("Oliver", list[0].Name);
        }

        [Test()]
        public void AddStatusTest()
        {
            SocialStatus status = new SocialStatus()
            {
                Id = 15,
                StatusText = "test"
                
            };
            service.AddStatus(status);
            var list = service.GetStatus();
            Assert.AreEqual("15", list[0].Id);
            Assert.AreEqual("test", list[0].StatusText);
            
        }

        [Test()]
        public void AddAlbumTest()
        {
            SpotifyAlbum album = new SpotifyAlbum()
            {
                ID = "15",
                Name = "test",
                Artist = "test",
                Popularity = "test"
                
                

            };
            service.AddAlbum(album);
            var list = service.GetAlbum();
            Assert.AreEqual("15", list[0].ID);
            Assert.AreEqual("test", list[0].Artist);
            Assert.AreEqual("test", list[0].Name);
            Assert.AreEqual("test", list[0].Popularity);

        }

        public void AddTrackTest()
        {
            SpotifyTrack track = new SpotifyTrack()
            {
                ID = "15",
                Name = "test",
                Artist = "test",
                Album = "test",
                Popularity = 10



            };
            service.AddTrack(track);
            var list = service.GetTrack();
            Assert.AreEqual("15", list[0].ID);
            Assert.AreEqual("test", list[0].Artist);
            Assert.AreEqual("test", list[0].Name);
            Assert.AreEqual(10, list[0].Popularity);
            Assert.AreEqual("test", list[0].Album);

        }

    }
}