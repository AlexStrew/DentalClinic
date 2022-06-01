
using DentalClinic.Pages;
//Pages#############################
using DentalClinic.ViewModel.Login;
using DentalClinic.ViewModel.AddPat;
using DentalClinic.ViewModel.Appointment;
using DentalClinic.ViewModel.DelBooked;
using DentalClinic.ViewModel.Conclussion;
using DentalClinic.ViewModel.EditPat;
using DentalClinic.ViewModel.ProfilePage;
using DentalClinic.ViewModel.Teeth;


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
        //[TestMethod]
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
        /// Проверка ложного юзера, котогоне существует
        /// </summary>
        //[TestMethod]
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
        /// Добавление пациента
        /// </summary>
        //[TestMethod]
        public void AddPage_test_test_20150720_true()
        {
            //Arrange
            string a = "test";
            string b = "test";
            DateTime c = new DateTime(2015, 7, 20);
            bool expected = true;
            //Act
            bool actual = AddPatientClass.AddPatientMethodTest(a, b, c);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Запись пациента
        /// </summary>
        //[TestMethod]
        public void App_1_20150720_test_test_true()
        {
            //Arrange
            int a = 1;           
            DateTime b = new DateTime(2015, 7, 20);
            string c = "test";
            string d = "test";
            bool expected = true;
            //Act
            bool actual = EnrollClass.AppointmentMethodTest(a, b, c, d);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Удаление записи пациента
        /// </summary>
        //[TestMethod]
        public void DelPat_2008_true()
        {
            //Arrange
            int a = 2008;           
            bool expected = true;
            //Act
            bool actual = DelEnrollClass.DelAppMethodTest(a);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Удаление пациента
        /// </summary>
        //[TestMethod]
        public void DelPat_Амогус_true()
        {
            //Arrange
            string a = "Амогус";
            bool expected = true;
            //Act
            bool actual = AddPatientClass.DelPatientMethodTest(a);
            //Assert
            Assert.AreEqual(expected, actual);
        }


        /// <summary>
        /// Добавление заключения
        /// </summary>
        //[TestMethod]
        public void AddCon_1_test_test_test_test_test_test_test_test_1_1_true()
        {
            //Arrange
            //int a = 11;
            //int b = 11;
            //int c = 11;
            //int d = 11;
            //int e = 11;
            //int f = 11;

            int g = 1; //idpat
            string h = "test";
            string i = "test";
            string j = "test";
            string k = "test";
            string l = "test";
            string m = "test";
            string n = "test";
            string o = "test";
            int p = 1;
            int q = 1;           
            bool expected = true;
            //Act
            // a, b, c, d, e, f,
            bool actual = ConClass.AddConMethodTest( g, h, i, j, k ,l ,m ,n ,o ,p, q);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// редактирование пациента
        /// </summary>
        //[TestMethod]
        public void EditPage_AbobaNew_testNew_20150720_true()
        {
            //Arrange
            int w = 3;
            string a = "AbobaNew";
            string b = "testNew";
            DateTime c = new DateTime(2015, 7, 20);
            bool expected = true;
            //Act
            bool actual = EditPatClass.EditPatientMethodTest(w, a, b, c);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Добавление аллергии
        /// </summary>
        //[TestMethod]
        public void Allergy_1_AbobaNew_true()
        {
            //Arrange
            int a = 6;
            string b = "Russia";
            bool expected = true;
            //Act
            bool actual = AllergyClass.AddAllergyMethodTest(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Запись пациента
        /// </summary>
        [TestMethod]
        public void Teeth_1_20150720_test_test_true()
        {
            //Arrange
            int a = 4;
            string b = "3,4,5,6,7,8,9,10";
            bool expected = true;
            //Act
            bool actual = TeethClass.EditTeethMethodTest(a, b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
