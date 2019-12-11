using System;

namespace PizzaBox.Domain
{
  public class User
  {
    public string Username { get; set; }
    public string Password { get; set; }

    public DateTime TimeofLastOrder { get; set; }

    public string LastLocation { get; set; }



    public  User() { }
    public  User(String Username1, String Password1, DateTime TimeofLastOrder1,  String LastLocation1)
    {
      this.Username = Username1;
      this.Password = Password1;
      this.TimeofLastOrder = TimeofLastOrder1;
      this.LastLocation = LastLocation1;


    }
   /* 
    public void CreatUser(){
      Console.WriteLine("I will be wallking you through the steps of creatings a new account");
      Console.WriteLine("Please enter a username");
      //var tempusername = Console.ReadLine();
      this.Username = Console.ReadLine();
      Console.WriteLine("Please enter a Password");
      this.Password = (string)Console.ReadLine();
    //  this.TimeofLastOrder = null;
      //this.LastLocation = null;
      //return User;
    }
    */
  }
}
