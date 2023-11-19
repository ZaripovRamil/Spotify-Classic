﻿using StaticAPI.Dto;
using Utils.CQRS;

namespace StaticAPI.Features.Track.UploadTrack;

public record Command (IFormFile? File) : ICommand<ResultDto>;