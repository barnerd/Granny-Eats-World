using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkWoodsBlock : MonoBehaviour
{
    [SerializeField] public Collider woodsCollider;
    [SerializeField] public GameObject dontEnter;
    
    private bool popMessage = false;
    
    void Update() {
        if (popMessage == true) {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space)) {
                dontEnter.SetActive(false);
                popMessage = false;
                Time.timeScale = 1f;
            }
        }
    }
    
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider woodsCollider)
    {
        dontEnter.SetActive(true);
        popMessage = true;
        Time.timeScale = 0f;
    }

    
}
