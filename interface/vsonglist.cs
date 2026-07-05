public class VSongList
{
    public Gtk.Box Widget { get; }

    IEnumerable<Song> songs;

    public VSongList(IEnumerable<Song> songs)
    {
        this.songs = songs;
        Widget = Gtk.Box.New(Gtk.Orientation.Vertical, 4);
        UpdateList();

        PlaybackManager.SongUpdated += UpdateList;
    }

    public void UpdateList()
    {
        Clear();

        foreach (Song song in songs)
        {
            String label_text = song.artist + " - " + song.title;
            Gtk.Label label = Gtk.Label.New(label_text);
            label.SetXalign(0);
            Widget.Append(label);
        }
    }

    void Clear() {
        var child = Widget.GetFirstChild();

        while (child != null)
        {
            var next = child.GetNextSibling();
            Widget.Remove(child);
            child = next;
        }
    }
}