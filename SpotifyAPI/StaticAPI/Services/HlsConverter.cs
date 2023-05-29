using System.Diagnostics;

namespace StaticAPI.Services;

public class HlsConverter : IHlsConverter
{
    private const string FfmpegPath = @"C:\ProgramData\chocolatey\bin\ffmpeg.exe";
    
    public async Task SaveHlsFromMp3Async(string sourceFile, string outputDirectory)
    {
        var fileName = Path.Combine(outputDirectory, Path.GetFileNameWithoutExtension(sourceFile));
        var ffmpegArgs =
            $"-i {sourceFile} -hls_time 10 -hls_playlist_type vod -hls_segment_filename {fileName}.%05d.ts {fileName}.index.m3u8";
        var ffmpegProcess = new Process();
        ffmpegProcess.StartInfo.FileName = FfmpegPath;
        ffmpegProcess.StartInfo.Arguments = ffmpegArgs;
        ffmpegProcess.Start();

        await ffmpegProcess.WaitForExitAsync();
    }
}