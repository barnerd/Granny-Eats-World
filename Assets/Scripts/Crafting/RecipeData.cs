using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Crafting/Recipe")]
public class RecipeData : ScriptableObject
{
    public List<ItemData> inputItems;
    public List<ItemData> outputItems;
}
