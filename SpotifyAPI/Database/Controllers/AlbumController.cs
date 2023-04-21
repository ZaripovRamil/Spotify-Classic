﻿using Database.Services;
using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;

namespace Database.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumController
{
    private readonly IDbAlbumAccessor _albumAccessor;
    private readonly IAlbumFactory _albumFactory;
    private readonly IDtoCreator _dtoCreator;

    public AlbumController(IDbAlbumAccessor albumAccessor, IAlbumFactory albumFactory, IDtoCreator dtoCreator)
    {
        _albumAccessor = albumAccessor;
        _albumFactory = albumFactory;
        _dtoCreator = dtoCreator;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> ProcessAlbumCreation([FromBody] AlbumCreationData data)
    {
        var (state, album) = await _albumFactory.Create(data);
        if (state == AlbumCreationCode.Successful) await _albumAccessor.Add(album!);
        return new JsonResult(new AlbumCreationResult(state, album));
    }
    
    [HttpGet]
    [Route("Get")]
    public Task<IActionResult> GetAllAsync()
    {
        var albums = _albumAccessor
            .GetAll()
            .Select(album => new AlbumLight(album));
        return Task.FromResult<IActionResult>(new JsonResult(albums));
    }

    [HttpGet]
    [Route("get/id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _albumAccessor.GetById(id)));
    }

    [HttpGet]
    [Route("get/name/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _albumAccessor.GetByName(name)));
    }
}