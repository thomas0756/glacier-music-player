using TagLib;

public static class MetadataHandler
{
    public static Song? CreateSongFromFile(String path)
    {
        if (System.IO.File.Exists(path))
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
            return null;
        }
    }
}