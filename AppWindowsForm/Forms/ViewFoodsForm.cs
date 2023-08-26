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
            int selectedFoodId = int.Parse(foodsDataGrid.SelectedRows[0].Cells[0].Value.ToString());

            MessageBox.Show(selectedFoodId.ToString());
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

            string newFoodData = JsonSerializer.Serialize(FoodRepository.Foods);

            JsonFile.Save(newFoodData);
        }

        private void ShowFoodsDataGrid(string file)
        {
            string foodsData = File.ReadAllText(file);

            FoodRepository.InitializeRepository();

            FoodRepository.Foods = JsonSerializer.Deserialize<List<Food>>(foodsData);

            foodsDataGrid.DataSource = FoodRepository.Foods;
        }

        private void UpdateFoodsCount()
        {
            ViewFoodsLabel.Text = $"Total Foods: {FoodRepository.Foods.Count}";
        }
    }
}
