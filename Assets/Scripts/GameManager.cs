using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //FROG PRINCE
    public GameObject frogPrince;
    public GameObject frogPrinceFirstMeet;
    public GameObject frogPrinceSecondMeet;
    public GameObject pussFirstMeet;
    public GameObject pussSecondMeet;
    public GameObject pussThirdMeet;
    public GameObject pussFourthMeet;
    public GameObject hanselFirstMeet;
    public GameObject hanselSecondMeet;
    public GameObject hanselThirdMeet;
    public GameObject hanselFourthMeet;
    public GameObject gretelFirstMeet;
    public GameObject gretelSecondMeet;
    public GameObject gretelThirdMeet;
    public GameObject gretelFourthMeet;
    public GameObject gretelFifthMeet;
    public GameObject lanternMessage;
    public GameObject darkWall;
    public GameObject endScreen;
    public GameObject endWall;

    private bool endDemo = false;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (endDemo)
        {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(3);
            }
        }
    }

    public void LanternQuest()
    {
        pussFirstMeet.SetActive(false);
        pussSecondMeet.SetActive(true);
        gretelFirstMeet.SetActive(false);
        gretelSecondMeet.SetActive(true);
    }

    public void GetLantern()
    {
        darkWall.SetActive(false);
        gretelSecondMeet.SetActive(false);
        gretelThirdMeet.SetActive(true);
        pussSecondMeet.SetActive(false);
        pussThirdMeet.SetActive(true);
        lanternMessage.SetActive(true);
    }

    public void DeleteLanternMessage()
    {
        lanternMessage.SetActive(false);
    }

    public void CookieQuest()
    {
        hanselFirstMeet.SetActive(false);
        hanselSecondMeet.SetActive(true);
        frogPrinceFirstMeet.SetActive(false);
        frogPrinceSecondMeet.SetActive(true);
        pussThirdMeet.SetActive(false);
        pussFourthMeet.SetActive(true);
        gretelThirdMeet.SetActive(false);
        gretelFourthMeet.SetActive(true);
    }

    public void FrogQuest()
    {
        frogPrince.SetActive(false);
        hanselSecondMeet.SetActive(false);
        hanselThirdMeet.SetActive(true);
        pussThirdMeet.SetActive(false);
        pussFourthMeet.SetActive(true);
    }

    public void Endgame()
    {
        endWall.SetActive(true);
        hanselThirdMeet.SetActive(false);
        hanselFourthMeet.SetActive(true);
        gretelFourthMeet.SetActive(false);
        gretelFifthMeet.SetActive(true);
    }

    public void EndDemo()
    {
        Debug.Log("END");

        endScreen.SetActive(true);
        endDemo = true;
        Time.timeScale = 0f;
    }
}
