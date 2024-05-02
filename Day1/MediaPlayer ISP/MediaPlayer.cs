
public interface IAudioPlayer
{
    void PlayAudio();
}

public interface IVideoPlayer
{
    void PlayVideo();
    void DisplaySubtitles();
}

public interface IMediaLoader
{
    void LoadMedia(string filePath);
}

// Refactored classes
public class AudioPlayer : IAudioPlayer
{
    public void PlayAudio()
    {
        // Code to play audio
    }
}

public class VideoPlayer : IVideoPlayer, IMediaLoader
{
    public void PlayVideo()
    {
        // Code to play video
    }

    public void DisplaySubtitles()
    {
        // Code to display subtitles
    }

    public void LoadMedia(string filePath)
    {
        // Code to load video file
    }
}
