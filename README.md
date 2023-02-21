## Features
An extension to get a list of errors from an ASP.NET API Model.

## How to use
When you receive data using a model from the body of an API request, you want to validate if the data is correct to proceed the request. When you check the state of your model and you get an invalid return, you can use this extension to get the errors as a list of strings.

Note: the `ModelState` must be an `Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary`

### Example:
```csharp
public async Task<IActionResult> CreateAccount([FromBody] RegisterViewModel model)
{
   if (!ModelState.IsValid)
      return BadRequest(ModelState.GetErrors());
      //Calls the extension method GetErrors to return the error list
```
