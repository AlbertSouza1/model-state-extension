using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ModelStateExtension.Extensions
{
    public static class ModelStateDictionaryExtension
    {
        /// <summary>
        /// Returns all error messages from an invalid model.
        /// </summary>
        /// <returns>
        /// All error messages from the model as a list of strings. If there are no errors, returns an empty list.
        /// </returns>
        /// <exception cref="NullReferenceException">
        /// Throws when the model is null.
        /// </exception>
        public static List<string> GetErrors(this ModelStateDictionary modelState)
        {
            var errors = new List<string>();

            foreach (var item in modelState.Values)
                errors.AddRange(item.Errors.Select(x => x.ErrorMessage));

            return errors;
        }

        /// <summary>
        /// Returns the first error message found in the model.
        /// </summary>
        /// <returns>
        /// The first error message found. If there are no errors, returns an empty string.
        /// </returns>
        /// <exception cref="NullReferenceException">
        /// Throws when the model is null.
        /// </exception>
        public static string GetFirstError(this ModelStateDictionary modelState)
        {
            if (modelState.IsValid) return string.Empty;

            ModelError firstError;

            foreach (var item in modelState.Values)
            {
                firstError = item.Errors.FirstOrDefault();

                if (firstError != null)
                    return firstError.ErrorMessage;
            }

            return string.Empty;
        }
    }
}