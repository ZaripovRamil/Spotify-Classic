using Models.Configuration;
using Utils.CQRS;
using static Utils.CQRS.Validation.CommonValidationHandlers;
using static Models.ValidationErrors.EntityErrors;
using static Models.ValidationErrors.AlbumErrors;

namespace AdminAPI.Features.Albums.Create.AlbumSavers;

public class PreviewValidator
{
    private readonly IHttpClientFactory _httpClientFactory;

    public PreviewValidator(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public async Task<Result> ValidateAsync(Command item)
    {
        var result = new Result();
        if (item.PreviewImage.Length == 0)
            result.AddErrors(InvalidPreview);
        if (!BeNotNullNotEmpty(item.PreviewId))
            result.AddErrors(FieldEmpty(nameof(Command.PreviewId)));
        
        var client = _httpClientFactory.CreateClient(nameof(Hosts.StaticApi));
        try
        {
            var res = await client.GetAsync($"previews/{item.PreviewId}");
            if (res.IsSuccessStatusCode)
                result.AddErrors("Preview already exists.");
        }
        catch (Exception)
        {
            result.AddErrors("Unable to connect to the server. Please try again later.");
        }
        
        return result;
    }
}