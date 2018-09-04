using System;
using Firstday3semester;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstTest
{
    [TestClass]
    public class UnitTest1
    {
        Student student1 = new Student("Christian", "Bakkesvinget 69", Gender.Male, 3);
        Student student2 = new Student("Sarah", "Holbækvej 54", Gender.Male, 3);

        Teacher teacher1 = new Teacher("Henrik", "Roskildevej 2",100, Gender.Male);
        Teacher teacher2 = new Teacher("Pernille", "Fjordvej 55",3400, Gender.Female);

        [TestMethod]
        public void TestMethod1()
        {
         Assert.AreEqual("Christian",student1.Name);
         Assert.AreEqual("Sarah",student2.Name);

         Assert.AreEqual("Henrik", teacher1.Name);
         Assert.AreEqual("Pernille", teacher2.Name);
         
           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestException()
        {
            student1.Semester = 0;
        }

        [TestMethod]
        public int TestForExpectedSalery()
        {
            teacher1.CountSalery();
            return 0;
        }
    }
}
