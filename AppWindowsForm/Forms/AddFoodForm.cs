﻿using System;
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
            bool validatedEmpty = ValidateEmptyFields(out string errorMessage);
            bool validatedTypes = ValidateTypes(out string errorMessageType);

            if (validatedEmpty)
            {
                if (validatedTypes)
                {
                    AddNewFood();
                }
                else
                    MessageBox.Show(errorMessageType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ValidateTypes(out string errorMessageType)
        {
            errorMessageType = string.Empty;

            if (!int.TryParse(IdFoodTextBox.Text, out int id))
                errorMessageType += "The Id field can only be an integer type." + Environment.NewLine;

            if (!int.TryParse(TimeFoodText.Text, out int time))
                errorMessageType += "The Time field can only be an integer type." + Environment.NewLine;

            if (!int.TryParse(PriceFoodTextBox.Text, out int price))
                errorMessageType += "The Price field can only be an integer type." + Environment.NewLine;

            if (!int.TryParse(CaloriesFoodText.Text, out int calories))
                errorMessageType += "The Calories field can only be an integer type." + Environment.NewLine;

            return errorMessageType == string.Empty;
        }

        private bool ValidateEmptyFields(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(IdFoodTextBox.Text))
                errorMessage += "The Id field cannot be empty." + Environment.NewLine;

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
            int foodId = int.Parse(IdFoodTextBox.Text);
            string foodName = NameFoodTextBox.Text;
            int foodTime = int.Parse(TimeFoodText.Text);
            int foodPrice = int.Parse(PriceFoodTextBox.Text);
            int foodCalories = int.Parse(CaloriesFoodText.Text);
            bool foodVegan = VeganFoodYesRadioBtn.Checked;

            Food newFood = new Food(foodId, foodName, foodTime, foodPrice, foodCalories, foodVegan);

            FoodRepository.AddFood(newFood);

            MessageBox.Show("The new food was successfully added to the menu.", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }
    }
}
