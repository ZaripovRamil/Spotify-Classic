using Models.DTO;
using Models.DTO.FileDataDTO;
using StaticAPI.Dto;
using Utils.CQRS;

namespace StaticAPI.Features.Preview.UploadFile;

public record Command(ImageDataDto? Data) : ICommand<ResultDto>;