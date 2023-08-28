using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace AppWindowsForm.Forms
{
    public partial class ViewFoodsForm : Form
    {
        public ViewFoodsForm()
        {
            InitializeComponent();
        }

        private void ViewFoodsForm_Load(object sender, EventArgs e)
        {
            ShowFoodsDataGrid(JsonFile.Data);
            UpdateFoodsCount();
        }

        private void AddFoodsBtn_Click(object sender, EventArgs e)
        {
            AddFoodForm addFoodsForm = new AddFoodForm();
            addFoodsForm.ShowDialog();
            ShowFoodsDataGrid(JsonFile.Data);
            UpdateFoodsCount();
        }

        private void EditFoodBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int idFood = int.Parse(foodsDataGrid.SelectedRows[0].Cells[0].Value.ToString());
                string nameFood = foodsDataGrid.SelectedRows[0].Cells[1].Value.ToString();
                int timeFood = int.Parse(foodsDataGrid.SelectedRows[0].Cells[2].Value.ToString());
                int priceFood = int.Parse(foodsDataGrid.SelectedRows[0].Cells[3].Value.ToString());
                int caloriesFood = int.Parse(foodsDataGrid.SelectedRows[0].Cells[4].Value.ToString());
                bool veganFood = bool.Parse(foodsDataGrid.SelectedRows[0].Cells[5].Value.ToString());

                Food foodToModify = new Food(idFood, nameFood, timeFood, priceFood, caloriesFood, veganFood);

                EditFoodForm editFoodForm = new EditFoodForm(foodToModify);
                DialogResult dialogResult = editFoodForm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    FoodRepository.UpdateFood(idFood, editFoodForm.EditedFood);
                    ShowFoodsDataGrid(JsonFile.Data);
                    UpdateFoodsCount();
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Empty or incorrect format of data in Json file", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteFoodBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this food ?", "Confirm Delete !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.OK)
            {
                DeleteFood();
                ShowFoodsDataGrid(JsonFile.Data);
                UpdateFoodsCount();
            }
        }

        private void DeleteFood()
        {
            int selectedFoodId = int.Parse(foodsDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            FoodRepository.RemoveFood(selectedFoodId);
        }

        private void ShowFoodsDataGrid(string file)
        {
            string foodsData = File.ReadAllText(file);
            FoodRepository.InitializeRepository();

            try
            {
                FoodRepository.Foods = JsonSerializer.Deserialize<List<Food>>(foodsData);
                foodsDataGrid.DataSource = FoodRepository.Foods;
            }
            catch (JsonException ex)
            {
                MessageBox.Show("Empty or incorrect format of data in Json file", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateFoodsCount()
        {
            ViewFoodsLabel.Text = $"Total Foods: {FoodRepository.Foods.Count}";
        }
    }
}
