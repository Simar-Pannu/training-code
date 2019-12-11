using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Domain
{
  public abstract class Piza
  {
   //public List<Ingredient> _ingredients = new List<Ingredient>();
    public int price { get; set; }

   public string type { get; set; }
    public string size { get; set; }

    public List<Ingredient> Ingredients{get; set;}
    }
    //  public int  price { get; private set; }       
  }
