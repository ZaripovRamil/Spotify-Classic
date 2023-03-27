using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.Full;
using Models.DTO.FrontToBack.EntityCreationData;

namespace Database.Controllers;
[ApiController]
[Route("[controller]")]
public class AlbumController
{
    private readonly IDbAlbumAccessor _albumAccessor;
    private readonly IAlbumFactory _albumFactory;

    public AlbumController(IDbAlbumAccessor albumAccessor, IAlbumFactory albumFactory)
    {
        _albumAccessor = albumAccessor;
        _albumFactory = albumFactory;
    }
    [HttpPost]
    [Route("Add")]
    public async Task Add([FromBody] AlbumCreationData aData)
    {
        var album = await _albumFactory.Create(aData);
        if (album != null)
            await _albumAccessor.Add(album);
    }
    
    [HttpGet]
    [Route("get/id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var album =  await _albumAccessor.GetById(id);
        return new JsonResult(album == null ? null : new AlbumFull(album));
    }
    
    [HttpGet]
    [Route("get/name/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        var album =  await _albumAccessor.GetByName(name);
        return new JsonResult(album == null ? null : new AlbumFull(album));
    }
    //TODO:GetByName|Id
}