using System.Text.Json;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Models;

public class FormDataJsonBinder : IModelBinder
{
    private readonly ILogger<FormDataJsonBinder> _logger;

    public FormDataJsonBinder(ILogger<FormDataJsonBinder> logger)
    {
        _logger = logger;
    }

    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        if (bindingContext == null)
        {
            throw new ArgumentNullException(nameof(bindingContext));
        }

        var modelName = bindingContext.ModelName;

        var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);

        if (valueProviderResult == ValueProviderResult.None)
        {
            return Task.CompletedTask;
        }

        bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);

        var value = valueProviderResult.FirstValue;

        if (string.IsNullOrEmpty(value))
        {
            return Task.CompletedTask;
        }

        try
        {
            var result = JsonSerializer.Deserialize(value, bindingContext.ModelType);
            bindingContext.Result = ModelBindingResult.Success(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            bindingContext.Result = ModelBindingResult.Failed();
        }

        return Task.CompletedTask;
    }
}