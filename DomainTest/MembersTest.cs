namespace DomainTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Domain;
    using Controlller.Classes;
    using DAL;
    using System.Data.Entity;
    using System.Data.Entity.Validation;
    using Controlller.Interfaces;

    [TestClass]
    public class MembersTest
    {
        private ArtclubContext _dBcontext;

        [TestInitialize]
        public void TestSetup()
        {
            _dBcontext = new ArtclubContext();
        }


        [TestMethod]
        public void TestGetAllMembers()
        {

            IMemberCtrl ctrl = new MemberCtrl();
            var membs = ctrl.GetAllMembers();
            Assert.AreNotEqual(0, membs.Count, "There are 0 membs in the list");

        }


        [TestMethod]
        public void SeedDatabase() 
        {
            var dbInit = new ContentInitializer();
            Database.SetInitializer(dbInit);


            try
            {
                dbInit.InitializeDatabase(_dBcontext);
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var errors in ex.EntityValidationErrors)
                    foreach (var error in errors.ValidationErrors)
                        System.Diagnostics.Debug.WriteLine(error.PropertyName + " message: " + error.ErrorMessage);
            }
        }

        [TestMethod]
        public void TestEmail()
        {
            try 
	        {
                (new Member()).SetEmail("abraca@");
                Assert.Fail("Invalid email address");
	        }
            catch (InvalidMailException) { }

            try
            {
                (new Member()).SetEmail("abraca@.com");
                Assert.Fail("Invalid email address");
            }
            catch (InvalidMailException) { }

            try
            {
                (new Member()).SetEmail("aaa.com");
                Assert.Fail("Invalid email address");
            }
            catch (InvalidMailException) { }

            try
            {
                (new Member()).SetEmail("abraca#$@ucn.dk");
                Assert.Fail("Invalid email address");
            }
            catch (InvalidMailException) { }

            try
            {
                (new Member()).SetEmail("one_email@gmail.dk");
                Assert.Fail("Invalid email address");
            }
            catch (InvalidMailException)
            {
                
            }

            try
            {
                (new Member()).SetEmail("one_email@ucn.dk");
            }
            catch (InvalidMailException)
            {
                Assert.Fail("Failed at a valid ucn address");
            }

            try
            {
                (new Member()).SetEmail("1028752@ucn.dk");
            }
            catch (InvalidMailException)
            {
                Assert.Fail("Failed at a valid email address");
            }
        }


        [TestMethod]
        public void TestName()
        {
            try
            {
                (new Member()).SetName("Filip0 Max");
                Assert.Fail("Invalid name, no digits alowed");
            }
            catch (InvalidNameException) { }

            try
            {
                (new Member()).SetName("M");
                Assert.Fail("Invalid name, too short");
            }
            catch (InvalidNameException) { }

            try
            {
                (new Member()).SetName("Gig #hashtag");
                Assert.Fail("Invalid name, invalid character");
            }
            catch (InvalidNameException) { }

            try
            {
                (new Member()).SetName("Gigi qwertyuiopqwertyuioqwertyuio  qwerty");   // 41
                Assert.Fail("Invalid name, too long maximum 40 chars");
            }
            catch (InvalidNameException) { }

            try
            {
                (new Member()).SetName("Gigi Hashtag");
            }
            catch (InvalidNameException)
            {
                Assert.Fail("Failed at a valid name");
            }
        }

        [TestMethod]
        public void TestPhone()
        {
            try
            {
                new Member().SetPhone("123456789");
                Assert.Fail("Invalid phone, too many digits");
            }
            catch (InvalidPhoneException) { }


            try
            {
                (new Member()).SetPhone("1234567");
                Assert.Fail("Invalid phone, too short");
            }
            catch (InvalidPhoneException) { }

            try
            {
                (new Member()).SetPhone("00451234567");
                Assert.Fail("Invalid phone, too short");
            }
            catch (InvalidPhoneException) { }

            try
            {
                (new Member()).SetPhone("+451234567");
                Assert.Fail("Invalid phone, too short");
            }
            catch (InvalidPhoneException) { }

            try
            {
                (new Member()).SetPhone("+45123456789");
                Assert.Fail("Invalid phone, too long");
            }
            catch (InvalidPhoneException) { }

            try
            {
                (new Member()).SetPhone("0045123456789");
                Assert.Fail("Invalid phone, too long");
            }
            catch (InvalidPhoneException) { }



            try
            {
                (new Member()).SetPhone("+4212345678");
                Assert.Fail("Invalid phone, invalid country code");
            }
            catch (InvalidPhoneException) { }

            try
            {
                (new Member()).SetPhone("004212345678");
                Assert.Fail("Invalid phone, invalid country code");
            }
            catch (InvalidPhoneException) { }


            try
            {
                (new Member()).SetPhone("12345678");
            }
            catch (InvalidPhoneException)
            {
                Assert.Fail("Failed at a valid phone number");
            }

            try
            {
                (new Member()).SetPhone("+4512345678");
            }
            catch (InvalidPhoneException)
            {
                Assert.Fail("Failed at a valid phone number");
            }

            try
            {
                (new Member()).SetPhone("004512345678");
            }
            catch (InvalidPhoneException)
            {
                Assert.Fail("Failed at a valid phone number");
            }
        }
    }
}
