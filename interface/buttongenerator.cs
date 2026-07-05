public static class ButtonGenerator
{
    public static Gtk.Button GenerateButton()
    {
        Gtk.Button button = Gtk.Button.New();

        button.SetMarginStart(10);
        button.SetMarginEnd(10);
        button.SetMarginTop(10);
        button.SetMarginBottom(10);

        button.SetHexpand(true);

        return button;
    }
}