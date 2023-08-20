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

        private void ShowFoodsBtn_Click(object sender, EventArgs e)
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

