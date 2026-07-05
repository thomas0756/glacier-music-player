public static class ButtonGenerator
{
    public static Gtk.Button GenerateButton()
    {
        Gtk.Button button = Gtk.Button.New();

        button.SetHexpand(true);

        return button;
    }
}