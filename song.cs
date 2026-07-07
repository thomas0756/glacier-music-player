using System.Data.Common;
using System.Net.NetworkInformation;

public class Song(uint id, String title, String artist, double duration, String path)
{
    public uint id = id;
    public String title = title;
    public String artist = artist;
    public double duration = duration;
    public String path = path;
}