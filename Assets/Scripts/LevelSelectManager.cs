using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectManager : MonoBehaviour
{
    public void LoadLevel(string levelName)
    {
        AudioManager.instance.PlaySound("click");
        SceneManager.LoadScene(levelName);
    }

    public void BackToMenu()
    {
        AudioManager.instance.PlaySound("click");
        SceneManager.LoadScene("MainMenu");
    }
}
