using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventorySlotUI : MonoBehaviour, IDropHandler
{
    public InventoryUI inventoryUI;

    [Header("Slot info")]
    public ItemData itemData;
    public Image itemImage;

    // Start is called before the first frame update
    void Start()
    {
        if (itemData != null) SetItem(itemData);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetItem(ItemData _item)
    {
        if (_item == null)
        {
            itemData = null;
            itemImage.sprite = null;
            itemImage.gameObject.SetActive(false);
        }
        else
        {
            itemImage.rectTransform.localPosition = Vector2.zero;
            itemData = _item;
            itemImage.sprite = _item.itemSprite;
            itemImage.gameObject.SetActive(true);
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag + "dropped onto " + name);

        List<ItemData> inputItems = new List<ItemData>();

        if (itemData != null)
        {
            inputItems.Add(itemData);
            inputItems.Add(eventData.pointerDrag.GetComponent<DragDrop>().slotUI.itemData);

            RecipeData recipe = inventoryUI.inventory.craftingSystem.CheckAllRecipes(inputItems);
            if (recipe != null)
            {
                // remove input items
                foreach (var _item in inputItems)
                {
                    if (!_item.unlimited) { inventoryUI.inventory.RemoveItem(_item); }
                }

                // add output items
                foreach (var _item in recipe.outputItems)
                {
                    inventoryUI.inventory.AddItem(_item);
                }
            }
        }

        inventoryUI.UpdateUI();
    }
}
