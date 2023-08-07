using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ITEMInteractable : MonoBehaviour
{
    [SerializeField] public GameObject item;
    //[SerializeField] public Collider collider;
    [SerializeField] private ITEMPause itemList;

    [SerializeField] public int itemNum;
    //private float interactRange = 4f;
    private bool isColliding = false;


    void Update()
    {
        if (isColliding)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(item);

                //CALL ITEMPause addItem(numItems)
                itemList.AddItem(itemNum);
                itemList.Hide();
            }
        }
    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider _other)
    {
        Debug.Log("Collide");
        itemList.Show();
        isColliding = true;
    }

    private void OnTriggerExit(Collider _other)
    {
        itemList.Hide();
        isColliding = false;
    }
}


