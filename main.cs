using GLib;

class GlacialMusicPlayer
{
    static void Main()
    {
        Console.WriteLine("Thanks for using Glacier!");
        int excode = GtkInterface.Init();
        Console.WriteLine("UI exited with code " + excode.ToString() + ".");
    }
}