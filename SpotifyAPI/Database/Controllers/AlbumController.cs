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
    //TODO:GetByName|Id
}