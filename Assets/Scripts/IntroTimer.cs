using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroTimer : MonoBehaviour
{
    public int scene;
    public float timer = 212f;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
