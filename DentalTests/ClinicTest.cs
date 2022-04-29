
using DentalClinic.Pages;
using DentalClinic.ViewModel.Login;
using DentalTests.Modelka;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DentalTests
{

    [TestClass]
    public class ClinicTest
    {
        CoreTest db = new CoreTest();
        /// <summary>
        /// Проверка юзера
        /// </summary>
        [TestMethod]
        public void AuthMethodTest_admin_1234_true()
        {
            //Arrange
            string a = "admin";
            string b = "1234";
            bool expected = true;
            //Act
            bool actual = LoginClass.AuthMethodTest(a, b);
            //Assert
            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// Проверка ложного юзера
        /// </summary>
        [TestMethod]
        public void AuthMethodTest_qwerty_1234_false()
        {
            //Arrange
            string a = "qwerty";
            string b = "1234";
            bool expected = false;
            //Act
            bool actual = LoginClass.AuthMethodTest(a, b);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void AddPage()
        {
            //Arrange
            string a = "qwerty";
            string b = "1234";
            bool expected = false;
            //Act
            bool actual = LoginClass.AuthMethodTest(a, b);
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
