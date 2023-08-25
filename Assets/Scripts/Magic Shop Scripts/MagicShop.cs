using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MagicShop : MonoBehaviour
{
    public GameObject cauldronPanel;
    public Button startButton;
    public GameObject item1Panel;
    public GameObject item2Panel;
    
    public GameObject breadC1;
    public GameObject curds1;
    public GameObject hair1;
    public GameObject beans1;
    public GameObject bread1;
    public GameObject flour1;
    public GameObject rock1;
    public GameObject wheat1;
    public GameObject egg1;
    public GameObject feather1;
    public GameObject stick1;
    public GameObject lead1;
    public GameObject fGold1;
    public GameObject sulfur1;
    
    private bool hasBreadC1 = false;
    private bool hasCurds1 = false;
    private bool hasHair1 = false;
    private bool hasBeans1 = false;
    private bool hasBread1 = false;
    private bool hasFlour1 = false;
    private bool hasRock1 = false;
    private bool hasWheat1 = false;
    private bool hasEgg1 = false;
    private bool hasFeather1 = false;
    private bool hasStick1 = false;
    private bool hasLead1 = false;
    private bool hasFGold1 = false;
    private bool hasSulfur1 = false;
    
    public GameObject breadC2;
    public GameObject curds2;
    public GameObject hair2;
    public GameObject beans2;
    public GameObject bread2;
    public GameObject flour2;
    public GameObject rock2;
    public GameObject wheat2;
    public GameObject egg2;
    public GameObject feather2;
    public GameObject stick2;
    public GameObject lead2;
    public GameObject fGold2;
    public GameObject sulfur2;
    
    private bool hasBreadC2 = false;
    private bool hasCurds2 = false;
    private bool hasHair2 = false;
    private bool hasBeans2 = false;
    private bool hasBread2 = false;
    private bool hasFlour2 = false;
    private bool hasRock2 = false;
    private bool hasWheat2 = false;
    private bool hasEgg2 = false;
    private bool hasFeather2 = false;
    private bool hasStick2 = false;
    private bool hasLead2 = false;
    private bool hasFGold2 = false;
    private bool hasSulfur2 = false;
    
    private int itemNum = 1;
    private bool isReady = false;
    private bool hasItem1 = false;
    private bool hasItem2 = false;
    private bool cauldron = false;
    
  //  public PotionMinigame potion;
    private int p;
    
    //AUDIO
  //  public ShopAudio sfx;
   // public AudioClip ballSound;
    
    void Start() {
        cauldronPanel.SetActive(false);
    }
    
    void Update() {
        if (cauldron == true) {
            if (Input.GetKeyDown(KeyCode.Tab)) {
                cauldron = false;
            }
        
            if (itemNum > 2) {
                itemNum = 2;
            }
            
            if (hasItem1 == false && hasItem2 == true) {
                itemNum = 1;
            }
            
            if (hasRock1 == true && hasWheat2 == true) {
                p = 1;
                isReady = true;
                startButton.interactable = true;
            }
            else if (hasWheat1 == true && hasRock2 == true) {
                p = 1;
                isReady = true;
                startButton.interactable = true;
            }
            else if (hasLead1 == true && hasSulfur2 == true) {
                p = 2;
                isReady = true;
                startButton.interactable = true;
            }
            else if (hasSulfur1 == true && hasLead2 == true) {
                p = 2;
                isReady = true;
                startButton.interactable = true;
            }
            else {
                isReady = false;
                startButton.interactable = false;
            }
        /* else if (hasWater1 == true && hasFlour2 == true) {
                p = 3;
                isReady = true;
                startButton.interactable = true;
            }
            else if (hasFlour1 == true && hasWater2 == true) {
                p = 3;
                isReady = true;
                startButton.interactable = true;
            } */
        }
        else {
            cauldronPanel.SetActive(false);
        }
    }

    public void PickItems() {
        //Show Inventory
        //click on first object, then second object
        //play minigame button is only clickable until both items are selected and able to make a potion
        cauldronPanel.SetActive(true);
        cauldron = true;
    }
    
    private void PlaceItem1(int place) {
        item1Panel.SetActive(true);
    
        if (place == 0) {   breadC1.SetActive(true);
                            hasBreadC1 = true; }
        else {  breadC1.SetActive(false); }
        
        if (place == 1) {   curds1.SetActive(true);
                            hasCurds1 = true; }
        else {  curds1.SetActive(false); }

        if (place == 2) {   hair1.SetActive(true);
                            hasHair1 = true; }
        else {  hair1.SetActive(false); }

        if (place == 3) {   beans1.SetActive(true);
                            hasBeans1 = true; }
        else {  beans1.SetActive(false); }
        
        if (place == 4) {   bread1.SetActive(true);
                            hasBread1 = true; }
        else {  bread1.SetActive(false); }
        
        if (place == 5) {   flour1.SetActive(true);
                            hasFlour1 = true; }
        else {  flour1.SetActive(false); }
        
        if (place == 6) {   rock1.SetActive(true);
                            hasRock1 = true; }
        else {  rock1.SetActive(false); }
        
        if (place == 7) {   wheat1.SetActive(true);
                            hasWheat1 = true; }
        else {  wheat1.SetActive(false); }

        if (place == 8) {   egg1.SetActive(true);
                            hasEgg1 = true; }
        else {  egg1.SetActive(false); }

        if (place == 9) {   feather1.SetActive(true);
                            hasFeather1 = true; }
        else {  feather1.SetActive(false); }
        
        if (place == 10) {  stick1.SetActive(true);
                            hasStick1 = true; }
        else {  stick1.SetActive(false); }
        
        if (place == 11) {  lead1.SetActive(true);
                            hasLead1 = true; }
        else {  lead1.SetActive(false); }
        
        if (place == 12) {  fGold1.SetActive(true);
                            hasFGold1 = true; }
        else {  fGold1.SetActive(false); }
        
        if (place == 13) {   sulfur1.SetActive(true);
                             hasSulfur1 = true; }
        else {  sulfur1.SetActive(false); }

        ++itemNum;
        hasItem1 = true;
    }
    
    private void PlaceItem2(int place) {
        item2Panel.SetActive(true);
    
        if (place == 0) {   breadC2.SetActive(true);
                            hasBreadC2 = true; }
        else {  breadC2.SetActive(false); }
        
        if (place == 1) {   curds2.SetActive(true);
                            hasCurds2 = true; }
        else {  curds2.SetActive(false); }

        if (place == 2) {   hair2.SetActive(true);
                            hasHair2 = true;}
        else {  hair2.SetActive(false); }

        if (place == 3) {   beans2.SetActive(true);
                            hasBeans2 = true; }
        else {  beans2.SetActive(false); }
        
        if (place == 4) {   bread2.SetActive(true);
                            hasBread2 = true; }
        else {  bread2.SetActive(false); }
        
        if (place == 5) {   flour2.SetActive(true);
                            hasFlour2 = true; }
        else {  flour2.SetActive(false); }
        
        if (place == 6) {   rock2.SetActive(true);
                            hasRock2 = true; }
        else {  rock2.SetActive(false); }
        
        if (place == 7) {   wheat2.SetActive(true);
                            hasWheat2 = true; }
        else {  wheat2.SetActive(false); }

        if (place == 8) {   egg2.SetActive(true);
                            hasEgg2 = true; }
        else {  egg2.SetActive(false); }

        if (place == 9) {   feather2.SetActive(true);
                            hasFeather2 = true; }
        else {  feather2.SetActive(false); }
        
        if (place == 10) {  stick2.SetActive(true);
                            hasStick2 = true; }
        else {  stick2.SetActive(false); }
        
        if (place == 11) {  lead2.SetActive(true);
                            hasLead2 = true; }
        else {  lead2.SetActive(false); }
        
        if (place == 12) {  fGold2.SetActive(true);
                            hasFGold2 = true; }
        else {  fGold2.SetActive(false); }
        
        if (place == 13) {   sulfur2.SetActive(true);
                            hasSulfur2 = true; }
        else {  sulfur2.SetActive(false); }

        ++itemNum;
        hasItem2 = true;
    }
    
    public void SelectBreadCrumbs() {
        if (itemNum == 1 && hasBreadC1 == false && hasBreadC2 == false) {
            PlaceItem1(0);
        }
        else if (itemNum == 2 && hasBreadC1 == false && hasBreadC2 == false) {
            PlaceItem2(0);
        }
    }
    
    public void SelectCurds() {
        if (itemNum == 1 && hasCurds1 == false && hasCurds2 == false) {
            PlaceItem1(1);
        }
        else if (itemNum == 2 && hasCurds1 == false && hasCurds2 == false) {
            PlaceItem2(1);
        }
    }
    
    public void SelectHair() {
        if (itemNum == 1 && hasHair1 == false && hasHair2 == false) {
            PlaceItem1(2);
        }
        else if (itemNum == 2 && hasHair1 == false && hasHair2 == false) {
            PlaceItem2(2);
        }
    }
    
    public void SelectBeans() {
        if (itemNum == 1 && hasBeans1 == false && hasBeans2 == false) {
            PlaceItem1(3);
        }
        else if (itemNum == 2 && hasBeans1 == false && hasBeans2 == false) {
            PlaceItem2(3);
        }
    }
    
    public void SelectBread() {
        if (itemNum == 1 && hasBread1 == false && hasBread2 == false) {
            PlaceItem1(4);
        }
        else if (itemNum == 2 && hasBread1 == false && hasBread2 == false) {
            PlaceItem2(4);
        }
    }
    
    public void SelectFlour() {
        if (itemNum == 1 && hasFlour1 == false && hasFlour2 == false) {
            PlaceItem1(5);
        }
        else if (itemNum == 2 && hasFlour1 == false && hasFlour2 == false) {
            PlaceItem2(5);
        }
    }
    
    public void SelectRock() {
        if (itemNum == 1 && hasRock1 == false && hasRock2 == false) {
            PlaceItem1(6);
        }
        else if (itemNum == 2 && hasRock1 == false && hasRock2 == false) {
            PlaceItem2(6);
        }
    }
    
    public void SelectWheat() {
        if (itemNum == 1 && hasWheat1 == false && hasWheat2 == false) {
            PlaceItem1(7);
        }
        else if (itemNum == 2 && hasWheat1 == false && hasWheat2 == false) {
            PlaceItem2(7);
        }
    }
    
    public void SelectEgg() {
        if (itemNum == 1 && hasEgg1 == false && hasEgg2 == false) {
            PlaceItem1(8);
        }
        else if (itemNum == 2 && hasEgg1 == false && hasEgg2 == false) {
            PlaceItem2(8);
        }
    }
    
    public void SelectFeather() {
        if (itemNum == 1 && hasFeather1 == false && hasFeather2 == false) {
            PlaceItem1(9);
        }
        else if (itemNum == 2 && hasFeather1 == false && hasFeather2 == false) {
            PlaceItem2(9);
        }
    }
    
    public void SelectStick() {
        if (itemNum == 1 && hasStick1 == false && hasStick2 == false) {
            PlaceItem1(10);
        }
        else if (itemNum == 2 && hasStick1 == false && hasStick2 == false) {
            PlaceItem2(10);
        }
    }
    
    public void SelectLead() {
        if (itemNum == 1 && hasLead1 == false && hasLead2 == false) {
            PlaceItem1(11);
        }
        else if (itemNum == 2 && hasLead1 == false && hasLead2 == false) {
            PlaceItem2(11);
        }
    }
    
    public void SelectFGold() {
        if (itemNum == 1 && hasFGold1 == false && hasFGold2 == false) {
            PlaceItem1(12);
        }
        else if (itemNum == 2 && hasFGold1 == false && hasFGold2 == false) {
            PlaceItem2(12);
        }
    }
    
    public void SelectSulfur() {
        if (itemNum == 1 && hasSulfur1 == false && hasSulfur2 == false) {
            PlaceItem1(13);
        }
        else if (itemNum == 2 && hasSulfur1 == false && hasSulfur2 == false) {
            PlaceItem2(13);
        }
    }
    
    public void DeselectItem1() {
        breadC1.SetActive(false);
        curds1.SetActive(false);
        hair1.SetActive(false);
        beans1.SetActive(false);
        bread1.SetActive(false);
        flour1.SetActive(false);
        rock1.SetActive(false);
        wheat1.SetActive(false);
        egg1.SetActive(false);
        feather1.SetActive(false);
        stick1.SetActive(false);
        lead1.SetActive(false);
        fGold1.SetActive(false);
        sulfur1.SetActive(false);
        hasItem1 = false;
        hasBreadC1 = false;
        hasCurds1 = false;
        hasHair1 = false;
        hasBeans1 = false;
        hasBread1 = false;
        hasFlour1 = false;
        hasRock1 = false;
        hasWheat1 = false;
        hasEgg1 = false;
        hasFeather1 = false;
        hasStick1 = false;
        hasLead1 = false;
        hasFGold1 = false;
        hasSulfur1 = false;
        itemNum = 1;
    }
    
    public void DeselectItem2() {
        breadC2.SetActive(false);
        curds2.SetActive(false);
        hair2.SetActive(false);
        beans2.SetActive(false);
        bread2.SetActive(false);
        flour2.SetActive(false);
        rock2.SetActive(false);
        wheat2.SetActive(false);
        egg2.SetActive(false);
        feather2.SetActive(false);
        stick2.SetActive(false);
        lead2.SetActive(false);
        fGold2.SetActive(false);
        sulfur2.SetActive(false);
        hasItem2 = false;
        hasBreadC2 = false;
        hasCurds2 = false;
        hasHair2 = false;
        hasBeans2 = false;
        hasBread2 = false;
        hasFlour2 = false;
        hasRock2 = false;
        hasWheat2 = false;
        hasEgg2 = false;
        hasFeather2 = false;
        hasStick2 = false;
        hasLead2 = false;
        hasFGold2 = false;
        hasSulfur2 = false;
        itemNum = 2;
    }
    
    public void StartCauldron() {
        if (isReady == true) {
           // potion.SetPotion(p);
           // SceneManager.LoadScene("PotionMakerMiniGame");
           Debug.Log("START MINIGAME");
        }
        else {
            //DISPLAY error message
        }
    }

}
