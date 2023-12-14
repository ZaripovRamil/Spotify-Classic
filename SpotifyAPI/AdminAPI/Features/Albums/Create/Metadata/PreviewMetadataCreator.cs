using AdminAPI.Services;
using Models.Metadata;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using Utils.CQRS;

namespace AdminAPI.Features.Albums.Create.Metadata;

public class PreviewMetadataCreator: IMetadataCreator<Command,ImageMetadata>
{
    public Task<Result<ImageMetadata>> CreateMetadata(Command item)
    {
        var stream = item.PreviewImage.OpenReadStream();
        using var image = Image.Load<Rgba32>(stream);
        stream.Position = 0;
        return Task.FromResult(new Result<ImageMetadata>(new ImageMetadata(item.PreviewId, item.PreviewImage.FileName, item.PreviewImage.Length,image.Width, image.Height)));
    }
}