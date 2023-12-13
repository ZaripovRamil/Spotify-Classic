using Models.DTO;
using StaticAPI.Dto;
using Utils.CQRS;

namespace StaticAPI.Features.Preview.UploadFile;

public record Command(ImageDataDto? Data) : ICommand<ResultDto>;