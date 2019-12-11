using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Client.Models

{
  public class Pizza
  {
    [Required]
    public string Crust { get; set; }

    [Range(1,10)]
    public int Quantity {get; set;}
  [Required]
    public string Size { get; set; }
    public List<string> Crusts { get; set; }
    public List<string> Sizes { get; set; }

    public Pizza(){
      Crusts = new List<string>{"thin", "deep dish"};
      Sizes = new List<string>{"small", "Medium", "Large"};
    }





  }


}