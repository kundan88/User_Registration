using NUnit.Framework;
using RegularExpession;

namespace RegularExpressionTest
{
    public class Tests
    {
        Program program;
        UserRegistration userRegistration;
        string Result;
        [SetUp]
        public void Setup()
        {
            userRegistration = new UserRegistration();
            program = new Program();
        }

        [Test]
        public void Given_FirstName_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validFirstName("Kundan");
            Assert.AreEqual("First Name is valid", Result);
        }
        [Test]
        public void Given_LaststName_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validLastName("Kamble");
            Assert.AreEqual("Last Name is valid", Result);
        }
        [Test]
        public void Given_EmailId_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validEmail("kundan@bl.co.in");
            Assert.AreEqual("EmailId is valid", Result);
        }
        [Test]
        public void Given_MobileNo_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validMobileNo("91 7410741141");
            Assert.AreEqual("MobileNo is valid", Result);
        }
        [Test]
        public void Given_Password_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validPassword("AsdFg123");
            Assert.AreEqual("Password is valid", Result);
        }
        [Test]
        public void Given_Email_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validCheckEmailSample("abc-100@yahoo.com");
            Assert.AreEqual("Email is valid", Result);
        }
    }
}

