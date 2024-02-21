using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelStateExtension.Extensions;
using ModelStateExtension.Tests.Extensions.Mocks;

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

        [TestMethod]
        public void Should_return_string_empty_when_model_state_is_valid()
        {
            //Arrange
            FakeModel sut = new()
            {
                TesteInt = 1,
                TesteString = "teste"
            };

            //Act
            var result = sut.GetFirstError();

            //Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void Should_return_first_error_message_when_model_has_many_errors()
        {
            //Arrange
            FakeModel sut = new() { TesteString = string.Empty };
            sut.AddModelError("TesteInt", "TesteInt is required");
            sut.AddModelError("TesteString", "TesteString is required");

            //Act
            var result = sut.GetFirstError();

            //Assert
            Assert.AreEqual("TesteInt is required", result);
        }

        [TestMethod]
        public void Should_return_first_error_message_when_model_has_a_single_error()
        {
            //Arrange
            FakeModel sut = new() { TesteString = string.Empty };
            
            sut.AddModelError("TesteString", "TesteString is required");

            //Act
            var result = sut.GetFirstError();

            //Assert
            Assert.AreEqual("TesteString is required", result);
        }

        [TestMethod]
        public void Should_throw_exception_when_trying_to_get_first_error_if_model_is_null()
        {
            ModelStateDictionary sut = null;

            Assert.ThrowsException<NullReferenceException>(sut.GetFirstError);
        }

    }
}