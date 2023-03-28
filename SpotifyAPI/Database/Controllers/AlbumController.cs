using Database.Services;
using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Mvc;
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
        return new JsonResult(_dtoCreator.CreateFull(await _albumAccessor.GetById(id)));
    }
    
    [HttpGet]
    [Route("get/name/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _albumAccessor.GetByName(name)));
    }
    //TODO:GetByName|Id
}