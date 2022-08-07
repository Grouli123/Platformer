using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void MenuBack()
    {
        SceneManager.LoadScene(0);
    }
}
