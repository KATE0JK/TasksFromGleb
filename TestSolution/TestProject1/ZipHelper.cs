using System.IO.Compression;

namespace TestProject1;

public static class ZipHelper
{
    public static void Unzip(string zipPath, string extractPath)
    {
        ZipFile.ExtractToDirectory(zipPath, extractPath);
    }
}