using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class NPCDialog : MonoBehaviour
{

    public GameObject npcBubble;
    public GameObject playerBubble;
    public GameObject pressE;
    public PlayerMovement player;
    [SerializeField] private GameObject choice1;
    [SerializeField] private GameObject choice2;
    [SerializeField] private GameObject choice3;
    
    public static bool GameIsPaused = false;
    private int blue = 0;

    // Update is called once per frame
    void Update() {
        if (blue < 0) {
            blue = 0;
        }
        
        if (blue > 2) {
            blue = 2;
        }
        
        if (Input.GetKeyDown(KeyCode.W)) {
            --blue;
        }
        
        if (Input.GetKeyDown(KeyCode.S)) {
            ++blue;
        }
        
        if (Input.GetKeyDown(KeyCode.E)) {
            Select(blue);
        }
    }
    
    public void Pause() {
        npcBubble.SetActive(true);
        playerBubble.SetActive(true);
     //   Time.timeScale = 0f;
        //Stop Player Movement
        Chatting();
        player.Dialog();
        GameIsPaused = true;
    }
    
    public void Resume() {
        npcBubble.SetActive(false);
        playerBubble.SetActive(false);
       // Time.timeScale = 1f;
        player.Start();
        GameIsPaused = false;
    }
    
    public void Chatting() {
        pressE.SetActive(false);
    }
    
    private void Select(int blue) {
        if (blue == 0) {
            //choice1 blue
            //choice2 white
            //choice3 white
        }
        else if (blue == 1) {
            //choice1 white
            //choice2 blue
            //choice3 white
        }
        else {
            //choice1 white
            //choice2 white
            //choice3 blue
        }
    }
    
}
*/