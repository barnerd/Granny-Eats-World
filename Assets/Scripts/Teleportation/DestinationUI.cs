using UnityEngine;
using TMPro;

public class DestinationUI : MonoBehaviour
{
    public Signpost destination;
    public TMP_Text text;
    public GameObject selectedFly;
    public bool isSelected;

    public void SetSignpost(Signpost _signpost)
    {
        if (_signpost != null)
        {
            destination = _signpost;
            text.text = _signpost.destinationName;
        }
    }

    public void SetSelected(bool _selected = true)
    {
        isSelected = _selected;
        selectedFly.SetActive(_selected);
    }
}
