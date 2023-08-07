using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITEMPause : MonoBehaviour
{
    [SerializeField] public GameObject pos0;
    [SerializeField] public GameObject pos1;
    [SerializeField] public GameObject pos2;
    [SerializeField] public GameObject pos3;
    [SerializeField] public GameObject pos4;
    [SerializeField] public GameObject pos5;
    [SerializeField] public GameObject pos6;
    [SerializeField] public GameObject pos7;
    [SerializeField] public GameObject pos8;
    [SerializeField] public GameObject pos9;
    
    [SerializeField] public GameObject pressE;
    [SerializeField] public ITEMInventory eventsystem;
    private int colliding = 0;
    
    void Update() {
        if (colliding != 0) {
            pressE.SetActive(true);
        }
        else {
            pressE.SetActive(false);
        }
    }

    //addItem
    public void addItem(int itemVal) {
        if (itemVal == 0) {
            pos0.SetActive(true);
            eventsystem.newItem(0);
        }
        else if (itemVal == 1) {
            pos1.SetActive(true);
            eventsystem.newItem(1);
        }
        else if (itemVal == 2) {
            pos2.SetActive(true);
            eventsystem.newItem(2);
        }
        else if (itemVal == 3) {
            pos3.SetActive(true);
            eventsystem.newItem(3);
        }
        else if (itemVal == 4) {
            pos4.SetActive(true);
            eventsystem.newItem(4);
        }
        else if (itemVal == 5) {
            pos5.SetActive(true);
            eventsystem.newItem(5);
        }
        else if (itemVal == 6) {
            pos6.SetActive(true);
            eventsystem.newItem(6);
        }
        else if (itemVal == 7) {
            pos7.SetActive(true);
            eventsystem.newItem(7);
        }
        else if (itemVal == 8) {
            pos8.SetActive(true);
            eventsystem.newItem(8);
        }
        else if (itemVal == 9) {
            pos9.SetActive(true);
            eventsystem.newItem(9);
        }
    }
    
    //subtractItem
    
    public void Show() {
        colliding = 1;
    }
    
    public void Hide() {
        colliding = 0;
    }
}

