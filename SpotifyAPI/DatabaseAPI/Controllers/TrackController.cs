﻿using DatabaseServices.Services;
using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.DeleteHandlers.Interfaces;
using DatabaseServices.Services.Factories.Interfaces;
using DatabaseServices.Services.UpdateHandlers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Light;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.DTO.InterServices.EntityValidationCodes;

namespace DatabaseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TrackController
{
    private readonly ITrackFactory _trackFactory;
    private readonly IDbTrackAccessor _trackAccessor;
    private readonly IDtoCreator _dtoCreator;
    private readonly ITrackDeleteHandler _trackDeleteHandler;
    private readonly ITrackUpdateHandler _trackUpdateHandler;

    public TrackController(ITrackFactory trackFactory, IDbTrackAccessor trackAccessor, IDtoCreator dtoCreator, ITrackDeleteHandler trackDeleteHandler, ITrackUpdateHandler trackUpdateHandler)
    {
        _trackFactory = trackFactory;
        _trackAccessor = trackAccessor;
        _dtoCreator = dtoCreator;
        _trackDeleteHandler = trackDeleteHandler;
        _trackUpdateHandler = trackUpdateHandler;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> ProcessTrackCreation([FromBody] TrackCreationData data)
    {
        var (state, track) = await _trackFactory.Create(data);
        if (state == TrackValidationCode.Successful) await _trackAccessor.Add(track!);
        return new JsonResult(new TrackCreationResult(state, track));
    }

    [HttpGet]
    [Route("Get")]
    public Task<IActionResult> GetAll()
    {
        var tracks = _trackAccessor
            .GetAll()
            .Select(track => new TrackLight(track));
        return Task.FromResult<IActionResult>(new JsonResult(tracks));
    }

    [HttpGet]
    [Route("Get/id/{id}")]
    public async Task<IActionResult> Get(string id)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _trackAccessor.Get(id)));
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public async Task<IActionResult> DeleteById(string id)
    {
        return new JsonResult(await _trackDeleteHandler.HandleDeleteById(id));
    }

    [HttpPut]
    [Route("update/{id}")]
    public async Task<IActionResult> UpdateById(string id, TrackUpdateData trackUpdateData)
    {
        return new JsonResult(await _trackUpdateHandler.HandleUpdateById(id, trackUpdateData));
    }
}