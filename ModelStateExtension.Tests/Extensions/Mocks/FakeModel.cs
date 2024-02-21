using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ModelStateExtension.Tests.Extensions.Mocks
{
    public class FakeModel : ModelStateDictionary
    {
        [Required]
        public int TesteInt { get; set; }
        [Required]
        public string TesteString { get; set; }
    }
}