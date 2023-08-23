using AppWindowsForm.Entities;
using System;
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
            bool validatedEmptyFood = ValidateEmptyFields(out string errorMessage);

            if (validatedEmptyFood)
            {
                AddNewFood();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateEmptyFields(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(NameFoodTextBox.Text))
                errorMessage += "The Name field cannot be empty." + Environment.NewLine;

            if (string.IsNullOrEmpty(TimeFoodText.Text))
                errorMessage += "The Time field cannot be empty." + Environment.NewLine;

            if (string.IsNullOrEmpty(PriceFoodTextBox.Text))
                errorMessage += "The Price field cannot be empty." + Environment.NewLine;

            if (string.IsNullOrEmpty(CaloriesFoodText.Text))
                errorMessage += "The Calories field cannot be empty." + Environment.NewLine;

            return errorMessage == string.Empty;
        }

        private void AddNewFood()
        {
            FoodRepository.AddFood(new Food
            {
                Id = FoodRepository.Foods.Count + 1,
                Name = NameFoodTextBox.Text,
                Time = int.Parse(TimeFoodText.Text),
                Price = int.Parse(PriceFoodTextBox.Text),
                Calories = int.Parse(CaloriesFoodText.Text),
                Vegan = VeganFoodYesRadioBtn.Checked,
            });

            string newFoodData = JsonSerializer.Serialize(FoodRepository.Foods);

            JsonFile.Save(newFoodData);

            MessageBox.Show("The new food was successfully added to the menu.", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
