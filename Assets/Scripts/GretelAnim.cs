using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GretelAnim : MonoBehaviour
{
    //Animations
    [SerializeField] public Animator anim;
    
    void Start() {
       // anim = GetComponent<Animator>();
        anim.SetBool("isWorried", true);
        anim.SetBool("isTalking", false);
    }
    
    public void talkingAnim() {
        anim.SetBool("isTalking", true);
    }
    
    public void stopTalkingAnim() {
        anim.SetBool("isTalking", false);
    }
    
    public void isNotWorried() {
        anim.SetBool("isWorried", false);
    }
}
