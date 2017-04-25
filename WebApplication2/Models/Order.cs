using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WebApplication2.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public float Count { get; set; }

        public float Price { get; set; }
    }

    public static class OrderData
    {
        public static List<Order> Items = new List<Order>();
    }

}
