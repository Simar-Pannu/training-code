using System.Text.RegularExpressions;

namespace PizzaBox.Client.Validation
{
    public class NameAttribute : VallidationAttribute{




      public override bool IsValid(object o){
        
        var s = o as string;
        var regex = new Regex("[a-zA-Z*");
        
        
        return true;
      }
    }
}