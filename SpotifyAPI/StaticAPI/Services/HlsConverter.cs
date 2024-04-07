using System.Diagnostics;
using StaticAPI.Services.Interfaces;

namespace StaticAPI.Services;

public class HlsConverter : IHlsConverter
{
    public async Task SaveHlsFromMp3Async(string sourcePath, string outputDirectory)
    {
        var fileName = Path.GetFileNameWithoutExtension(sourcePath);
        var fileNameWithExt = Path.GetFileName(sourcePath);
        var ffmpegArgs =
            $"-hide_banner -loglevel panic -i /source/{fileNameWithExt} -hls_time 10" +
            $" -hls_playlist_type vod -hls_segment_filename" +
            $" /result/{fileName}.%05d.ts /result/{fileName}.index.m3u8";

        var dockerArgs =
            $"run --rm -v {outputDirectory}:/result" +
            $" -v {Path.GetDirectoryName(sourcePath)}:/source" +
            $" jrottenberg/ffmpeg {ffmpegArgs}";

        var dockerProcess = new Process();
        dockerProcess.StartInfo.FileName = "docker";
        dockerProcess.StartInfo.Arguments = dockerArgs;
        dockerProcess.StartInfo.RedirectStandardOutput = false;
        dockerProcess.Start();

        await dockerProcess.WaitForExitAsync();
    }
}