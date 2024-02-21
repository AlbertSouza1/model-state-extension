## Features
An extension to help you get the error messages from your ASP.NET API Model errors.

## How to use
When you receive data using a model from the body of an API request, you want to validate if the data is correct to proceed with the request. When you check the state of your model and you get an invalid return, you can use this extension to get the errors.

Note: the `ModelState` must be a `Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary`

### Getting all error messages as a list:

To get all the error messages from your model, use the `GetErrors` extension so you can have a list with all the messages:
```csharp
public async Task<IActionResult> CreateAccount([FromBody] RegisterViewModel model)
{
   if (!ModelState.IsValid)
      return BadRequest(ModelState.GetErrors());
      //Calls the extension method GetErrors to return the list of errors
```

### Getting the first error message:

"If you need to get only a single error message, you can use the `GetFirstError` extension. Using this function, you'll get the first error found from your model:
```csharp
public async Task<IActionResult> CreateAccount([FromBody] RegisterViewModel model)
{
   if (!ModelState.IsValid)
      return BadRequest(ModelState.GetFirstError());
      //Calls the extension method GetFirstError to return the first error message found
```