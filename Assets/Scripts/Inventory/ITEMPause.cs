using UnityEngine;

public class ITEMPause : MonoBehaviour
{
    [SerializeField] private GameObject[] invPosition;

    [Space(10)]
    [SerializeField] private GameObject pressE;
    [SerializeField] private ITEMInventory inventory;
    private bool isColliding;

    void Update()
    {
        if (isColliding)
        {
            pressE.SetActive(true);
        }
        else
        {
            pressE.SetActive(false);
        }
    }

    //addItem
    public void AddItem(int itemVal)
    {
        if (invPosition != null)
        {
            invPosition[itemVal].SetActive(true);
            inventory.NewItem(itemVal);
        }
    }

    //subtractItem

    public void Show()
    {
        isColliding = true;
    }

    public void Hide()
    {
        isColliding = false;
    }
}

