using System.IO;
using UnityEngine;

/// <summary>
/// From https://www.youtube.com/watch?v=9UE3hLSHMTE&ab_channel=MaxO%27Didily
/// Plays a video
/// </summary>
public class VideoPlayer : MonoBehaviour
{
    [SerializeField] private string videoFileName;

    // Start is called before the first frame update
    void Start()
    {
        PlayVideo();
    }

    public void PlayVideo()
    {
        UnityEngine.Video.VideoPlayer videoPlayer = GetComponent<UnityEngine.Video.VideoPlayer>();

        if (videoPlayer)
        {
            string videoPath = Path.Combine(Application.streamingAssetsPath, videoFileName);
            Debug.Log(videoPath);
            videoPlayer.url = videoPath;
            videoPlayer.Play();
        }
    }
}
