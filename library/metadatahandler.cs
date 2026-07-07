using TagLib;

public static class MetadataHandler
{
    static readonly List<String> SupportedExtensions = [
        ".mp3",
        ".mp2",
        ".mp1",
        ".ogg",
        ".wav",
        ".mpa",
        ".m2a",
        ".m1a",
        ".mpg",
        ".mpeg",
        ".mp3pro",
        ".bwf",
    ];

    public static Song? CreateSongFromFile(String path)
    {
        if (System.IO.File.Exists(path))
        {
            if (SupportedExtensions.Contains(Path.GetExtension(path)))
            {
                TagLib.File song_file = TagLib.File.Create(path);
                return new Song(
                    0, //Figure out an ID system once there's a database
                    song_file.Tag.Title,
                    song_file.Tag.FirstPerformer,
                    song_file.Properties.Duration.TotalSeconds,
                    path
                );
            }
            else
            {
                Console.WriteLine("Unsupported file format in '" + path + "'");
                return null;
            }
        }
        else
        {
            Console.WriteLine("File '" + path + "' does not exist.");
            return null;
        }
    }
}