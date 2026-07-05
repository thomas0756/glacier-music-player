public static class PlaybackManager {
    static LinkedList<Song> queue = new LinkedList<Song>();
    static List<Song> history = new List<Song>();

    public static Song GetCurrentSong() {
        return queue.First();
    }
    public static void NextSong() {
        Song prev_song = GetCurrentSong();
        queue.RemoveFirst();
        history.Add(prev_song);
    }
    public static void AddSongToQueue(Song song) {
        queue.AddLast(song);
    }
    public static void PrevSong() {
        Song new_song = history.Last();
        history.RemoveAt(history.Count - 1);
        queue.AddFirst(new_song);
    }
}