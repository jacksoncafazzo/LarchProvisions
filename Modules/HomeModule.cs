using Nancy;
using Recipes.Objects;
using System.Collections.Generic;
using System;

namespace Larch
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Recipe macAndCheese = new Recipe("Mac and Cheese", new List<RecipeItem>() {}, "cook time 15 mins");
      macAndCheese.save();
      Get["/"] = _ => {
        return View["/list-all-recipes.cshtml", Recipe.GetAll()];
      };
      
      // Choose a few recipes
      // Create a list of ingredients
      // User can check off things already owned

    }
  }
}
