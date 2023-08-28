using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CrystalBallScript : MonoBehaviour
{
    public GameObject dialogBox;
    public MagicShop buttons;
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
        int randNum = Random.Range(0, 2);
        showing = true;
        buttons.DisableButtons();
        
        if (randNum == 0) {
            message.text = "The princess is in another castle";
        }
        else if (randNum == 1) {
            message.text = "The cake is a lie";
        }
        else if (randNum == 2) {
            message.text = "Concentrate and ask again";
        }
        else if (randNum == 3) {
            message.text = "Samus is a girl!?!";
        }
    }
    
}
