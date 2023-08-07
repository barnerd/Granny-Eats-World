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

    /// <summary>
    /// Add an item from the inventory
    /// </summary>
    /// <param name="itemVal">which slot to remove</param>
    public void AddItem(int itemVal)
    {
        if (invPosition != null && itemVal >= 0 && itemVal < 10)
        {
            invPosition[itemVal].SetActive(true);
            inventory.AddItem(itemVal);
        }
    }

    /// <summary>
    /// Remove an item from the inventory
    /// </summary>
    /// <param name="itemVal">which slot to remove</param>
    public void SubtractItem(int itemVal)
    {
        if (invPosition != null)
        {
            invPosition[itemVal].SetActive(false);
            inventory.RemoveItem(itemVal);
        }
    }

    public void Show()
    {
        isColliding = true;
    }

    public void Hide()
    {
        isColliding = false;
    }
}
