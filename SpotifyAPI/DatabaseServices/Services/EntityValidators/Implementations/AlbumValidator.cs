﻿using DatabaseServices.Services.EntityValidators.Interfaces;
using DatabaseServices.Services.Repositories.Implementations;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.InterServices.EntityValidationCodes;
using Models.DTO.InterServices.ValidationResult;

namespace DatabaseServices.Services.EntityValidators.Implementations;

public class AlbumValidator : EntityValidator, IAlbumValidator
{
    private readonly IAuthorRepository _authorRepository;

    public AlbumValidator(IAuthorRepository authorRepository)
    {
        _authorRepository = authorRepository;
    }

    public async Task<AlbumValidationResult> Validate(AlbumCreationData data)
    {
        var state = (AlbumValidationCode)EntityValidator.Validate(data).ValidationCode;
        var author = await _authorRepository.GetById(data.AuthorId);
        if (data.ReleaseYear > DateTime.Now.Year || data.ReleaseYear < 0)
            state = AlbumValidationCode.InvalidReleaseYear;
        if (author == null)
            state = AlbumValidationCode.InvalidAuthor;
        return new AlbumValidationResult(state, author);
    }
}