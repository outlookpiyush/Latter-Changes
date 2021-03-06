﻿using LatterChanges.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LatterChanges.MS.Testing
{
    [TestClass]
    public class NegativeCase
    {
        #region Declaraction

        string inputString = string.Empty;
        string expected = string.Empty;

        #endregion Declaraction

        #region Test Initialize
        /// <summary>
        /// Test Initialize with Specific Value
        /// </summary>
        [TestInitialize]
        public void TestInit()
        {
            inputString = "fun times!";
            expected = "gvO Ujmft";
        }

        #endregion Test Initialize

        #region Test Method
        /// <summary>
        /// Test Method Definition
        /// </summary>
        [TestMethod]
        public void NegativeTestCase()
        {
            //Assert 
            var latterChangeLogic = new LatterChangeLogic();
            string outPut = latterChangeLogic.GetChangeLatter(inputString);

            //Act 
            Assert.IsTrue(expected.Equals(outPut));
        }
        #endregion Test Method

        #region Clear Up
        /// <summary>
        /// Clear Variable and Object
        /// </summary>
        [TestCleanup]
        public void ClearData()
        {
            inputString = string.Empty;
            expected = string.Empty;
        }
        #endregion Clear Up
    }
}
