using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Crafting/Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public bool unlimited;

    // GameObject for 3D Prefab, Sprite/Image for 2D UI
    [Header("GFX")]
    public Sprite itemSprite;
    //public GameObject itemGFX;
}
