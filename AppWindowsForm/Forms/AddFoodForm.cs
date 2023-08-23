using AppWindowsForm.Entities;
using System;
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
            string nameValue = NameFoodTextBox.Text;
            string priceValue = PriceFoodTextBox.Text;
            string timeValue = TimeFoodText.Text;
            string caloriesValue = CaloriesFoodText.Text;
            bool veganYesRadioBtn = VeganFoodYesRadioBtn.Checked;

            FoodRepository.AddFood(new Food
            {
                Id = FoodRepository.Foods.Count + 1,
                Name = nameValue,
                Time = int.Parse(timeValue),
                Price = int.Parse(priceValue),
                Calories = int.Parse(caloriesValue),
                Vegan = veganYesRadioBtn,
            });

            //string newFoodData = JsonSerializer.Serialize(FoodRepository.Foods);

            //File.WriteAllText(foodsJsonFilePath, newFoodData);

            MessageBox.Show("The new food was successfully added to the menu.");

            this.Close();
        }
    }
}
