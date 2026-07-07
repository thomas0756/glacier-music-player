using ManagedBass;

public static class ManagedBassPlayback
{

    static int stream;
    static readonly SyncProcedure endSync = OnSongFinished;

    public static void Init()
    {
        if (!Bass.Init(-1, 44100, DeviceInitFlags.Default))
            throw new Exception(Bass.LastError.ToString());
    }

    public static void PlayFile(String path)
    {
        Console.WriteLine("Playing " + path);
        stream = Bass.CreateStream(path, 0, (long)BassFlags.Default);
        Bass.ChannelSetSync(stream, SyncFlags.End, 0, endSync);
        Bass.ChannelPlay(stream);
        //Bass.Free();
    }

    public static void TogglePlayback()
    {
        var state = GetPlaybackState();
        Console.WriteLine(state);

        if (state == PlaybackState.Playing)
        {
            Bass.ChannelPause(stream);
        }
        else
        {
            Bass.ChannelPlay(stream);
        }
    }

    public static void StopPlayback()
    {
        Bass.ChannelStop(stream);
    }

    public static PlaybackState GetPlaybackState()
    {
        return Bass.ChannelIsActive(stream);
    }

    static void OnSongFinished(int handle, int channel, int data, IntPtr user)
    {
        SongFinished?.Invoke();
    }

    public static event Action? SongFinished;
}