using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelStateExtension.Extensions;

namespace ModelStateExtension.Tests.Extensions
{
    [TestClass]
    public class ModelStateDictionaryExtensionTest
    {
        [TestMethod]
        public void Should_throw_exception_when_model_is_null()
        {
            ModelStateDictionary sut = null;

            Assert.ThrowsException<NullReferenceException>(sut.GetErrors);
        }
    }
}