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
    public bool CheckAllRecipes(List<ItemData> _inputItems)
    {
        bool _result = false;

        foreach (var _recipe in recipes)
        {
            _result |= _recipe.CheckRecipe(_inputItems);
        }

        return _result;
    }
}
