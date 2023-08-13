using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Crafting/Recipe")]
public class RecipeData : ScriptableObject
{
    // TODO: turn into a List<ItemData>?

    public ItemData firstItem;
    public ItemData secondItem;

    public ItemData resultingItem;
}
