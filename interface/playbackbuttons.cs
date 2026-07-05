public static class PlaybackButtons
{
    public static Gtk.Button NextButton()
    {
        Gtk.Button next_button = ButtonGenerator.GenerateButton();
        next_button.Label = "Next Song";
        next_button.OnClicked += (_, _) =>
        {
            PlaybackManager.NextSong();
        };
        return next_button;
    }
    public static Gtk.Button PrevButton()
    {
        Gtk.Button next_button = ButtonGenerator.GenerateButton();
        next_button.Label = "Previous Song";
        next_button.OnClicked += (_, _) =>
        {
            PlaybackManager.PrevSong();
        };
        return next_button;
    }
    public static Gtk.Button PausePlayButton()
    {
        Gtk.Button next_button = ButtonGenerator.GenerateButton();
        next_button.Label = "Pause / Play";
        next_button.OnClicked += (_, _) =>
        {
            PlaybackManager.TogglePlayback();
        };
        return next_button;
    }
}