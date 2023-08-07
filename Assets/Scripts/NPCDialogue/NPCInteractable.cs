using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
/*
public class NPCInteractable : MonoBehaviour
{
    [SerializeField] private GameObject pressE;
    [SerializeField] private PlayerInteract playerInteract;
    [SerializeField] public NPCDialog npc;
    
    public int talking = 1;
   
   private void Update() {
        if (playerInteract.GetInteractableObject() != null) {
            pressE.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E)) {
                talking += 1;
                if (talking % 2 == 0) {
                    Debug.Log("EVEN");
                    Hide();
                    npc.Pause();
                }
                else {
                    Debug.Log("ODD");
                }
            }
        }
        else {
            pressE.SetActive(false);
         //   NPCDialog.Pause();
        }
    }
    
    public void Show() {
      // Debug.Log("Interact!");
        pressE.SetActive(true);
    }
    
    public void Hide() {
        pressE.SetActive(false);
    }
    
}
*/