using PizzaBox.Domain;
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace OrderHandler
{
    public class OrderHandler{
private order myOrder;
public order TheOrders
{
    get { return myOrder; 
    //getOrders();
    
    
    
    
    
    
    }
    set { myOrder = value;}
}
public void getOrders(User user){
 
 string fileName = Path.Combine(user.Username, ".txt");
  string path = Path.Combine(Environment.CurrentDirectory, @"PizzaBox.Storing/Repositories/", fileName);
  StreamReader sr = new StreamReader(path);
      string s = "";//sr.ReadLine();
     // String[] ArrOfStr = new String[] {};
      while (sr.Peek() >= 0)
      {
        s = sr.ReadLine();
        Console.WriteLine(s);
        //ArrOfStr = s.Split('|');

      }    
     
    }

public void setOrders(User user, order order){

 string fileName = Path.Combine(user.Username, ".txt");
  string path = Path.Combine(Environment.CurrentDirectory, @"PizzaBox.Storing/Repositories/", fileName);
  StreamWriter sw = new StreamWriter(path, append: true);
      string s = order.location.Name;
      sw.WriteLine(s + "|");
      foreach(Piza p in order.pizzas){
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
    
