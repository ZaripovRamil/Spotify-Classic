using Microsoft.AspNetCore.Mvc;
using SearchAPI.Services;

namespace SearchAPI.Controllers;
[ApiController]
[Route("Search")]
public class SearchController:Controller
{
    private readonly ISearchEngine _searchEngine;

    public SearchController(ISearchEngine searchEngine)
    {
        _searchEngine = searchEngine;
    }

    [HttpGet]
    public async Task<IActionResult> Search([FromQuery]string? query)
    {
        return Ok(await _searchEngine.SearchAsync(query?? ""));
    }
}