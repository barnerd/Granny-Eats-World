using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsTimer : MonoBehaviour
{
    public int scene;
    public float timer = 34f;

    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
