using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                new Restaurant(4, "Huguosi Snacks", "Snacks", 4.2),
                new Restaurant(5, "Haidilao Hot Pot", "Hot Pot", 4.8)
             };
                foreach (Restaurant restaurant in restaurants)
                {
                    Console.WriteLine(
                        $"{restaurant.Id} | {restaurant.Name} | {restaurant.Type} | {restaurant.Rating}"
                    );
                }
            }


        }
    }
}
public class Restaurant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double Rating { get; set; }

    public Restaurant(int id, string name, string type, double rating)
    {
        Id = id;
        Name = name;
        Type = type;
        Rating = rating;
    }
}

