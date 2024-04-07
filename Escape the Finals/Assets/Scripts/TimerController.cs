using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    public float timerDuration = 31f; // Duration of the timer in seconds

    private float timer; // Current timer value

    void Start()
    {
        timer = timerDuration;
    }

    void Update()
    {
        // Decrement the timer each frame
        timer -= Time.deltaTime;

        // Check if the timer has reached zero or less
        if (timer <= 0)
        {
            // Load the scene named "MainMenu"
            SceneManager.LoadScene("MainMenu");
        }
    }
}
