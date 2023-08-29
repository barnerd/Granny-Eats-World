using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PotionMinigame : MonoBehaviour
{
    private int letterPos = 0;
    public MagicShop magicShop;
    public NewPauseMenu pauseMenu;
    public GameObject[] letters;
    public GameObject pressStart;
    public GameObject winScreen;
    public GameObject loseScreen;
    public GameObject spaceCont;
    private int[] randLetters;
    private int correctLetters = 0;
    private int correctAnswers = -1;
    [SerializeField] private int requiredAnswersForWin;
    private bool hasStarted = false;
    private int potionNum;
    private bool enterMinigame = false;

    [Header("TIMER & SCORE")]
    public GameObject timerObject;
    public GameObject scoreObject;
    private float timeRemaining = 22;
    private bool timerIsRunning = false;

    [Header("BUBBLES")]
    public GameObject[] bubbles;

    [Header("AUDIO")]
    public AudioManager sfx;
    public AudioClip cauldron;
    public AudioClip correctLetter;
    public AudioClip wrongLetter;
    public AudioClip fail;
    public AudioClip win;
    public AudioClip music;

    [Header("POTIONS")]
    public GameObject flour;
    public GameObject foolsGold;
    public GameObject bread;

    [Header("CAMERAS")]
    public GameObject mainCamera;
    public GameObject minigameCamera;

    void Start()
    {
        randLetters = new int[3];
    }

    void Update()
    {
        if (enterMinigame)
        {
            if (hasStarted == false && Input.GetKeyUp(KeyCode.Space))
            {
                pressStart.SetActive(false);
                timerObject.SetActive(true);
                scoreObject.SetActive(true);
                sfx.PlayMusic(music);
                timerIsRunning = true;

                hasStarted = true;
                correctAnswers = 0;
                foreach (var key in letters)
                {
                    key.SetActive(true);
                }
                ResetLetters();
            }

            if (hasStarted == true)
            {
                //WIN GAME
                if (timerIsRunning == true && correctAnswers >= requiredAnswersForWin)
                {
                    //WHAT POTION WAS MADE
                    if (potionNum == 1)
                    {
                        flour.SetActive(true);
                        foolsGold.SetActive(false);
                        bread.SetActive(false);
                        pauseMenu.NewItem(1);
                    }
                    else if (potionNum == 2)
                    {
                        flour.SetActive(false);
                        foolsGold.SetActive(true);
                        bread.SetActive(false);
                        pauseMenu.NewItem(3);
                    }
                    else if (potionNum == 3)
                    {
                        flour.SetActive(false);
                        foolsGold.SetActive(false);
                        bread.SetActive(true);
                        pauseMenu.NewItem(2);
                    }

                    Debug.Log("YOU WIN!");
                    winScreen.SetActive(true);
                    //PAUSE Music
                    sfx.PauseMusic();
                    sfx.PlaySFX(win);
                    EndGame();
                }
                else if (timerIsRunning == false && correctAnswers < requiredAnswersForWin)
                {
                    Debug.Log("YOU LOSE!");
                    loseScreen.SetActive(true);
                    sfx.PlaySFX(fail);
                    EndGame();
                }

                //INPUT CONTROLS
                if (Input.anyKeyDown)
                {
                    if (Input.GetKeyDown(KeyCode.A))
                    {
                        ClickButton(letterPos, 0);
                    }
                    else if (Input.GetKeyDown(KeyCode.W))
                    {
                        ClickButton(letterPos, 1);
                    }
                    else if (Input.GetKeyDown(KeyCode.S))
                    {
                        ClickButton(letterPos, 2);
                    }
                    else if (Input.GetKeyDown(KeyCode.D))
                    {
                        ClickButton(letterPos, 3);
                    }
                    else if (Input.GetKeyDown(KeyCode.E))
                    {
                        ClickButton(letterPos, 4);
                    }
                    else
                    {
                        ClickButton(letterPos, 100);
                    }
                    letterPos++;
                }
                if (letterPos >= 3)
                {
                    if (correctLetters == 3)
                    {
                        correctAnswers++;
                        DisplayScore(correctAnswers);
                        if (correctAnswers < bubbles.Length)
                        {
                            bubbles[correctAnswers].SetActive(true);
                        }
                    }
                    //spaceCont.SetActive(true);
                    //if (Input.GetKeyDown(KeyCode.Space))
                    //{
                    //spaceCont.SetActive(false);
                    ResetLetters();
                    //}
                }
            }

            if (timerIsRunning)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                    DisplayTime(timeRemaining);
                }
                else
                {
                    Debug.Log("Time has run out!");
                    timeRemaining = 0;
                    timerIsRunning = false;
                }
            }
        }
    }

    private void EndGame()
    {
        hasStarted = false;
        timerIsRunning = false;

        foreach (var key in letters)
        {
            key.SetActive(false);
        }

        timerObject.SetActive(false);
        scoreObject.SetActive(false);
    }

    public void RestartGame()
    {
        //RESTART GAME
        mainCamera.SetActive(false);
        minigameCamera.SetActive(true);
        pressStart.SetActive(true);
        timerObject.SetActive(false);
        scoreObject.SetActive(false);

        foreach (var key in letters)
        {
            key.SetActive(false);
        }

        foreach (var bubble in bubbles)
        {
            bubble.SetActive(false);
        }
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
        timeRemaining = 22;
        enterMinigame = true;
        correctAnswers = -1;
    }

    public void BackToShop()
    {
        //RETURN TO SHOP
        magicShop.EnterShop();
        sfx.PauseBubbling();
        enterMinigame = false;
        mainCamera.SetActive(true);
        minigameCamera.SetActive(false);
        enterMinigame = false;
    }

    public void EnterMinigame(int p)
    {
        potionNum = p;
        RestartGame();
    }

    private void ResetLetters()
    {
        letters[0].GetComponent<SpriteRenderer>().color = Color.white;
        letters[1].GetComponent<SpriteRenderer>().color = Color.white;
        letters[2].GetComponent<SpriteRenderer>().color = Color.white;
        letterPos = 0;
        correctLetters = 0;

        for (int i = 0; i < letters.Length; i++)
        {
            randLetters[i] = Random.Range(0, 5);
            SetLetter(i, randLetters[i]);
        }
    }

    private void SetLetter(int _letter, int _randNum)
    {
        letters[_letter].GetComponent<Animator>().SetInteger("Letter", _randNum);
    }

    private void ClickButton(int _letterPos, int _letter)
    {
        if (_letterPos < letters.Length)
        {
            if (randLetters[_letterPos] == _letter)
            {
                letters[_letterPos].GetComponent<SpriteRenderer>().color = Color.green;
                //cauldron.SetTrigger("Correct");
                //ADD HAPPY EFFECT
                correctLetters++;
                //CORRECT sound
                //Play the audio you attach to the AudioSource component
                sfx.PlaySFX(correctLetter);
            }
            else
            {
                letters[_letterPos].GetComponent<SpriteRenderer>().color = Color.red;
                //WRONG sound
                //cauldron.SetTrigger("Incorrect");
                //FAILURE EFFECT
                //Play the audio you attach to the AudioSource component
                sfx.PlaySFX(wrongLetter);
            }
        }
    }

    private void DisplayScore(int _currentScore)
    {
        scoreObject.GetComponent<Text>().text = _currentScore + "/" + requiredAnswersForWin;
    }

    private void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        //float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        // timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerObject.GetComponent<Text>().text = string.Format("{00}", seconds);
    }
}
