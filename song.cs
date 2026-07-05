using System.Data.Common;
using System.Net.NetworkInformation;

public class Song (UInt32 id, String title, String artist, UInt32 duration, String path){
    public UInt32 id = id;
    public String title = title;
    public String artist = artist;
    public UInt32 duration = duration;
    public String path = path;
}