using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWindowsForm.Entities
{
    class FoodRepository
    {
        public static List<Food> Foods { get; set; }

        public static void InitializeRepository()
        {
            Foods = new List<Food>();
        }

        public static void AddFood(Food food)
        {
            Foods.Add(food);
        }
    }
}
