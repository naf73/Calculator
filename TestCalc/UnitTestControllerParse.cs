using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace TestCalc
{
    [TestClass]
    public class UnitTestControllerParse
    {
        [TestMethod]
        public void TestMethodParseString()
        {
            #region Arrange

            string expression = "62 + 52 - 10 / 2";
            List<double> numbersActual = new List<double>() { 62, 52, 10, 2 };
            List<eOperation> operationsActual = new List<eOperation> { eOperation.addition,
                                                                       eOperation.subtraction,
                                                                       eOperation.division};
            List<double> numberExpect = new List<double>();
            List<eOperation> operationsExpect = new List<eOperation>();
            #endregion

            #region Action

            

            #endregion

            #region Assert

            #endregion
        }
    }
}
