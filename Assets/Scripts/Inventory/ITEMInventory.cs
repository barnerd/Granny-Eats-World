using UnityEngine;

public class ITEMInventory : MonoBehaviour
{
    [SerializeField] private bool[] hasItem;

    void Awake()
    {
        if (hasItem == null) hasItem = new bool[10];
    }

    public void AddItem(int itemVal)
    {
        if (hasItem != null && itemVal >= 0 && itemVal < 10)
        {
            hasItem[itemVal] = true;
        }
    }

    public void RemoveItem(int itemVal)
    {
        if (hasItem != null && itemVal >= 0 && itemVal < 10)
        {
            hasItem[itemVal] = false;
        }
    }
}
