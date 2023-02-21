using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ModelStateExtension.Extensions
{
    public static class ModelStateDictionaryExtension
    {
        public static List<string> GetErrors(this ModelStateDictionary modelState)
        {
            var errors = new List<string>();

            foreach (var item in modelState.Values)
                errors.AddRange(item.Errors.Select(x => x.ErrorMessage));

            return errors;
        }
    }
}