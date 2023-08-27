using System;
using System.Windows.Forms;

namespace AppWindowsForm.Forms
{
    public partial class EditFoodForm : Form
    {
        public Food EditedFood { get; set; }

        public EditFoodForm()
        {
            InitializeComponent();
        }

        public EditFoodForm(Food newFood)
        {
            InitializeComponent();
            IdEditFoodTextBox.Text = newFood.Id.ToString();
            NameEditFoodTextBox.Text = newFood.Name;
            TimeEditFoodText.Text = newFood.Time.ToString();
            PriceEditFoodTextBox.Text = newFood.Price.ToString();
            CaloriesEditFoodText.Text = newFood.Calories.ToString();
        }

        private void SaveFoodBtn_Click(object sender, System.EventArgs e)
        {
            bool validatedEmpty = ValidateEmptyFields(out string errorMessage);
            bool validatedTypes = ValidateTypes(out string errorMessageType);

            if (validatedEmpty)
            {
                if (validatedTypes)
                {
                    AddNewEditedFood();
                }
                else
                    MessageBox.Show(errorMessageType, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AddNewEditedFood() 
        {
            int idEditedFood = int.Parse(IdEditFoodTextBox.Text.ToString());
            string nameEditedFood = NameEditFoodTextBox.Text;
            int timeEditedFood = int.Parse(TimeEditFoodText.Text);
            int priceEditedFood = int.Parse(PriceEditFoodTextBox.Text);
            int caloriesEditedFood = int.Parse(CaloriesEditFoodText.Text);
            bool veganEditedFood = VeganFoodEditYesRadioBtn.Checked;

            Food newEditedFood = new Food(idEditedFood, nameEditedFood, timeEditedFood, priceEditedFood, caloriesEditedFood, veganEditedFood);

            EditedFood = newEditedFood;

            MessageBox.Show("The food was successfully edited and added to the menu.", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
        }

        private bool ValidateTypes(out string errorMessageType)
        {
            errorMessageType = string.Empty;

            if (!int.TryParse(IdEditFoodTextBox.Text, out int id))
                errorMessageType += "The Id field can only be an integer type." + Environment.NewLine;

            if (!int.TryParse(TimeEditFoodText.Text, out int time))
                errorMessageType += "The Time field can only be an integer type." + Environment.NewLine;

            if (!int.TryParse(PriceEditFoodTextBox.Text, out int price))
                errorMessageType += "The Price field can only be an integer type." + Environment.NewLine;

            if (!int.TryParse(CaloriesEditFoodText.Text, out int calories))
                errorMessageType += "The Calories field can only be an integer type." + Environment.NewLine;

            return errorMessageType == string.Empty;
        }

        private bool ValidateEmptyFields(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(IdEditFoodTextBox.Text))
                errorMessage += "The Id field cannot be empty." + Environment.NewLine;

            if (string.IsNullOrEmpty(NameEditFoodTextBox.Text))
                errorMessage += "The Name field cannot be empty." + Environment.NewLine;

            if (string.IsNullOrEmpty(TimeEditFoodText.Text))
                errorMessage += "The Time field cannot be empty." + Environment.NewLine;

            if (string.IsNullOrEmpty(PriceEditFoodTextBox.Text))
                errorMessage += "The Price field cannot be empty." + Environment.NewLine;

            if (string.IsNullOrEmpty(CaloriesEditFoodText.Text))
                errorMessage += "The Calories field cannot be empty." + Environment.NewLine;

            return errorMessage == string.Empty;
        }
    }
}
