﻿using AppWindowsForm.Entities;
using AppWindowsForm.Forms;
using System;
using System.Windows.Forms;

namespace AppWindowsForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenJsonFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = JsonFile.Open();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                JsonFile.Data = openFileDialog.FileName;
                MessageBox.Show("The json file was selected correctly.", "Json file Select");
            }
        }

        private void ViewFoodsBtn_Click(object sender, EventArgs e)
        {
            ViewFoodsForm viewFoodsForm = new ViewFoodsForm();
            viewFoodsForm.ShowDialog();
        }

        private void AddFoodsBtn_Click(object sender, EventArgs e)
        {
            AddFoodForm addFoodsForm = new AddFoodForm();
            addFoodsForm.ShowDialog();
        }
    }
}

