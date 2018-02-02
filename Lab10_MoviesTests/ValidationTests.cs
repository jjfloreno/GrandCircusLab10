using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab10_Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Movies.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void CategoryTest()
        {
            Assert.IsFalse(Validation.Category("a"));
            Assert.IsFalse(Validation.Category("5"));
            Assert.IsFalse(Validation.Category(" "));
            Assert.IsFalse(Validation.Category(""));
        }

        [TestMethod()]
        public void ContinueTest()
        {
            Assert.IsFalse(Validation.Continue("a"));
            Assert.IsFalse(Validation.Continue("5"));
            Assert.IsFalse(Validation.Continue(" "));
            Assert.IsFalse(Validation.Continue(""));
        }
    }
}