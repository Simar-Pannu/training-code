using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Domain
{

  class SingaturePizza : Piza
  {
    public void VegePizza(List<Ingredient> Ingredients)
    {
      Ingredients.Add(new Crust());
      Ingredients.Add(new TomatoSauce());
      Ingredients.Add(new Cheese());
      Ingredients.Add(new Pepper());
      Ingredients.Add(new Mushroom());
      Ingredients.Add(new Onion());
    }

    public void PepperoniPizza(List<Ingredient> Ingredients)
    {
      Ingredients.Add(new Crust());
      Ingredients.Add(new TomatoSauce());
      Ingredients.Add(new Cheese());
      Ingredients.Add(new Pepperoni());

    }


    public void MageritaPizza(List<Ingredient> Ingredients)
    {
      Ingredients.Add(new Crust());
      Ingredients.Add(new TomatoSauce());
      Ingredients.Add(new Basil());
      Ingredients.Add(new Mozzarella());
      Ingredients.Add(new Tomatoe());

    }

    public void BBQChickenPizza(List<Ingredient> Ingredients)
    {
      Ingredients.Add(new Crust());
      Ingredients.Add(new BBQSauce());
      Ingredients.Add(new BBQChicken());
      Ingredients.Add(new Cheese());
      Ingredients.Add(new Onion());

    }

    public void HawaiianPizza(List<Ingredient> Ingredients)
    {
      Ingredients.Add(new Crust());
      Ingredients.Add(new TomatoSauce());
      Ingredients.Add(new Cheese());
      Ingredients.Add(new Ham());
      Ingredients.Add(new Pineapple());

    }

    public void CheesePizza(List<Ingredient> Ingredients)
    {
      Ingredients.Add(new Crust());
      Ingredients.Add(new TomatoSauce());
      Ingredients.Add(new Cheese());

    }
  }
}