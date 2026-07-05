class GlacialMusicPlayer
{
    static void Main()
    {
        Console.WriteLine("Thanks for using Glacier!");

        ManagedBassPlayback.Init();

        PlaybackManager.GetHistory().Add(new Song(
            0,
            "Abstract",
            "Dakku",
            100,
            "/home/thomas/Music/Dakku/Euphoria/Abstract.mp3"
        ));
        PlaybackManager.AddSongToQueue(new Song(
            1,
            "Sweetness",
            "Dakku",
            101,
            "/home/thomas/Music/Dakku/Euphoria/Sweetness.mp3"
        ));
        PlaybackManager.AddSongToQueue(new Song(
            2,
            "Euphoria",
            "Dakku",
            102,
            "/home/thomas/Music/Dakku/Euphoria/Euphoria.mp3"
        ));

        int excode = GtkInterface.Init();
        Console.WriteLine("UI exited with code " + excode.ToString() + ".");
    }
}