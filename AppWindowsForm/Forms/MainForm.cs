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
                JsonFileToolStripLabel.Text = JsonFile.Data;
                MessageBox.Show("The json file was selected correctly.", "Json file Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DeleteFoodsBtn_Click(object sender, EventArgs e)
        {
            RemoveFoodsForm removeFoodsForm = new RemoveFoodsForm();
            removeFoodsForm.ShowDialog();
        }
    }
}

