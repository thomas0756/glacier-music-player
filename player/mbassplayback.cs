using ManagedBass;

public static class ManagedBassPlayback {
    public static void Init(String path) {
        if (!Bass.Init(-1, 44100, DeviceInitFlags.Default))
        {
            Console.WriteLine(Bass.LastError);
            return;
        }
        int stream = Bass.CreateStream(path, 0, (long)BassFlags.Default);
        Bass.ChannelPlay(stream);
        Bass.Free();
    }
}