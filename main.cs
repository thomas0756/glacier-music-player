class GlacialMusicPlayer
{
    static void Main()
    {
        Console.WriteLine("Thanks for using Glacier!");

        PlaybackManager.Init();
        ManagedBassPlayback.Init();

        int excode = GtkInterface.Init();
        Console.WriteLine("UI exited with code " + excode.ToString() + ".");
    }
}