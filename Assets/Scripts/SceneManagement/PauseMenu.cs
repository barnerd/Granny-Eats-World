using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;

    public static bool GameIsPaused = false;
    private bool canPause = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && canPause)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    
    public void CantPause() {
        canPause = false;
    }
    
    public void CanPause() {
        canPause = true;
    }
}
