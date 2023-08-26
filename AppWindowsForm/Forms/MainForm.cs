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
                UpdateToolStripLabel();
                MessageBox.Show("The json file was selected correctly.", "Json file Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ViewFoodsBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(JsonFile.Data))
            {
                ViewFoodsForm viewFoodsForm = new ViewFoodsForm();
                viewFoodsForm.ShowDialog();
            }
            else
                MessageBox.Show("No json file selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void UpdateToolStripLabel()
        {
            JsonFileToolStripLabel.Text = JsonFile.Data;
        }
    }
}

