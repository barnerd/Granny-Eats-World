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
    public SpriteRenderer a;
    public SpriteRenderer b;
    public SpriteRenderer c;
    public GameObject aa;
    public GameObject bb;
    public GameObject cc;
    public Animator animA;
    public Animator animB;
    public Animator animC;
    public GameObject pressStart;
    public GameObject winScreen;
    public GameObject loseScreen;
    public GameObject spaceCont;
    private int randNum1;
    private int randNum2;
    private int randNum3;
    private int correctAns = -1;
    private bool hasStarted = false;
    private int potionNum;
    private bool enterMinigame = false;
    
    //TIMER
    private float timeRemaining = 22;
    private bool timerIsRunning = false;
    public Text timeText;
    public GameObject timerObject;
    
    //BUBBLES
    public GameObject bubbles1;
    public GameObject bubbles5;
    public GameObject bubbles7;
    public GameObject bubbles10;
    public GameObject bubbles14;
    public GameObject bubbles17;
    public GameObject bubbles23;
    public GameObject bubbles23a;
    
    //AUDIO
    public AudioManager sfx;
    public AudioClip cauldron;
    public AudioClip correctLetter;
    public AudioClip wrongLetter;
    public AudioClip fail;
    public AudioClip win;
    public AudioClip music;
    
    //POTIONS
    public GameObject flour;
    public GameObject foolsGold;
    public GameObject bread;
    
    //CAMERAS
    public GameObject mainCamera;
    public GameObject minigameCamera;
    
    void Update() {
        if (enterMinigame) {
            if (hasStarted == false) {
                if (Input.GetKeyUp(KeyCode.Space) && correctAns == -1) {
                    pressStart.SetActive(false);
                    timerObject.SetActive(true);
                    sfx.PlayMusic(music);
                    timerIsRunning = true;
                    aa.SetActive(true);
                    bb.SetActive(true);
                    cc.SetActive(true);
                    ResetLetters();
                    hasStarted = true;
                    correctAns = 0;
                }
            }
        
            if (hasStarted == true) {
            //WIN GAME
                if (timerIsRunning == true && correctAns >= 25) {
                    //WHAT POTION WAS MADE
                    if (potionNum == 1) {
                        flour.SetActive(true);
                        foolsGold.SetActive(false);
                        bread.SetActive(false);
                        pauseMenu.NewItem(1);
                    }
                    else if (potionNum == 2) {
                        flour.SetActive(false);
                        foolsGold.SetActive(true);
                        bread.SetActive(false);
                        pauseMenu.NewItem(3);
                    }
                    else if (potionNum == 3) {
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
                else if (timerIsRunning == false && correctAns < 25) {
                    Debug.Log("YOU LOSE!");
                    loseScreen.SetActive(true);
                    sfx.PlaySFX(fail);
                    EndGame();
                }
                
            //BUBBLE CONTROLS
                if (correctAns > 0) {
                    bubbles1.SetActive(true);
                    
                    if (correctAns > 4) {
                        bubbles5.SetActive(true);
                        
                        if (correctAns > 6) {
                            bubbles7.SetActive(true);
                            
                            if (correctAns > 9) {
                                bubbles10.SetActive(true);
                                
                                if (correctAns > 13) {
                                    bubbles14.SetActive(true);
                                    
                                    if (correctAns > 16) {
                                        bubbles17.SetActive(true);
                                        
                                        if (correctAns > 22) {
                                            bubbles23.SetActive(true);
                                            bubbles23a.SetActive(true);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            
            //INPUT CONTROLS
                if (Input.anyKeyDown) {
                    letterPos += 1;
                
                    if (Input.GetKeyDown(KeyCode.A)) {
                        ClickButton(letterPos, 0);
                    }
                    else if (Input.GetKeyDown(KeyCode.W)) {
                        ClickButton(letterPos, 1);
                    }
                    else if (Input.GetKeyDown(KeyCode.S)) {
                        ClickButton(letterPos, 2);
                    }
                    else if (Input.GetKeyDown(KeyCode.D)) {
                        ClickButton(letterPos, 3);
                    }
                    else if (Input.GetKeyDown(KeyCode.E)) {
                        ClickButton(letterPos, 4);
                    }
                    else {
                        ClickButton(letterPos, 100);
                    }
                }
                if (letterPos >= 3) {
                    spaceCont.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Space)) {
                        spaceCont.SetActive(false);
                        ResetLetters();
                    }
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
    
    private void EndGame() {
        hasStarted = false;
        timerIsRunning = false;
        aa.SetActive(false);
        bb.SetActive(false);
        cc.SetActive(false);
        timerObject.SetActive(false);
    }
    
    public void RestartGame() {
        //RESTART GAME
        mainCamera.SetActive(false);
        minigameCamera.SetActive(true);
        pressStart.SetActive(true);
        timerObject.SetActive(false);
        aa.SetActive(false);
        bb.SetActive(false);
        cc.SetActive(false);
        bubbles1.SetActive(false);
        bubbles5.SetActive(false);
        bubbles7.SetActive(false);
        bubbles10.SetActive(false);
        bubbles14.SetActive(false);
        bubbles17.SetActive(false);
        bubbles23.SetActive(false);
        bubbles23a.SetActive(false);
        winScreen.SetActive(false);
        loseScreen.SetActive(false);
        timeRemaining = 22;
        enterMinigame = true;
        correctAns = -1;
    }
    
    public void BackToShop() {
        //RETURN TO SHOP
        magicShop.EnterShop();
        sfx.PauseBubbling();
        enterMinigame = false;
        mainCamera.SetActive(true);
        minigameCamera.SetActive(false);
        enterMinigame = false;
    }
    
    public void EnterMinigame(int p) {
        potionNum = p;
        RestartGame();
    }
    
    private void ResetLetters() {
        a.color = Color.white;
        b.color = Color.white;
        c.color = Color.white;
        letterPos = 0;
        
        randNum1 = Random.Range(0, 5);
        SetUp1(randNum1);
        
        randNum2 = Random.Range(0, 5);
        SetUp2(randNum2);
        
        randNum3 = Random.Range(0, 5);
        SetUp3(randNum3);
    }
    
    private void SetUp1(int randNum) {
        animA.SetInteger("Letter", randNum);
    }
    
    private void SetUp2(int randNum) {
        animB.SetInteger("Letter", randNum);
    }
    
    private void SetUp3(int randNum) {
        animC.SetInteger("Letter", randNum);
    }
    
    private void ClickButton(int letterPos, int LETTER) {
    
        if (letterPos == 1) {
            if (randNum1 == LETTER) {
                a.color = Color.green;
                //cauldron.SetTrigger("Correct");
                //ADD HAPPY EFFECT
                correctAns += 1;
                //CORRECT sound
                //Play the audio you attach to the AudioSource component
                sfx.PlaySFX(correctLetter);
            }
            else {
                a.color = Color.red;
                //WRONG sound
                //cauldron.SetTrigger("Incorrect");
                //FAILURE EFFECT
                //Play the audio you attach to the AudioSource component
                sfx.PlaySFX(wrongLetter);
            }
        }
        if (letterPos == 2) {
            if (randNum2 == LETTER) {
                b.color = Color.green;
                //CORRECT sound
                //Play the audio you attach to the AudioSource component
                sfx.PlaySFX(correctLetter);
                //cauldron.SetTrigger("Correct");
                //ADD HAPPY EFFECT
                correctAns += 1;
            }
            else {
                b.color = Color.red;
                //WRONG sound
                //cauldron.SetTrigger("Incorrect");
                //FAILURE EFFECT
                //Play the audio you attach to the AudioSource component
                sfx.PlaySFX(wrongLetter);
            }
        }
        if (letterPos == 3) {
            if (randNum3 == LETTER) {
                c.color = Color.green;
                //CORRECT sound
                //cauldron.SetTrigger("Correct");
                //ADD HAPPY EFFECT
                correctAns += 1;
                //Play the audio you attach to the AudioSource component
                sfx.PlaySFX(correctLetter);
            }
            else {
                c.color = Color.red;
                //WRONG sound
                //cauldron.SetTrigger("Incorrect");
                //FAILURE EFFECT
                //Play the audio you attach to the AudioSource component
                sfx.PlaySFX(wrongLetter);
            }
        }
    }
    
    private void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        //float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
       // timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        timeText.text = string.Format("{00}", seconds);
    }
  }
