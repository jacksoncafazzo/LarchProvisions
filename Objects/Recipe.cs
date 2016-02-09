using System;
using System.Collections.Generic;

namespace Recipes.Objects
{
  public class RecipeItem
  {
    private int _id { get; set; }
    private double _amount { get; set; }
    private string _measurement { get; set; }
    private string _name { get; set; }
    private static List<RecipeItem> _list = new List<RecipeItem>(){};
    // TODO: COST
    public RecipeItem(string name, double amount, string measurement) {
      _amount = amount;
      _name = name;
      _measurement = measurement;
    }

    public string describeItem() {
      return _name +" "+ _amount +" "+ _measurement;
    }

    public string getName() {
      return _name;
    }

    public string getMeasurement() {
      return _measurement;
    }

    public double getAmount() {
      return _amount;
    }

    public void save()
    {
      _list.Add(this);
    }

    public static List<RecipeItem> GetAll() {
      return _list;
    }
  }

  public class Recipe
  {
    private int _id {get;set;}
    private List<RecipeItem> _ingredients;
    private string _directions {get;set;}
    private string _name {get;set;}
    private static List<Recipe> _cookbook = new List<Recipe>(){};


    public Recipe(string name, List<RecipeItem> ingredients, string directions ) {
      _name = name;
      _ingredients = ingredients;
      _directions = directions;
    }

    public string getName() {
      return _name;
    }
    public List<RecipeItem> getIngredients() {
      return _ingredients;
    }

    public string getDirections() {
      return _directions;
    }

    public void save() {
      _cookbook.Add(this);
    }

    public static List<Recipe> GetAll() {
      return _cookbook;
    }
  }
}
