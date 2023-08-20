using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using AppWindowsForm.Entities;

namespace AppWindowsForm
{
    public partial class ViewFoodsForm : Form
    {
        public ViewFoodsForm()
        {
            InitializeComponent();
        }

        private void ViewFoodsForm_Load(object sender, EventArgs e)
        {
            string foodsData = File.ReadAllText(@"C:\Users\Agustin\Desktop\fast-food-list\data\foods.json");

            List<Food> listFoods = JsonSerializer.Deserialize<List<Food>>(foodsData);

            foodsDataGrid.DataSource = listFoods;
        }
    }
}
