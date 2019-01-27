using UniversityofSarre_Assignment2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniversityofSarre.Tests
{
    [TestClass]
    public class ClassTests
    {
        //StubStudentTestData
        public static string firstName = "Donald";
        public static string lastName = "Jones";
        public static string tutor = "Tim";
        public static string currentUser = "Default";
        Student objStudent = new Student(firstName, lastName, tutor, currentUser);

        [TestMethod]
        public void StudentObjectCreation()
        {
            //Arrange
            string expected = "Donald, Default, Tim";
            //Act
            string actual = objStudent.GetName() + ", " + objStudent.GetAdded() + ", " + objStudent.GetTutor();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StudentIDCreation()
        {
            string expected = "Jon18100001";

            string actual = objStudent.GetID();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StudentEmailOverrideCorrectly()
        {
            string expected = "Jon18100001@sarre.ac.uk";

            string actual = objStudent.GetEmail();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LecturerEmailOverrideCorrectly()
        {
            string firstName = "Donald";
            string lastName = "Jones";
            string dept = "Computing";
            string pass = "password";
            Lecturer objLecturer = new Lecturer(firstName, lastName, dept, pass);
            string expected = "Donald.Jones@sarre.ac.uk";

            string actual = objLecturer.GetEmail();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AdminEmailOverrideCorrectly()
        {
            string firstName = "Donald";
            string lastName = "Jones";
            string dept = "Computing";
            Admin objAdmin = new Admin(firstName, lastName, dept);
            string expected = "DJ100001@sarre.ac.uk";

            string actual = objAdmin.GetEmail();

            Assert.AreEqual(expected, actual);
        }
    }
}
