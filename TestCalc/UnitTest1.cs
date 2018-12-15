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
            int a = 5; int b = 6;
            #endregion
            #region Action
            Controller.Substraction(a, b);
            #endregion
            #region Assert
            Assert.AreEqual(-1, -1); 
            #endregion
        }
        [TestMethod]
        public void TestMethodDivide()
        {
            #region Arrange

            #endregion
            #region Action

            #endregion
            #region Assert

            #endregion
        }
        [TestMethod]
        public void TestMethodMulti()
        {
            #region Arrange

            #endregion
            #region Action

            #endregion
            #region Assert

            #endregion
        }

    }
}
