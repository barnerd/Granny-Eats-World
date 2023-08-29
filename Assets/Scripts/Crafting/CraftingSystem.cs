using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSystem : MonoBehaviour
{
    public List<RecipeData> recipes;

    /// <summary>
    /// Checks all known recipes to see if one can be crafted
    /// </summary>
    /// <param name="_inputItems">list of items to be used in crafting</param>
    /// <returns>true if a recipe can be crafted, otherwise, false</returns>
    public RecipeData CheckAllRecipes(List<ItemData> _inputItems)
    {
        foreach (var _recipe in recipes)
        {
            if (_recipe.CheckRecipe(_inputItems))
            {
                return _recipe;
            }
        }

        return null;
    }
}
