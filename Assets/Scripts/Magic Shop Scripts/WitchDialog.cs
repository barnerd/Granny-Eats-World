using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WitchDialog : MonoBehaviour
{
    public GameObject dialogBox;
    public MagicShop buttons;
    public Image speakerImage;
    public Text message;
    public Sprite[] speakers; // HACK: this should be an object instead of hoping the indexes match
    public string[] messages;
    private int currentIndex;
    private bool showing = false;

    // Start is called before the first frame update
    void Start()
    {
        dialogBox.SetActive(false);
        currentIndex = -1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && showing == true)
        {
            ShowNextDialogue();
        }
    }

    public void HideDialogue()
    {
        dialogBox.SetActive(false);
        showing = false;
        buttons.EnableButtons();
        currentIndex = -1;
    }

    public void ShowNextDialogue()
    {
        currentIndex++;
        if (currentIndex < 0 || currentIndex >= messages.Length)
        {
            HideDialogue();
        }
        else
        {
            dialogBox.SetActive(true);
            showing = true;
            buttons.DisableButtons();

            speakerImage.sprite = speakers[currentIndex];
            message.text = messages[currentIndex]; //"Hey, my grandma said you can take what you need to keep your grandma from exploding or whatever";
        }
    }
}
