using ManagedBass;

public static class ManagedBassPlayback
{

    public static int stream;

    public static void Init()
    {
        if (!Bass.Init(-1, 44100, DeviceInitFlags.Default))
            throw new Exception(Bass.LastError.ToString());
    }

    public static void PlayFile(String path)
    {
        Console.WriteLine("Playing " + path);
        stream = Bass.CreateStream(path, 0, (long)BassFlags.Default);
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
}