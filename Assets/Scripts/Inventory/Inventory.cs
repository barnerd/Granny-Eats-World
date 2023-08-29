using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int itemLimit;
    public List<ItemData> items;
    public InventoryUI inventoryUI;
    public CraftingSystem craftingSystem;

    void Awake()
    {
        if (items == null) items = new List<ItemData>();
    }

    public void AddItem(ItemData _item)
    {
        if (items.Count < itemLimit)
        {
            items.Add(_item);
        }
    }

    public void RemoveItem(ItemData _item)
    {
        if (items.Contains(_item))
        {
            items.Remove(_item);
        }
    }
}
