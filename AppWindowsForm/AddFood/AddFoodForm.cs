using AppWindowsForm.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace AppWindowsForm
{
    public partial class AddFoodForm : Form
    {
        public AddFoodForm()
        {
            InitializeComponent();
        }

        private void AddFoodBtn_Click(object sender, EventArgs e)
        {
            string foodsJsonFilePath = @"C:\Users\Agustin\Desktop\fast-food-list\data\foods.json";
            string foodsData = File.ReadAllText(foodsJsonFilePath);

            List<Food> listFoods = JsonSerializer.Deserialize<List<Food>>(foodsData);

            string nameValue = NameFoodTextBox.Text;
            string priceValue = PriceFoodTextBox.Text;
            string timeValue = TimeFoodText.Text;
            string caloriesValue = CaloriesFoodText.Text;
            bool veganYesRadioBtn = VeganFoodYesRadioBtn.Checked;

            listFoods.Add(new Food
            {
                id = listFoods.Count + 1,
                nombre = nameValue,
                tiempo = int.Parse(timeValue),
                precio = int.Parse(priceValue),
                calorias = int.Parse(caloriesValue),
                vegana = veganYesRadioBtn,
            });

            string newFoodData = JsonSerializer.Serialize(listFoods);

            File.WriteAllText(foodsJsonFilePath, newFoodData);

            MessageBox.Show("The new food was successfully added to the menu.");

            this.Close();
        }
    }
}
