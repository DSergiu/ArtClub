using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DomainTest;
using Domain;
using Controlller.Interfaces;
using Controlller.Classes;
using DAL;
using System.Drawing;


namespace DomainTest
{
   
    [TestClass]
    public class ArtitemTest
    {
        private ArtclubContext _dBcontext;
        private IArtitemCtrl _artitemCtrl;

        [TestInitialize]
        public void TestSetup()
        {
            _dBcontext = new ArtclubContext();
            _artitemCtrl = new ArtitemCtrl();
        }

        [TestMethod]
        public void TestSameArtitemId()
        {
            Artitem art = new Artitem().SetIdKey(1);
            IArtitemCtrl ctrl = new ArtitemCtrl();

            try
            {
                ctrl.CreateArtitem(art);
                Assert.Fail("Same Id is a real problem");
            }
            catch(SameArtItemIdException) { }
            catch (ArtItemNotInRangeException) { }
            
        }


        public void TestDescription()
        {
            try
            {
                (new Artitem()).SetDescription("a");
                Assert.AreEqual(true, "Too short description");
            }
            catch (TooLongDescriptionException) { }
            try
            {
                (new Artitem()).SetDescription("");
                Assert.AreEqual(true,"Empty Description");
            }
            catch (TooLongDescriptionException) { }
        }

        [TestMethod]
        public void EmptyMandatoryFields()
        {
            try
            {
                (new Artitem()).SetName("");
                Assert.Fail("Empty field");
            }
            catch (InvalidNameException) { }
            try
            {
                (new Artitem()).SetArtist("");
                Assert.Fail("Empty Field");
            }
            catch (InvalidArtistNameException) { }
        }

        [TestMethod]
        
        public void TestGetAllArtitem() {

            IArtitemCtrl ctrl = new ArtitemCtrl();
            var allarts = ctrl.GetAllArtitems();
            Assert.AreNotEqual(0, allarts.Count, "There are 0 arts in the list");
        
        }


        [TestMethod]
        public void TestArtistName()
        {
            try
            {
                (new Artitem()).SetArtist("Davinchi1");
                Assert.Fail("Invalid name, no digits alowed");
            }
            catch (InvalidArtistNameException) { }

            try
            {
                (new Artitem()).SetArtist("a");
                Assert.Fail("Invalid name, too short");
            }
            catch (InvalidArtistNameException) { }

            try
            {
                (new Artitem()).SetArtist("asd#$%");
                Assert.Fail("Invalid name, invalid character");
            }
            catch (InvalidArtistNameException) { }

            try
            {
                (new Artitem()).SetArtist("12345678901234567890123456789021345678900");   // 41
                Assert.Fail("Invalid name, too long maximum 40 chars");
            }
            catch (InvalidArtistNameException) { }

            try
            {
                (new Artitem()).SetArtist("vfsdvasdfgscfgsdf eretde");
            }
            catch (InvalidArtistNameException)
            {
                Assert.Fail("Failed at a valid name");
            }
        }


        [TestMethod]
        public void InvalidName()
        {
            try
            {
                (new Artitem()).SetName("qweqwe12");
                Assert.Fail("Invalid name, no digits alowed");
            }
            catch (InvalidNameException) { }

            try
            {
                (new Artitem()).SetName("a");
                Assert.Fail("Invalid name, too short");
            }
            catch (InvalidNameException) { }

            try
            {
                (new Artitem()).SetName("Gig #hashtag");
                Assert.Fail("Invalid name, invalid character");
            }
            catch (InvalidNameException) { }

            try
            {
                (new Artitem()).SetName("12345678901234567890123456789021345678900");   // 41
                Assert.Fail("Invalid name, too long maximum 40 chars");
            }
            catch (InvalidNameException) { }

            try
            {
                (new Artitem()).SetName("vfsdvasdfgscfgsdf eretde");
            }
            catch (InvalidNameException)
            {
                Assert.Fail("Failed at a valid name");
            }
        }
    }
}
