using DatabaseServices.Services;
using DatabaseServices.Services.Accessors.Interfaces;
using DatabaseServices.Services.DeleteHandlers.Interfaces;
using DatabaseServices.Services.Factories.Interfaces;
using DatabaseServices.Services.UpdateHandlers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.BackToFront.Full;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.DTO.InterServices.EntityValidationCodes;

namespace DatabaseAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AlbumController
{
    private readonly IDbAlbumAccessor _albumAccessor;
    private readonly IAlbumFactory _albumFactory;
    private readonly IDtoCreator _dtoCreator;
    private readonly IAlbumDeleteHandler _albumDeleteHandler;
    private readonly IAlbumUpdateHandler _albumUpdateHandler;

    public AlbumController(IDbAlbumAccessor albumAccessor, IAlbumFactory albumFactory, IDtoCreator dtoCreator,
        IAlbumDeleteHandler albumDeleteHandler, IAlbumUpdateHandler albumUpdateHandler)
    {
        _albumAccessor = albumAccessor;
        _albumFactory = albumFactory;
        _dtoCreator = dtoCreator;
        _albumDeleteHandler = albumDeleteHandler;
        _albumUpdateHandler = albumUpdateHandler;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> ProcessAlbumCreation([FromBody] AlbumCreationData data)
    {
        var (state, album) = await _albumFactory.Create(data);
        if (state == AlbumValidationCode.Successful) await _albumAccessor.Add(album!);
        return new JsonResult(new AlbumCreationResult(state, album));
    }
    
    // [HttpGet]
    // [Route("Get")]
    // public Task<IActionResult> GetAllAsync()
    // {
    //     var albums = _albumAccessor
    //         .GetAll()
    //         .Select(album => new AlbumFull(album));
    //     return Task.FromResult<IActionResult>(new JsonResult(albums));
    // }

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

    [HttpDelete]
    [Route("delete/{id}")]
    public async Task<IActionResult> DeleteById(string id)
    {
        return new JsonResult(await _albumDeleteHandler.HandleDeleteById(id));
    }

    [HttpPut]
    [Route("update/{id}")]
    public async Task<IActionResult> UpdateById(string id, AlbumUpdateData albumUpdateData)
    {
        return new JsonResult(await _albumUpdateHandler.HandleUpdateById(id, albumUpdateData));
    }

    [HttpGet("get")]
    public async Task<IActionResult> GetWithFiltersAsync([FromQuery] string? albumType, [FromQuery] int? tracksMin,
        [FromQuery] int? tracksMax, [FromQuery] int? maxCount, [FromQuery] string? search)
    {
        return new JsonResult(_albumAccessor.GetAll().Where(a =>
            (albumType is null || string.Equals(a.Type.ToString(), albumType, StringComparison.CurrentCultureIgnoreCase)) &&
            (tracksMin is null || a.Tracks.Count >= tracksMin.Value) &&
            (tracksMax is null || a.Tracks.Count <= tracksMax.Value) &&
            (search is null || a.Name.ToLower().Contains(search.ToLower())))
            .Take(new Range(0, maxCount ?? -1))
            .Select(a => new AlbumFull(a)));
    }
}