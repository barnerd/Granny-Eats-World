using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WitchDialog : MonoBehaviour
{
    public GameObject dialogBox;
    public MagicShop buttons;
    public Button witch;
    public Text message;
    private bool showing = false;
    
    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
    }
    
    void Update() {
        if (Input.GetKeyDown(KeyCode.E) && showing == true) {
            HideDialog();
        }
    }
    
    public void HideDialog() {
        dialogBox.SetActive(false);
        showing = false;
        buttons.EnableButtons();
    }

    public void ShowDialog() {
        dialogBox.SetActive(true);
        showing = true;
        buttons.DisableButtons();
        
        message.text = "Hey, my grandma said you can take what you need to keep your grandma from exploding or whatever";
    }
}
