namespace StaticAPI.Services.Interfaces;

public interface IHlsConverter
{
    public Task SaveHlsFromMp3Async(string sourcePath, string outputDirectory);
}