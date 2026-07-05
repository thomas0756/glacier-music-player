using System.Reflection.Emit;
using Gtk;

public static class VSongLists
{
    public static Gtk.Box PlainSongList(List<Song> songs)
    {
        Gtk.Box vlist = VListGenerator.GenerateVList();
        foreach (Song song in songs)
        {
            String song_info = song.artist + " - " + song.title;
            Gtk.Label label = Gtk.Label.New(song_info);
            label.SetXalign(0);
            vlist.Append(label);
        }
        return vlist;
    }
    public static Gtk.Box PlainSongList(LinkedList<Song> songs)
    {
        Gtk.Box vlist = VListGenerator.GenerateVList();
        foreach (Song song in songs)
        {
            String song_info = song.artist + " - " + song.title;
            Gtk.Label label = Gtk.Label.New(song_info);
            label.SetXalign(0);
            vlist.Append(label);
        }
        return vlist;
    }

    public static Gtk.Box EmptyVList()
    {
        return VListGenerator.GenerateVList();
    }
}