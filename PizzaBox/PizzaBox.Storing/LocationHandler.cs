using PizzaBox.Domain;
using System;
using System.Collections.Generic;
using System.IO;

using System.Linq;
namespace LocationHandler
{
  class LocationHandler : Location
  {
    private List<order> orders = new List<order>();
    public List<order> pOrdersFile { get; set; }
    public List<String> ArryofOrders { get; set; }
    public string AddressFile { get; set; }

    public string NameFile { get; set; }

    public void getData(string Name)
    {
      string fileName = Path.Combine(Name, ".txt");
      string path = Path.Combine(Environment.CurrentDirectory, @"PizzaBox.Storing/Repositories/", fileName);
      StreamReader sr = new StreamReader(path);
      Address = sr.ReadLine();
      string s = "";
      while (sr.Peek() >= 0)
      {
        s = sr.ReadLine();
        ArryofOrders.Add(s);
        Console.WriteLine(s);

      }
    }


    /*
    public void GetLocation(string Name){
      string fileName = Path.Combine(Name, ".txt");
      string path = Path.Combine(Environment.CurrentDirectory, @"PizzaBox.Storing/Repositories/", fileName);
      StreamReader sr = new StreamReader(path);
          Address = sr.ReadLine();
          String[] ArrOfStr = new String[] {};
          while (sr.Peek() >= 0)
          {
            ArrOfStr.add(sr.ReadLine());
            Console.WriteLine(s);
            //ArrOfStr = s.Split('|');

          }    

        }
        */

    public void setOrders(User user, order order, string Name)
    {
      string fileName = Path.Combine(Name, ".txt");
      string path = Path.Combine(Environment.CurrentDirectory, @"PizzaBox.Storing/Repositories/", fileName);
      if (!File.Exists(path))
      {
        StreamWriter cw = File.CreateText(path);
        cw.Write(order.location.Address);
      

          StreamWriter sw = new StreamWriter(path, append: true);
          string s = order.location.Name;
          sw.WriteLine(s + "|");
          foreach (Piza p in order.pizzas)
          {
            sw.Write(p.type + "|");
          }
          sw.Close();
          // sw.WriteLine(s);//sr.ReadLine();
          // String[] ArrOfStr = new String[] {};
          /* 
           while (sr.Peek() >= 0)
           {
             sr.ReadLine();
                   } 
                   sr.readline();  
     }
     */

          // sr.app

        

    }
    }
  }
}