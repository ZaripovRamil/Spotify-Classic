using DatabaseServices.CommandHandlers.CreateHandlers;
using DatabaseServices.CommandHandlers.DeleteHandlers;
using DatabaseServices.CommandHandlers.UpdateHandlers;
using DatabaseServices.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models.Configuration;
using Models.DTO.BackToFront.Full;
using Models.DTO.FrontToBack.EntityCreationData;
using Models.DTO.FrontToBack.EntityUpdateData;
using Models.Entities;

namespace AdminAPI.Controllers;

[Authorize(Roles = "Admin")]
[ApiController]
[Route("[controller]")]
public class AuthorsController : Controller
{
    private readonly IAuthorRepository _authorRepository;
    private readonly IAuthorCreateHandler _authorCreateHandler;
    private readonly IAuthorDeleteHandler _authorDeleteHandler;
    private readonly IAuthorUpdateHandler _authorUpdateHandler;
    private readonly HttpClient _clientToSearch;

    public AuthorsController(IOptions<Hosts> hostsOptions, IAuthorRepository authorRepository,
        IAuthorCreateHandler authorCreateHandler, IAuthorDeleteHandler authorDeleteHandler,
        IAuthorUpdateHandler authorUpdateHandler)
    {
        _authorRepository = authorRepository;
        _authorCreateHandler = authorCreateHandler;
        _authorDeleteHandler = authorDeleteHandler;
        _authorUpdateHandler = authorUpdateHandler;
        _clientToSearch = new HttpClient
            { BaseAddress = new Uri($"http://{hostsOptions.Value.SearchApi}/search") };
    }

    [HttpGet("get")]
    public IActionResult GetAll()
    {
        var authors = _authorRepository.GetAll().AsEnumerable().Select(a => new AuthorFull(a));
        return new JsonResult(authors);
    }

    [HttpGet("get/{id:guid}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var author = await _authorRepository.GetByIdAsync(id.ToString());
        return new JsonResult(author is null ? null : new AuthorFull(author));
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add([FromBody] AuthorCreationData creationData)
    {
        return new JsonResult(await _authorCreateHandler.CreateAsync(creationData));
    }

    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> DeleteAsync(Guid id)
    {
        return new JsonResult(await _authorDeleteHandler.DeleteAsync(id.ToString()));
    }

    [HttpPut("update/{id:guid}")]
    public async Task<IActionResult> UpdateAsync(Guid id, AuthorUpdateData authorUpdateData)
    {
        return new JsonResult(await _authorUpdateHandler.UpdateAsync(id.ToString(), authorUpdateData));
    }

    [HttpGet("search")]
    public async Task<IActionResult> FindAuthorByUserName([FromQuery] string? query)
    {
        var authors = await _clientToSearch.GetFromJsonAsync<IEnumerable<Author>>(
            $"authors/by/user?query={query}");
        return new JsonResult(authors?.Select(a => new AuthorFull(a)));
    }
}