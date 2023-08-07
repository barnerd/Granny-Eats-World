using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmellCookie : MonoBehaviour
{

    [SerializeField] public Collider cookieCollider;
    [SerializeField] public GameObject smellCookies;
    
    private GameManager gm;

    private void OnTriggerEnter(Collider cookieCollider) {
        smellCookies.SetActive(true);
    }
    
    private void OnTriggerExit(Collider cookieCollider) {
        smellCookies.SetActive(false);
        //call Frog
        //gm.destroyFrog();
    }
}
