using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ITEMInteractable : MonoBehaviour
{
    [SerializeField] public GameObject item;
    [SerializeField] public Collider collider;
    [SerializeField] private ITEMPause itemList;
    
    [SerializeField] public int itemNum;
    private float interactRange = 4f;
    private bool colliding = false;
    
    
    void Update() {
        if (colliding == true) {
            if (Input.GetKeyDown(KeyCode.E)) {
                Destroy(item);
                
                //CALL ITEMPause addItem(numItems)
                itemList.addItem(itemNum);
                itemList.Hide();
            }
        }
    }
    
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collide");
        itemList.Show();
        colliding = true;
    }
    
    private void OnTriggerExit(Collider collider) {
        itemList.Hide();
        colliding = false;
    }
}


