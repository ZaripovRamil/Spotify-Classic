namespace StaticAPI.Services;

public interface IHlsConverter
{
    public Task SaveHlsFromMp3Async(string sourcePath, string outputDirectory);
}