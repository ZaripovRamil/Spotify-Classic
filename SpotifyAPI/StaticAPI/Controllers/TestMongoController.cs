using DatabaseServices.Repositories;
using Microsoft.AspNetCore.Mvc;
using Models.Metadata;

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
    public Task<IActionResult> Get()
    {
        var metadata =  _imageMetadataRepository.GetAllAsync();
        return Task.FromResult<IActionResult>(Ok(metadata));
    }
    
    
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> Get(string id)
    {
        var metadata = await _imageMetadataRepository.GetByIdAsync(id);
        if (metadata == null)
        {
            return NotFound();
        }
 
        return Ok(metadata);
    }
 
    [HttpPost]
    public async Task<IActionResult> Post(ImageMetadata newPeople)
    {
        newPeople.FileId = new Guid().ToString();
        await _imageMetadataRepository.AddAsync(newPeople);
        return CreatedAtAction(nameof(Get), new { id = newPeople.FileId }, newPeople);
    }
    
    [HttpPut]
    public async Task<IActionResult> Put(ImageMetadata updatePeople)
    {
        var metadata = await _imageMetadataRepository.GetByIdAsync(updatePeople.FileId);
        if (metadata == null)
        {
            return NotFound();
        }
 
        await _imageMetadataRepository.UpdateAsync(updatePeople);
        return NoContent();
    }
    
    [HttpDelete]
    public async Task<IActionResult> Delete(string id)
    {
        var metadata = await _imageMetadataRepository.GetByIdAsync(id);
        if (metadata == null)
        {
            return NotFound();
        }
 
        await _imageMetadataRepository.DeleteAsync(metadata);
        return NoContent();
    }
}