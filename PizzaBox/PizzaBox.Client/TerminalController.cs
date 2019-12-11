using System;
using PizzaBox.Domain;
using PizzaBox.Storing;

namespace PizzaBox
{
  public class TerminalController
  {
    User currentuser = new User();
    AccountHandler account = new AccountHandler();
    order neworder = new order();
    public void StartingBlurb()
    {
      Console.WriteLine("Welcome to Simar Pizza Pallor!");
      Console.WriteLine("Do you have an account with us? (Yes/No)");
      Console.WriteLine("1. Yes");
      Console.WriteLine("2. No");
      int response = getConsoleInt(2);
     // int response = Convert.ToInt32(Console.ReadLine());
      if (response == 1)
      {
        Console.WriteLine("Great yes");
        Console.WriteLine("I will be wallking you through the steps of creatings a new account");
        Console.WriteLine("Please enter a username");
        String usern = getConsoleString();
        Console.WriteLine("Please enter a Password");
        String userp =  getConsoleString();




      bool hassaccount = false;
        currentuser = account.UserFromFile(usern, userp);

      }
      else if (response == 2)
      {
        Console.WriteLine("Please create an account");
        Console.WriteLine("I will be wallking you through the steps of creatings a new account");
      Console.WriteLine("Please enter a username");
      //var tempusername = Console.ReadLine();
      currentuser.Username = getConsoleString();
      Console.WriteLine("Please enter a Password");
      currentuser.Password = getConsoleString();
    //  this.TimeofLastOrder = null;
      //this.LastLocation = null;
      //return User;
      neworder.User = currentuser;
      neworder.neworder();
      }
      else
      {
        Console.WriteLine("Please respond either Yes or No");
        StartingBlurb();
      }
    }
    public String getConsoleString (){
        Responseinfuction:
        try
        {
            return Convert.ToString(Console.ReadLine());
        }
        catch
        {
           Console.WriteLine("Please try again");
        goto Responseinfuction;
        }
      
    }
    public int getConsoleInt (int maxnumber){
        Responseintfuction:
        int inresponse;

       try {inresponse = Convert.ToInt32(Console.ReadLine());}
       catch{ 
        Console.WriteLine("Please try again");
        goto Responseintfuction;

       }
       if (inresponse <= maxnumber){
        return inresponse;
       }

       else{
         Console.WriteLine("Please try again");
        goto Responseintfuction;
       }
      

        
      
    }


  }







}

