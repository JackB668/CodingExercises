using System;
using CodingExercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class MathTests
        {
            [TestMethod]
            public void TestAddTwoPositiveInts()
            {
                const int firstNumber = 5;
                const int secondNumber = 3;
                const int expectedAnswer = 8;

                Assert.AreEqual(expectedAnswer, MyCustomMethods.AddTwoNumbers(firstNumber, secondNumber), "Add two postive ints failed");
            }
        }
    }
}
