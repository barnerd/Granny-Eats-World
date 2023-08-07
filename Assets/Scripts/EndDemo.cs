using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDemo : MonoBehaviour
{

    [SerializeField] public Collider rightCollider;
    [SerializeField] public GameObject endScreen;
    
    private bool endDemo = false;
    
    void Update() {
        if (endDemo == true) {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space)) {
                SceneManager.LoadScene(3);
            }
        }
    }
    
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider rightCollider)
    {
        Debug.Log("END");
        endScreen.SetActive(true);
        endDemo = true;
        Time.timeScale = 0f;
    }
}
