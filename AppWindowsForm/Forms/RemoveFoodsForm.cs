using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace AppWindowsForm.Forms
{
    public partial class RemoveFoodsForm : Form
    {
        public RemoveFoodsForm()
        {
            InitializeComponent();
        }

        private void RemoveFoodsForm_Load(object sender, EventArgs e)
        {
            ShowFoodsDataGrid(JsonFile.Data);
        }

        private void DeleteFoodBtn_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this food ?", "Confirm Delete !", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.OK)
            {
                DeleteFood();
                ShowFoodsDataGrid(JsonFile.Data);
            }
        }

        private void DeleteFood()
        {
            int selectedFoodId = int.Parse(RemoveFoodsDataGrid.SelectedRows[0].Cells[0].Value.ToString());

            FoodRepository.RemoveFood(selectedFoodId);

            string newFoodData = JsonSerializer.Serialize(FoodRepository.Foods);

            JsonFile.Save(newFoodData);
        }

        private void ShowFoodsDataGrid(string file)
        {
            string foodsData = File.ReadAllText(file);

            FoodRepository.InitializeRepository();

            FoodRepository.Foods = JsonSerializer.Deserialize<List<Food>>(foodsData);

            RemoveFoodsDataGrid.DataSource = FoodRepository.Foods;
        }
    }
}
