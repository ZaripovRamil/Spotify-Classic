using DatabaseServices.Services;
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
public class AuthorController
{
    private readonly IDbAuthorAccessor _authorAccessor;
    private readonly IAuthorFactory _authorFactory;
    private readonly IDtoCreator _dtoCreator;
    private readonly IAuthorDeleteHandler _authorDeleteHandler;
    private readonly IAuthorUpdateHandler _authorUpdateHandler;

    public AuthorController(IDbAuthorAccessor authorAccessor, IDtoCreator dtoCreator,
        IAuthorFactory authorFactory, IAuthorDeleteHandler authorDeleteHandler, IAuthorUpdateHandler authorUpdateHandler)
    {
        _authorAccessor = authorAccessor;
        _dtoCreator = dtoCreator;
        _authorFactory = authorFactory;
        _authorDeleteHandler = authorDeleteHandler;
        _authorUpdateHandler = authorUpdateHandler;
    }

    [HttpPost]
    [Route("Add")]
    public async Task<IActionResult> ProcessAuthorCreation([FromBody] AuthorCreationData data)
    {
        var (state, author) = await _authorFactory.Create(data);
        if (state == AuthorValidationCode.Successful) await _authorAccessor.Add(author!);
        return new JsonResult(new AuthorCreationResult(state, author));
    }
    
    [HttpGet]
    [Route("Get")]
    public Task<IActionResult> GetAllAsync()
    {
        var authors = _authorAccessor
            .GetAll()
            .Select(author => new AuthorLight(author));
        return Task.FromResult<IActionResult>(new JsonResult(authors));
    }

    [HttpGet]
    [Route("get/id/{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _authorAccessor.GetById(id)));
    }

    [HttpGet]
    [Route("get/name/{name}")]
    public async Task<IActionResult> GetByName(string name)
    {
        return new JsonResult(_dtoCreator.CreateFull(await _authorAccessor.GetByName(name)));
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public async Task<IActionResult> DeleteById(string id)
    {
        return new JsonResult(await _authorDeleteHandler.HandleDeleteById(id));
    }

    [HttpPut]
    [Route("update/{id}")]
    public async Task<IActionResult> UpdateById(string id, [FromBody] AuthorUpdateData updateData)
    {
        return new JsonResult(await _authorUpdateHandler.HandleUpdateById(id, updateData));
    }
}