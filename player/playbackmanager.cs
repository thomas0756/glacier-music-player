using ManagedBass;

public static class PlaybackManager
{
    static LinkedList<Song> queue = new();
    static List<Song> history = [];
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
        if (queue.First != null)
        {
            current = queue.First.Value;
            queue.RemoveFirst();
            ManagedBassPlayback.PlayFile(current.path);
        }
        else
        {
            Console.WriteLine("[NextSong] Nothing in queue to play, ending playback.");
            current = null;
        }
    }
    public static void AddSongToQueue(Song song)
    {
        queue.AddLast(song);
    }
    public static void PrevSong()
    {
        {
            if (history.Count > 0)
            {
                if (current != null)
                {
                    queue.AddFirst(current);
                }
                current = history.Last();
                history.RemoveAt(history.Count - 1);
            }
            else
            {
                Console.WriteLine("[PrevSong] History is empty, ending playback.");
                current = null;
            }
        }
    }
    public static LinkedList<Song> GetQueue()
    {
        return queue;
    }
    public static List<Song> GetHistory()
    {
        return history;
    }
    public static void TogglePlayback()
    {
        Console.WriteLine("Playback toggled");
        PlaybackState state = ManagedBassPlayback.GetPlaybackState();

        if (current == null)
        {
            NextSong();
        }
        else
        {
           if (state == PlaybackState.Stopped)
           {
                ManagedBassPlayback.PlayFile(current.path);
           }
           else
           {
                ManagedBassPlayback.TogglePlayback();
           }
        }
    }

    public static void StopPlayback()
    {
        ManagedBassPlayback.StopPlayback();
    }

    public static void PlaySong(Song song)
    {
        AddSongToQueue(song);
        NextSong();
    }
}