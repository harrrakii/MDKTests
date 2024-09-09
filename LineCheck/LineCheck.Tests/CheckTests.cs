using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LineCheck.Tests
{
    [TestClass]
    public class CheckTests
    {
        [TestMethod]
        public void GetPswdPoint_WrongPassword_0Points()
        {
            // arrange
            string password = "";  
            int expected = 0; 
            Check check = new Check();
            // act
            int actual = check.GetPasswordPoint(password);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPswdPoint_OnlyNumbers_1Point()
        {
            // arrange
            string password = "123";
            int expected = 1; 
            Check check = new Check();
            // act
            int actual = check.GetPasswordPoint(password);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPswdPoint_LowerLettersAndNumbers_2Points()
        {
            // arrange
            string password = "abc123";
            int expected = 2;  
            Check check = new Check();
            // act
            int actual = check.GetPasswordPoint(password);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPswdPoint_UpperLettersAndLowerLettersAndNumbers_3Points()
        {
            // arrange
            string password = "Abc123";
            int expected = 3; 
            Check check = new Check();
            // act
            int actual = check.GetPasswordPoint(password);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPswdPoint_UpperLettersAndLowerLettersAndSpecialCharAndNumbers_4Points()
        {
            // arrange
            string password = "Abc!123";
            int expected = 4;  
            Check check = new Check();
            // act
            int actual = check.GetPasswordPoint(password);
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPswdPoint_AllOptions_5Points()
        {
            // arrange
            string password = "Abcdefg123!";
            int expected = 5; 
            Check check = new Check();
            // act
            int actual = check.GetPasswordPoint(password);
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
