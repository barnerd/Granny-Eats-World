using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Crafting/Item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public GameObject itemGFX;
}
