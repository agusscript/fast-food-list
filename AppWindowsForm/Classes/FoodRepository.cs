using System.Collections.Generic;

namespace AppWindowsForm
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

        public static void RemoveFood(int id)
        {
            Foods.RemoveAll(food => food.Id.Equals(id));
        }
    }
}
