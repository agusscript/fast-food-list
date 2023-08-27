using System.Collections.Generic;
using System.Text.Json;

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
            saveInJsonFile();
        }

        public static void UpdateFood(int idFoodToModify, Food updatedFood)
        {
            int foodIndex = Foods.FindIndex(food => food.Id == idFoodToModify);

            if (foodIndex != -1) 
            {
                Foods[foodIndex] = updatedFood;
            }

            saveInJsonFile();
        }

        public static void RemoveFood(int id)
        {
            Foods.RemoveAll(food => food.Id.Equals(id));
            saveInJsonFile();
        }

        public static void saveInJsonFile()
        {
            string newFoodData = JsonSerializer.Serialize(FoodRepository.Foods);
            JsonFile.Save(newFoodData);
        }
    }
}
