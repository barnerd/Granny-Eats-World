using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPauseMenu : MonoBehaviour
{
    [SerializeField] GameObject bread;
    [SerializeField] GameObject foolsGold;
    [SerializeField] GameObject flour;
    [SerializeField] GameObject menu;
    
    [SerializeField] GameObject breadCauldron;
    [SerializeField] GameObject flourCauldron;
    [SerializeField] GameObject foolsGoldCauldron;

    int p = 1;
    
    bool canPause = true;
    
    void Start() {
        bread.SetActive(false);
        flour.SetActive(false);
        foolsGold.SetActive(false);
        breadCauldron.SetActive(false);
        flourCauldron.SetActive(false);
        foolsGoldCauldron.SetActive(false);
    }
    
    void Update() {
        if (canPause && Input.GetKeyDown(KeyCode.Tab)) {
            ++p;
        }
        if (p % 2 == 0) {
            menu.SetActive(true);
        }
        else {
            menu.SetActive(false);
        }
    }
    
    public void CanPause() {
        canPause = true;
    }
    
    public void CantPause() {
        canPause = false;
    }

    public void NewItem(int i) {
        if (i == 1) {
            flour.SetActive(true);
            flourCauldron.SetActive(true);
        }
        else if (i == 2) {
            bread.SetActive(true);
            breadCauldron.SetActive(true);
        }
        else if (i == 3) {
            foolsGold.SetActive(true);
            foolsGoldCauldron.SetActive(true);
        }
    }
}
