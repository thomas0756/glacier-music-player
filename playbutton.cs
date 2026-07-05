public class NextButton
{
    public Gtk.Button Widget { get; }

    public NextButton()
    {
        Widget = Gtk.Button.New();
        Widget.Label = "Next Song";

        Widget.SetMarginStart(10);
        Widget.SetMarginEnd(10);
        Widget.SetMarginTop(10);
        Widget.SetMarginBottom(10);

        Widget.SetHexpand(true);

        Widget.OnClicked += (_, _) =>
        {
            PlaybackManager.NextSong();
        };
    }
}