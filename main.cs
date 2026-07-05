class GlacialMusicPlayer
{
    static void Main()
    {
        Console.WriteLine("Thanks for using Glacier!");

        ManagedBassPlayback.Init();

        

        int excode = GtkInterface.Init();
        Console.WriteLine("UI exited with code " + excode.ToString() + ".");
    }
}