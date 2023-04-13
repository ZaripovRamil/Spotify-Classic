using Database.Services;
using Database.Services.Accessors.Interfaces;
using Database.Services.Factories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.DTO.BackToFront.EntityCreationResult;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.Entities;

namespace Database.Controllers;
[ApiController]
[Route("[controller]")]
public class AlbumController
{
    private readonly IDbAlbumAccessor _albumAccessor;
    private readonly IDbAuthorAccessor _authorAccessor;
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
        
        return new JsonResult(new AlbumCreationResult(await CreateAlbum(data)));
    }

    private async Task<(AlbumCreationCode, Album?)>CreateAlbum(AlbumCreationData data)
    {
        if (await _authorAccessor.GetById(data.AuthorId) == null) return (AlbumCreationCode.InvalidAuthor, null);
        var album = await _albumFactory.Create(data);
        if (album == null) return (AlbumCreationCode.UnknownError, null);
        await _albumAccessor.Add(album);
        return (AlbumCreationCode.Successful, album);
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