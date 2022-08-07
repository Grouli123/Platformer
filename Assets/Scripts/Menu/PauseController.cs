using UnityEngine;

public class PauseController : MonoBehaviour
{
    [SerializeField] private AudioSource _backgroundSound;
    private bool paused;
    public void PauseGame()
    {
        if (paused)
        {
            Time.timeScale = 1;
            _backgroundSound.Play();
        }
        else
        {
            Time.timeScale = 0f;
            _backgroundSound.Pause();
        }
        paused = !paused;
    }
}
