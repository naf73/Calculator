using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace TestCalc
{
    [TestClass]
    public class UnitTestController
    {
        [TestMethod]
        public void TestMethodAdditionOnePlusTwoPossitive()
        {
            #region Arrange

            double a = 1;
            double b = 2;
            double c;
            
            #endregion

            #region Action

            Controller.Addition(a, b);
            c = Controller.Addition(a, b);

            #endregion

            #region Assert

            Assert.AreEqual(c ,3);

            #endregion
        }

        [TestMethod]
        public void TestMethodSubstractionFiveMinusSixPossitive()
        {
            #region Arrange

            double a = 5;
            double b = 6;
            double c;

            #endregion

            #region Action

            c = Controller.Substraction(a, b);

            #endregion

            #region Assert

            Assert.AreEqual(c, -1); 
            
            #endregion
        }

        [TestMethod]
        public void TestMethodDivideTwentyFiveDivideFivePossitive()
        {
            #region Arrange

            double a = 25;
            double b = 5;
            double c;

            #endregion

            #region Action

            c = Controller.Division(a, b);
            
            #endregion

            #region Assert

            Assert.AreEqual(c, 5);
            
            #endregion
        }

        [TestMethod]
        public void TestMethodMultiFourAndSevenPossitive()
        {
            #region Arrange

            double a = 4;
            double b = 7;
            double c;
            
            #endregion

            #region Action

            c = Controller.Multiplication(a, b);

            #endregion

            #region Assert

            Assert.AreEqual(c, 28);
            
            #endregion
        }

        [ExpectedException(typeof(System.Exception))]
        [TestMethod]
        public void TestMethodDivideByZeroExeption()
        {
            #region Arrange

            double a = 5;
            double b = 0;
            
            #endregion
            
            #region Exception

            Controller.Division(a, b);
            
            #endregion
        }

    }
}
