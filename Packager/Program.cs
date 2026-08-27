
using System.IO.Compression;
var path = "E:\\visual-vibrance\\Visual Vibrance.zip";

if (Path.Exists(path))
    File.Delete(path);

var f = new FileStream(path, FileMode.CreateNew);
ZipFile.CreateFromDirectory("E:\\visual-vibrance\\shaders", f, CompressionLevel.Fastest, true);
f.Dispose();

var z = await ZipFile.OpenAsync(path, ZipArchiveMode.Update);
await z.CreateEntryFromFileAsync("E:\\visual-vibrance\\LICENSE", "LICENSE");
z.Dispose();
