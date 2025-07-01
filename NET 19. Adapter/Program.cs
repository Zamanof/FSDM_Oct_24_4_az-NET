// Adapter pattern
Console.WriteLine("Hello, World!");

// Mp3, Wav, Ogg, FLAC
List<IAudioFile> musicPlaylist = new List<IAudioFile>();
musicPlaylist.Add(new Mp3());
musicPlaylist.Add(new FLAC());
musicPlaylist.Add(new Wav());
musicPlaylist.Add(new OggAudioFileAdapter());


musicPlaylist.ForEach(m => m.Play());

interface IAudioFile
{
    void Play();
}
class Mp3: IAudioFile
{
    public void Play()
    {
        Console.WriteLine("Mp3 is playing");
    }
}

class Wav : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("WAV is playing");
    }
}

class FLAC : IAudioFile
{
    public void Play()
    {
        Console.WriteLine("FLAC is playing");
    }
}

class Ogg
{
    public void PlaySomething(bool reprat)
    {
        Console.WriteLine("Other style playing method");
        Console.WriteLine("Ogg is playing");
    }
}

// Object Adapter

//class OggAudioFileAdapter : IAudioFile
//{
//    private Ogg _ogg;
//    public OggAudioFileAdapter(Ogg ogg)
//    {
//        _ogg = ogg;
//    }
//    public void Play()
//    {
//        _ogg.PlaySomething(true);
//    }
//}

// Class Adapter

class OggAudioFileAdapter : Ogg, IAudioFile
{
    public void Play()
    {
        this.PlaySomething(true);
    }
}
