public static class PlaybackManager
{
    static LinkedList<Song> queue = new();
    static List<Song> history = new();

    public static Song? GetCurrentSong()
    {
        return queue.FirstOrDefault();
    }
    public static void NextSong()
    {
        Song? prev_song = GetCurrentSong();
        if (prev_song != null)
        {
            queue.RemoveFirst();
            history.Add(prev_song);
        }
        else
        {
            Console.WriteLine("Nothing in queue");
        }
    }
    public static void AddSongToQueue(Song song)
    {
        queue.AddLast(song);
    }
    public static void PrevSong()
    {
        Song? new_song = history.LastOrDefault();
        if (new_song != null)
        {
            history.RemoveAt(history.Count - 1);
            queue.AddFirst(new_song);
        }
        else
        {
            Console.WriteLine("Cannot play previous song, history is empty.");
        }
    }
}