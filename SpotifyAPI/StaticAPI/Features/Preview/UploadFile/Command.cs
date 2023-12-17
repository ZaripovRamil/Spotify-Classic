using StaticAPI.Dto;
using StaticAPI.Dto.FileDataDTO;
using Utils.CQRS;

namespace StaticAPI.Features.Preview.UploadFile;

public record Command(ImageDataDto? Data) : ICommand<ResultDto>;