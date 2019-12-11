using System;
using System.IO;
using System.Text;
//using PizzaBox.Domain.Order;
using PizzaBox.Domain;



namespace PizzaBox.Storing
{
  public class AccountHandler

  {
    string path = Path.Combine(Environment.CurrentDirectory, @"PizzaBox.Storing/Test.txt");



    //public User Currentuser1 {} //get => currentuser; set => currentuser = value; }

    public static void creatUser()
    {
      /*    User n = new User();

          Console.WriteLine("I will be wallking you through the steps of creatings a new account");
          Console.WriteLine("Please enter a username");
          n.Username = Console.ReadLine;
          Console.WriteLine("Please enter a Password");
          n.Password = Console.ReadLine;


          Order Temporder = new Order(n);
          Temporder.neworder();
    */
    }
    /*
      public bool hassUser(String username, String password){
        StreamReader sr = new StreamReader(path);
            string s = sr.ReadLine();
            String[] ArrOfStr = s.Split('|');
             while (sr.Peek() >= 0 && ArrOfStr[0]!=username&&ArrOfStr[1]!=password)

         {
           s = sr.ReadLine();
            ArrOfStr = s.Split('|');

         }
      }
    */
    public User UserFromFile(String username, String password) //out bool hassaccount
    {

      StreamReader sr = new StreamReader(path);
      string s = "";//sr.ReadLine();
      String[] ArrOfStr = new String[] {};
      while (sr.Peek() >= 0 && ArrOfStr[0] != username && ArrOfStr[1] != password)

      {
        s = sr.ReadLine();
        ArrOfStr = s.Split('|');

      }
      if (ArrOfStr[0] == username && ArrOfStr[1] == password){
      //out bool hassaccount = true;
      }
      
      Console.WriteLine(ArrOfStr[0] + ArrOfStr[1] + Convert.ToDateTime(ArrOfStr[2]) + ArrOfStr[3]);
      User UserFile = new User(ArrOfStr[0], ArrOfStr[1], Convert.ToDateTime(ArrOfStr[2]), ArrOfStr[3]);


      return UserFile;
    }
    public void writer(User Currentuser)
    {
      try
      {

        //Pass the filepath and filename to the StreamWriter Constructor
        StreamWriter sw = new StreamWriter("Test.txt");

        //Write a line of text
        sw.Write(Currentuser.Username + "|");
        sw.Write(Currentuser.Password + "|");
        sw.Write(DateTime.Now + "|");
        sw.Write(Currentuser.LastLocation + "|");
        sw.WriteLine();

        //Write a second line of text
        //sw.Write("From the StreamWriter class");

        //Close the file
        sw.Close();
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception: " + e.Message);
      }
      finally
      {
        Console.WriteLine("Executing finally block.");
      }
    }









  }

}
