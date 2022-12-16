using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameButton : MonoBehaviour
{
    public void ChangeScene()
    {
        SceneManager.LoadScene("MainMenu");
    }
}