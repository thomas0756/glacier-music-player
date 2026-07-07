using System.Reflection.PortableExecutable;
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

    public static List<Song>? CreateSongsFromFolder(String path)
    {
        if (Directory.Exists(path))
        {
            List<Song> list_to_return = [];

            string[] paths_in_dir = Directory.GetFiles(path);
            foreach (String song_path in paths_in_dir)
            {
                Song? song = CreateSongFromFile(song_path);
                if (song != null)
                {
                    list_to_return.Add(song);
                }
            }
            return list_to_return;
        }
        else
        {
            Console.WriteLine("Directory '" + path + "' does not exist.");
            return null;
        }
    }
}