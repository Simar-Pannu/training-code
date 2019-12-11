using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain;
using LocationHandler;

namespace PizzaBox.Domain
{

  public class order
  {
    public LocationHandler location { get; set; } 
    private List<Piza> pizzaorders = new List<Piza>();
    //User user;
    public order() { }
   public User User { get; set; } 
   public List<Piza> pizzas { get; set; }
    List<Ingredient> ingredients = new List<Ingredient>();
    // public Arraylist Pizzaorders { get => pizzaorders; set => pizzaorders = value; }

    public void neworder()
    {

      Console.WriteLine("What type of pizza would you like?");
     // Console WriteLine
      Console.WriteLine("Please type number");
      SingaturePizza newpizza = new SingaturePizza();
      printTypes();
      {
      response1:
        int typeresponse = Convert.ToInt32(Console.ReadLine());

        if (typeresponse == 1)
        {

          newpizza.VegePizza(ingredients);
          newpizza.type = "Veggie Pizza";
        }
        else if (typeresponse == 2)
        {

          newpizza.PepperoniPizza(ingredients);
          newpizza.type = "Pepperoni Pizza";
        }
        else if (typeresponse == 3)
        {

          newpizza.MageritaPizza(ingredients);
          newpizza.type = "Magerita Pizza";
        }
        else if (typeresponse == 4)
        {

          newpizza.BBQChickenPizza(ingredients);
          newpizza.type = "BBQ Chicken Pizza";
        }
        else if (typeresponse == 5)
        {
          newpizza.HawaiianPizza(ingredients);
          newpizza.type = "Hawaiian Pizza";
        }
        else { goto response1; }
      }



      Console.WriteLine("What size of pizza would you like?");
      Console.WriteLine("1. Small - $5 ");
      Console.WriteLine("2. Medium - $10 ");
      Console.WriteLine("3. Large - $15 ");
      {
      response2:
        int Sizeresponse = Convert.ToInt32(Console.ReadLine());
        if (Sizeresponse == 1)
        {
          newpizza.size = "Small";
          newpizza.price = 10;
        }
        else if (Sizeresponse == 2)
        {
          newpizza.size = "Medium";
          newpizza.price = 15;
        }
        else if (Sizeresponse == 3)
        {
          newpizza.size = "large";
          newpizza.price = 20;
        }

        else { goto response2; }
      }

      pizzaorders.Add(newpizza);
      Console.WriteLine("Would you like to order another pizza?");
      Console.WriteLine("1. Yes");
      Console.WriteLine("2. No ");
    response3:
      int anotherone = Convert.ToInt32(Console.ReadLine());
      if (anotherone == 1)
      {
        Console.WriteLine("Max pizza orders is 100");
        Console.WriteLine("You are at {0}", pizzaorders.Count());
       if(pizzaorders.Count()<=100){
        neworder();
      }
      else
      {
           Console.WriteLine("Im sorry you have passed the limit of pizzas");
           review();
      }
      }
      else if (anotherone == 2)
      {
        review();
      }
      else { goto response3; }



    }

    public void printTypes()
    {
      Console.WriteLine("1. Veggie Pizza - Tomato Sauce, cheese, peppers, mushrooms, onions ");
      Console.WriteLine("2. Pepperoni Pizza - Tomato Sauce, cheese, Pepperoni");
      Console.WriteLine("3. Margherita Pizza - basil, fresh mozzarella, and tomatoes");
      Console.WriteLine("4. BBQ Chicken Pizza - BBQ sauce, cheese, onions, BBQ Chicken");
      Console.WriteLine("5. Hawaiian Pizza -  Tomato Sauce, cheese, ham, pineapple ");


    }
    public void review()
    {
      int totalprice = 0;
      Console.WriteLine("These are the pizzas in your order");
      foreach (SingaturePizza m in pizzaorders)
      {
        Console.WriteLine(m.type);
        totalprice += m.price;
      }
      Console.WriteLine("total price for your order is $" + totalprice);
      pizzas = pizzaorders;
      AskLocation();
    }
    public void AskLocation()
    {
     Console.WriteLine("Chose on of the locations listed bellow");
     Console.WriteLine("1. NYPizza");
     Console.WriteLine("2. TXPizza");
     Console.WriteLine("3. CAPizza");
     int Locationresponse =Convert.ToInt32(Console.ReadLine());
    if (Locationresponse ==1 ){
      location.getData("NYPizza");

    }


    }




  }







}




