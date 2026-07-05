public static class PlaybackButtons
{
    public static Gtk.Button NextButton()
    {
        Gtk.Button button = ButtonGenerator.GenerateButton();
        button.Label = "Next Song";
        button.OnClicked += (_, _) =>
        {
            PlaybackManager.NextSong();
        };
        return button;
    }
    public static Gtk.Button PrevButton()
    {
        Gtk.Button button = ButtonGenerator.GenerateButton();
        button.Label = "Previous Song";
        button.OnClicked += (_, _) =>
        {
            PlaybackManager.PrevSong();
        };
        return button;
    }
    public static Gtk.Button PausePlayButton()
    {
        Gtk.Button button = ButtonGenerator.GenerateButton();
        button.Label = "Pause / Play";
        button.OnClicked += (_, _) =>
        {
            PlaybackManager.TogglePlayback();
        };
        return button;
    }

    public static Gtk.Button StopButton()
    {
        Gtk.Button button = ButtonGenerator.GenerateButton();
        button.Label = "Stop";
        button.OnClicked += (_, _) =>
        {
            PlaybackManager.StopPlayback();
        };
        return button;
    }
}