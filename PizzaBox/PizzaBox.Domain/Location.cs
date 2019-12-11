using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain;

namespace PizzaBox.Domain
{
    public abstract class Location {
    
    private List<order> orders = new List<order>();
    public List<order> pOrders { get; set; }
    public string Address { get; set; }

    public string Name { get; set; }






    }
}