using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource[] soundSources;
    public string[] soundNames;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void PlaySound(string name)
    {
        for (int i = 0; i < soundNames.Length; i++)
        {
            if (soundNames[i] == name)
            {
                soundSources[i].Play();
                return;
            }
        }

        Debug.LogWarning("Sound not found: " + name);
    }
}
