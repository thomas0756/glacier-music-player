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

            var box = Gtk.Box.New(Gtk.Orientation.Horizontal, 6);
            box.Append(new NextButton().Widget);

            window.Child = box;
            window.Show();
        };
        return application.RunWithSynchronizationContext(null);
    }
}