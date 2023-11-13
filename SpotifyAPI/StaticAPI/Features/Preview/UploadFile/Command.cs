using StaticAPI.Dto;
using Utils.CQRS;

namespace StaticAPI.Features.Preview.UploadFile;

public record Command(IFormFile? File) : ICommand<ResultDto>;