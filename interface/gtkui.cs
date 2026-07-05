using ManagedBass;

public static class GtkInterface
{
    public static int Init()
    {
        var application = Gtk.Application.New("com.thomas0756.glacier", Gio.ApplicationFlags.FlagsNone);
        application.OnActivate += (sender, args) =>
        {
            var window = Gtk.ApplicationWindow.New((Gtk.Application)sender);
            window.Title = "Glacier Music Player";
            window.SetDefaultSize(300, 300);

            var box = Gtk.Box.New(Gtk.Orientation.Horizontal, 8);
            
            box.SetMarginStart(8);
            box.SetMarginEnd(8);
            box.SetMarginTop(8);
            box.SetMarginBottom(8);

            Gtk.Box queues_box = VSongLists.EmptyVList();
            queues_box.Append(VSongLists.PlainSongList(PlaybackManager.GetQueue()));
            queues_box.Append(VSongLists.PlainSongList(PlaybackManager.GetHistory()));

            box.Append(PlaybackButtons.NextButton());
            box.Append(PlaybackButtons.PrevButton());
            box.Append(PlaybackButtons.PausePlayButton());
            box.Append(PlaybackButtons.StopButton());

            window.Child = box;
            window.Show();
        };
        return application.RunWithSynchronizationContext(null);
    }
}