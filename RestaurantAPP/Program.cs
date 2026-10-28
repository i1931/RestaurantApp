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

                Console.WriteLine("===== RESTAURANT LIST =====");
                Console.WriteLine("{0,-4} {1,-25} {2,-22} {3,6}", "ID", "Name", "Type", "Rating");
                Console.WriteLine(new string('-', 62));

                foreach (Restaurant restaurant in restaurants)
                {
                    Console.WriteLine("{0,-4} {1,-25} {2,-22} {3,6:F1}",
                        restaurant.Id, restaurant.Name, restaurant.Type, restaurant.Rating);
                }

                double averageRating = 0;
                foreach (Restaurant restaurant in restaurants)
                {
                    averageRating += restaurant.Rating;
                }
                averageRating /= restaurants.Count;

                Console.WriteLine(new string('-', 62));
                Console.WriteLine("Total restaurants: {0}", restaurants.Count);
                Console.WriteLine("Average rating: {0:F2}", averageRating);
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
        }
    }
}

