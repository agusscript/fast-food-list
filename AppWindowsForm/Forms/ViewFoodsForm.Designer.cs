namespace AppWindowsForm.Forms
{
    partial class ViewFoodsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.foodsDataGrid = new System.Windows.Forms.DataGridView();
            this.ViewFoodsLabel = new System.Windows.Forms.Label();
            this.DeleteFoodBtn = new System.Windows.Forms.Button();
            this.EditFoodBtn = new System.Windows.Forms.Button();
            this.AddFoodsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // foodsDataGrid
            // 
            this.foodsDataGrid.AllowUserToAddRows = false;
            this.foodsDataGrid.AllowUserToDeleteRows = false;
            this.foodsDataGrid.AllowUserToResizeColumns = false;
            this.foodsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.foodsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.foodsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.foodsDataGrid.ColumnHeadersHeight = 30;
            this.foodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foodsDataGrid.DefaultCellStyle = dataGridViewCellStyle30;
            this.foodsDataGrid.Location = new System.Drawing.Point(12, 56);
            this.foodsDataGrid.MultiSelect = false;
            this.foodsDataGrid.Name = "foodsDataGrid";
            this.foodsDataGrid.ReadOnly = true;
            this.foodsDataGrid.RowHeadersVisible = false;
            this.foodsDataGrid.RowHeadersWidth = 80;
            this.foodsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodsDataGrid.ShowEditingIcon = false;
            this.foodsDataGrid.Size = new System.Drawing.Size(620, 423);
            this.foodsDataGrid.TabIndex = 5;
            // 
            // ViewFoodsLabel
            // 
            this.ViewFoodsLabel.AutoSize = true;
            this.ViewFoodsLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.ViewFoodsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewFoodsLabel.ForeColor = System.Drawing.Color.White;
            this.ViewFoodsLabel.Location = new System.Drawing.Point(12, 9);
            this.ViewFoodsLabel.Name = "ViewFoodsLabel";
            this.ViewFoodsLabel.Padding = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.ViewFoodsLabel.Size = new System.Drawing.Size(162, 37);
            this.ViewFoodsLabel.TabIndex = 6;
            this.ViewFoodsLabel.Text = "Total Foods";
            // 
            // DeleteFoodBtn
            // 
            this.DeleteFoodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteFoodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFoodBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.DeleteFoodBtn.Location = new System.Drawing.Point(522, 14);
            this.DeleteFoodBtn.Name = "DeleteFoodBtn";
            this.DeleteFoodBtn.Size = new System.Drawing.Size(110, 30);
            this.DeleteFoodBtn.TabIndex = 9;
            this.DeleteFoodBtn.Text = "Delete Food";
            this.DeleteFoodBtn.UseVisualStyleBackColor = true;
            this.DeleteFoodBtn.Click += new System.EventHandler(this.DeleteFoodBtn_Click);
            // 
            // EditFoodBtn
            // 
            this.EditFoodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditFoodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFoodBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.EditFoodBtn.Location = new System.Drawing.Point(406, 14);
            this.EditFoodBtn.Name = "EditFoodBtn";
            this.EditFoodBtn.Size = new System.Drawing.Size(110, 30);
            this.EditFoodBtn.TabIndex = 10;
            this.EditFoodBtn.Text = "Edit Food";
            this.EditFoodBtn.UseVisualStyleBackColor = true;
            this.EditFoodBtn.Click += new System.EventHandler(this.EditFoodBtn_Click);
            // 
            // AddFoodsBtn
            // 
            this.AddFoodsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFoodsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFoodsBtn.ForeColor = System.Drawing.Color.Green;
            this.AddFoodsBtn.Location = new System.Drawing.Point(290, 14);
            this.AddFoodsBtn.Name = "AddFoodsBtn";
            this.AddFoodsBtn.Size = new System.Drawing.Size(110, 30);
            this.AddFoodsBtn.TabIndex = 11;
            this.AddFoodsBtn.Text = "Add Food";
            this.AddFoodsBtn.UseVisualStyleBackColor = true;
            this.AddFoodsBtn.Click += new System.EventHandler(this.AddFoodsBtn_Click);
            // 
            // ViewFoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 491);
            this.Controls.Add(this.AddFoodsBtn);
            this.Controls.Add(this.EditFoodBtn);
            this.Controls.Add(this.DeleteFoodBtn);
            this.Controls.Add(this.ViewFoodsLabel);
            this.Controls.Add(this.foodsDataGrid);
            this.MinimumSize = new System.Drawing.Size(660, 530);
            this.Name = "ViewFoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Foods";
            this.Load += new System.EventHandler(this.ViewFoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView foodsDataGrid;
        private System.Windows.Forms.Label ViewFoodsLabel;
        private System.Windows.Forms.Button DeleteFoodBtn;
        private System.Windows.Forms.Button EditFoodBtn;
        private System.Windows.Forms.Button AddFoodsBtn;
    }
}