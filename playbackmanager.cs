public static class PlaybackManager
{
    static LinkedList<Song> queue = new();
    static List<Song> history = new();
    static Song? current;

    public static Song? GetCurrentSong()
    {
        return current;
    }
    public static void NextSong()
    {
        if (current != null)
        {
            history.Add(current);
        }
        else
        {
            Console.WriteLine("[NextSong] Nothing is playing, not updating history.");
        }
        current = queue.FirstOrDefault();
        if (current != null)
        {
            queue.RemoveFirst();
        }
        else
        {
            Console.WriteLine("[NextSong] Nothing in queue to play, ending playback.");
        }
    }
    public static void AddSongToQueue(Song song)
    {
        queue.AddLast(song);
    }
    public static void PrevSong()
    {
        {
            if (history.First() != null)
            {
                current = history.First();
                history.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("[PrevSong] History is empty, ending playback.");
                current = null;
            }
        }
    }
    public static LinkedList<Song> GetQueue() {
        return queue;
    }
    public static List<Song> GetHistory() {
        return history;
    }
}