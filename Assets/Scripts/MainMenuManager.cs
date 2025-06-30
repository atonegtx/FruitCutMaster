using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        AudioManager.instance.PlaySound("click");
        SceneManager.LoadScene("Level1");
    }

    public void OpenLevelSelect()
    {
        AudioManager.instance.PlaySound("click");
        SceneManager.LoadScene("LevelSelect");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
