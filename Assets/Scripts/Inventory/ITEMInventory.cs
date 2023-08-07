using UnityEngine;

public class ITEMInventory : MonoBehaviour
{
    [SerializeField] private bool[] hasItem;

    void Awake()
    {
        if (hasItem == null) hasItem = new bool[10];
    }

    public void NewItem(int itemVal)
    {
        hasItem[itemVal] = true;
    }
}
