using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Recipe", menuName = "Crafting/Recipe")]
public class RecipeData : ScriptableObject
{
    public List<ItemData> inputItems;
    public List<ItemData> outputItems;

    /// <summary>
    /// Check if list of items can craft given recipe
    /// </summary>
    /// <param name="_inputItems">list of items to be used in crafting</param>
    /// <param name="_recipe">the recipe to craft</param>
    /// <returns>true if the given recipe can be crafted, otherwise false</returns>
    public bool CheckRecipe(List<ItemData> _inputItems)
    {
        if (_inputItems == null)
        {
            return false;
        }
        else
        {
            foreach (var _item in inputItems)
            {
                if (!_inputItems.Contains(_item))
                {
                    return false;
                }
            }

            return true;
        }
    }

    /// <summary>
    /// Craft the given recipe from the provided items
    /// </summary>
    /// <param name="_inputItems">list of items to be used in crafting</param>
    /// <param name="_recipe">the recipe to craft</param>
    /// <returns>resulting items if recipe can be crafted, otherwise null</returns>
    public List<ItemData> CraftRecipe(List<ItemData> _inputItems)
    {
        return CheckRecipe(_inputItems) ? outputItems : null;
    }
}
