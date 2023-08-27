using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Inventory inventory;
    public InventorySlotUI[] inventorySlots;

    public void UpdateUI()
    {
        for (int i = 0; i < inventory.itemLimit; i++)
        {
            inventorySlots[i].SetItem((i < inventory.items.Count) ? inventory.items[i] : null);
        }
    }
}
