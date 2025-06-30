using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    public string levelName;
    public int levelIndex;
    public GameObject lockIcon;
    public Button button;

    void Start()
    {
        int unlockedLevel = PlayerPrefs.GetInt("LevelUnlocked", 1);
        if (levelIndex <= unlockedLevel)
        {
            button.interactable = true;
            lockIcon.SetActive(false);
        }
        else
        {
            button.interactable = false;
            lockIcon.SetActive(true);
        }
    }

    public void LoadLevel()
    {
        if (button.interactable)
        {
            AudioManager.instance.PlaySound("click");
            SceneManager.LoadScene(levelName);
        }
    }
}
