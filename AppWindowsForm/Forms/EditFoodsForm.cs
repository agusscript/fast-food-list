using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace AppWindowsForm.Forms
{
    public partial class EditFoodsForm : Form
    {
        public EditFoodsForm()
        {
            InitializeComponent();
        }

        private void EditFoodsForm_Load(object sender, EventArgs e)
        {
            ShowFoodsDataGrid(JsonFile.Data);
        }

        private void ShowFoodsDataGrid(string file)
        {
            string foodsData = File.ReadAllText(file);

            FoodRepository.InitializeRepository();

            FoodRepository.Foods = JsonSerializer.Deserialize<List<Food>>(foodsData);

            EditFoodsDataGrid.DataSource = FoodRepository.Foods;
        }
    }
}
