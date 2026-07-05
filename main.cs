class GlacialMusicPlayer
{
    static void Main()
    {
        PlaybackManager.AddSongToQueue(new Song(
            0,
            "Vertigo",
            "INDX8",
            234,
            ""
        ));
        Console.WriteLine(PlaybackManager.GetCurrentSong().title);
        PlaybackManager.AddSongToQueue(new Song(
            1,
            "Abstract",
            "Dakku",
            223,
            ""
        ));
        Console.WriteLine(PlaybackManager.GetCurrentSong().title);
        PlaybackManager.NextSong();
        Console.WriteLine(PlaybackManager.GetCurrentSong().title);
        PlaybackManager.PrevSong();
        Console.WriteLine(PlaybackManager.GetCurrentSong().title);
        PlaybackManager.PrevSong();
        PlaybackManager.PrevSong();
        PlaybackManager.PrevSong();
    }
}