namespace AppWindowsForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddFoodsBtn = new System.Windows.Forms.Button();
            this.OpenJsonFileBtn = new System.Windows.Forms.Button();
            this.foodsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFoodsBtn
            // 
            this.AddFoodsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFoodsBtn.ForeColor = System.Drawing.Color.Black;
            this.AddFoodsBtn.Location = new System.Drawing.Point(496, 12);
            this.AddFoodsBtn.Name = "AddFoodsBtn";
            this.AddFoodsBtn.Size = new System.Drawing.Size(136, 23);
            this.AddFoodsBtn.TabIndex = 2;
            this.AddFoodsBtn.Text = "Add Foods";
            this.AddFoodsBtn.UseVisualStyleBackColor = true;
            this.AddFoodsBtn.Click += new System.EventHandler(this.AddFoodsBtn_Click);
            // 
            // OpenJsonFileBtn
            // 
            this.OpenJsonFileBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.OpenJsonFileBtn.Location = new System.Drawing.Point(12, 12);
            this.OpenJsonFileBtn.Name = "OpenJsonFileBtn";
            this.OpenJsonFileBtn.Size = new System.Drawing.Size(115, 23);
            this.OpenJsonFileBtn.TabIndex = 6;
            this.OpenJsonFileBtn.Text = "Open Json File";
            this.OpenJsonFileBtn.UseVisualStyleBackColor = true;
            this.OpenJsonFileBtn.Click += new System.EventHandler(this.OpenJsonFileBtn_Click);
            // 
            // foodsDataGrid
            // 
            this.foodsDataGrid.AllowUserToAddRows = false;
            this.foodsDataGrid.AllowUserToDeleteRows = false;
            this.foodsDataGrid.AllowUserToResizeColumns = false;
            this.foodsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.foodsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.foodsDataGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.foodsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.foodsDataGrid.ColumnHeadersHeight = 30;
            this.foodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foodsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.foodsDataGrid.Location = new System.Drawing.Point(12, 56);
            this.foodsDataGrid.MultiSelect = false;
            this.foodsDataGrid.Name = "foodsDataGrid";
            this.foodsDataGrid.ReadOnly = true;
            this.foodsDataGrid.RowHeadersVisible = false;
            this.foodsDataGrid.RowHeadersWidth = 80;
            this.foodsDataGrid.ShowEditingIcon = false;
            this.foodsDataGrid.Size = new System.Drawing.Size(619, 360);
            this.foodsDataGrid.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 431);
            this.Controls.Add(this.OpenJsonFileBtn);
            this.Controls.Add(this.foodsDataGrid);
            this.Controls.Add(this.AddFoodsBtn);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Food App";
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddFoodsBtn;
        private System.Windows.Forms.Button OpenJsonFileBtn;
        private System.Windows.Forms.DataGridView foodsDataGrid;
    }
}