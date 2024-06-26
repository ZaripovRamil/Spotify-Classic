﻿using Models.DTO.OAuth;
using Utils.CQRS;

namespace AuthAPI.Features.SignUp.OAuth;

public record Command(GoogleLoginData LoginData) : ICommand<ResultDto>;