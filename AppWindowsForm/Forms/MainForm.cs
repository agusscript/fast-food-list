using AppWindowsForm.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace AppWindowsForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddFoodsBtn_Click(object sender, EventArgs e)
        {
            AddFoodForm addFoodsForm = new AddFoodForm();
            addFoodsForm.ShowDialog();
        }

        private void OpenJsonFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open Json File";
            openFileDialog.DefaultExt = "json";
            openFileDialog.Filter = "json files (*.json)|*.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ShowFoodsData(openFileDialog.FileName);
            }
        }

        private void ShowFoodsData(string file)
        {
            string foodsData = File.ReadAllText(file);

            FoodRepository.InitializeRepository();

            FoodRepository.Foods = JsonSerializer.Deserialize<List<Food>>(foodsData);

            foodsDataGrid.DataSource = FoodRepository.Foods;
        }
    }
}

