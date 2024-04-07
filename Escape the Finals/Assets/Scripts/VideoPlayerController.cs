using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        // Assuming the VideoPlayer component is attached to the same GameObject as this script,
        // you can automatically reference it. Otherwise, assign the VideoPlayer component in the Inspector.
        if (videoPlayer == null)
            videoPlayer = GetComponent<VideoPlayer>();

        // Subscribe to the videoPlayer's event to detect when the video has reached the end.
        videoPlayer.loopPointReached += OnVideoFinished;
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        // Load the scene called "End" when the video has finished playing.
        SceneManager.LoadScene("MainMenu");
    }
}
