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
            ViewFoodsLabel.Text = $"Total Foods: {FoodRepository.Foods.Count}";
        }

        private void ShowFoodsDataGrid(string file)
        {
            string foodsData = File.ReadAllText(file);

            FoodRepository.InitializeRepository();

            FoodRepository.Foods = JsonSerializer.Deserialize<List<Food>>(foodsData);

            foodsDataGrid.DataSource = FoodRepository.Foods;
        }
    }
}
