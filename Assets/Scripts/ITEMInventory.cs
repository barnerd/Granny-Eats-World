using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ITEMInventory : MonoBehaviour
{
    private bool hasItem0 = false;
    private bool hasItem1 = false;
    private bool hasItem2 = false;
    private bool hasItem3 = false;
    private bool hasItem4 = false;
    private bool hasItem5 = false;
    private bool hasItem6 = false;
    private bool hasItem7 = false;
    private bool hasItem8 = false;
    private bool hasItem9 = false;
    
    [SerializeField] public GameObject woodsCollider;
    
    public void newItem(int itemVal) {
        if (itemVal == 0) {
            hasItem0 = true;
        }
        else if (itemVal == 1) {
            hasItem1 = true;
        }
        else if (itemVal == 2) {
            hasItem2 = true;
        }
        else if (itemVal == 3) {
            hasItem3 = true;
        }
        else if (itemVal == 4) {
            hasItem4 = true;
        }
        else if (itemVal == 5) {
            hasItem5 = true;
        }
        else if (itemVal == 6) {
            hasItem6 = true;
        }
        else if (itemVal == 7) {
            hasItem7 = true;
        }
        else if (itemVal == 8) {
            hasItem8 = true;
        }
        else if (itemVal == 9) {
            hasItem9 = true;
        }
    }
    
    public void hasLantern() {
        Destroy(woodsCollider);
    }
}
