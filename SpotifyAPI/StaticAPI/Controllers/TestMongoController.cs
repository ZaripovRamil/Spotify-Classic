using Microsoft.AspNetCore.Mvc;
using Models.Metadata;
using StaticAPI.Services;

namespace StaticAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TestMongoController: Controller
{
    private readonly IRepository<ImageMetadata> _imageMetadataRepository;
    public TestMongoController(IRepository<ImageMetadata> imageMetadataRepository)
    {
        _imageMetadataRepository = imageMetadataRepository;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var people = await _imageMetadataRepository.GetAllAsync();
        return Ok(people);
    }
    
    
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var people = await _imageMetadataRepository.GetByIdAsync(id);
        if (people == null)
        {
            return NotFound();
        }
 
        return Ok(people);
    }
 
    [HttpPost]
    public async Task<IActionResult> Post(ImageMetadata newPeople)
    {
        await _imageMetadataRepository.CreateAsync(newPeople);
        return CreatedAtAction(nameof(Get), new { id = newPeople.FileId }, newPeople);
    }
    
    [HttpPut]
    public async Task<IActionResult> Put(ImageMetadata updatePeople)
    {
        var people = await _imageMetadataRepository.GetByIdAsync(updatePeople.FileId);
        if (people == null)
        {
            return NotFound();
        }
 
        await _imageMetadataRepository.UpdateAsync(updatePeople);
        return NoContent();
    }
    
    [HttpDelete]
    public async Task<IActionResult> Delete(string id)
    {
        var people = await _imageMetadataRepository.GetByIdAsync(id);
        if (people == null)
        {
            return NotFound();
        }
 
        await _imageMetadataRepository.DeleteAsync(id);
        return NoContent();
    }
}