using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ModelStateExtension.Extensions
{
    public static class ModelStateDictionaryExtension
    {
        public static List<string> GetErrors(this ModelStateDictionary modelState)
        {
            var result = new List<string>();

            foreach (var item in modelState.Values)
                result.AddRange(item.Errors.Select(x => x.ErrorMessage));

            return result;
        }
    }
}