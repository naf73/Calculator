using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace TestCalc
{
    [TestClass]
    public class UnitTestCalc
    {
        [TestMethod]
        public void TestMethodAddition()
        {
            #region Arrange
            int a = 1; int b = 2; int c;
            #endregion
            #region Action
            Controller.Addition(a, b);
            int.TryParse(Controller.Addition(a,b),out c);
            #endregion
            #region Assert
            Assert.AreEqual(c ,3);
            #endregion
        }
        [TestMethod]
        public void TestMethodSubstraction()
        {
            #region Arrange
            int a = 5; int b = 6;int c;
            #endregion
            #region Action
            int.TryParse(Controller.Substraction(a, b),out c);
            #endregion
            #region Assert
            Assert.AreEqual(c, -1); 
            #endregion
        }
        [TestMethod]
        public void TestMethodDivide()
        {
            #region Arrange
            int a = 25; int b = 5; int c;
            #endregion
            #region Action
            int.TryParse(Controller.Division(a, b), out c);
            #endregion
            #region Assert
            Assert.AreEqual(c, 5);
            #endregion
        }
        [TestMethod]
        public void TestMethodMulti()
        {
            #region Arrange
            int a = 4; int b = 7; int c;
            #endregion
            #region Action
            int.TryParse(Controller.Multiplication(a, b), out c);
            #endregion
            #region Assert
            Assert.AreEqual(c, 28);
            #endregion
        }

    }
}
