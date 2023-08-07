using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenFly : MonoBehaviour
{
    [SerializeField] private GameObject fly;
    
    private bool isTop = true;

    //private Vector3 start = new Vector3(-143f, -40f, 0f);
    //private Vector credits = (-143f, -80f, 0f);

    void Start()
    {
       // fly.transform.Translate();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isTop != true) {
            isTop = true;
            fly.transform.Translate(0, 40, 0);
        }
        
        if (Input.GetKeyDown(KeyCode.S) && isTop != false) {
            isTop = false;
            fly.transform.Translate(0, -40, 0);
        }
        
        if (isTop == true) {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space)) {
                Debug.Log("START");
                SceneManager.LoadScene(1);
            }
        }
        
        if (isTop == false) {
            if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space)) {
                Debug.Log("CREDITS");
                SceneManager.LoadScene(3);
            }
        }
    }
}
