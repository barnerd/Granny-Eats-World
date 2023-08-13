using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSystem : MonoBehaviour
{
    public List<RecipeData> recipes;

    /// <summary>
    /// Check if list of items can craft given recipe
    /// </summary>
    /// <param name="_inputItems">list of items to be used in crafting</param>
    /// <param name="_recipe">the recipe to craft</param>
    /// <returns>true if the given recipe can be crafted, otherwise false</returns>
    public bool CheckRecipe(List<ItemData> _inputItems, RecipeData _recipe)
    {
        if (_inputItems != null && _recipe != null)
        {
            foreach (var _item in _recipe.inputItems)
            {
                if (!_inputItems.Contains(_item))
                {
                    return false;
                }
            }

            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Craft the given recipe from the provided items
    /// </summary>
    /// <param name="_inputItems">list of items to be used in crafting</param>
    /// <param name="_recipe">the recipe to craft</param>
    /// <returns>resulting items if recipe can be crafted, otherwise null</returns>
    public List<ItemData> CraftRecipe(List<ItemData> _inputItems, RecipeData _recipe)
    {
        return CheckRecipe(_inputItems, _recipe) && _recipe != null ? _recipe.outputItems : null;
    }

    /// <summary>
    /// Checks all known recipes to see if one can be crafted
    /// </summary>
    /// <param name="_inputItems">list of items to be used in crafting</param>
    /// <returns>true if a recipe can be crafted, otherwise, false</returns>
    public bool CheckAllRecipes(List<ItemData> _inputItems)
    {
        bool _result = false;

        foreach (var _recipe in recipes)
        {
            _result |= CheckRecipe(_inputItems, _recipe);
        }

        return _result;
    }
}
