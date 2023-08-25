namespace AppWindowsForm.Forms
{
    partial class EditFoodsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EditFoodsDataGrid = new System.Windows.Forms.DataGridView();
            this.EditFoodsLabel = new System.Windows.Forms.Label();
            this.EditFoodBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditFoodsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EditFoodsDataGrid
            // 
            this.EditFoodsDataGrid.AllowUserToAddRows = false;
            this.EditFoodsDataGrid.AllowUserToDeleteRows = false;
            this.EditFoodsDataGrid.AllowUserToResizeColumns = false;
            this.EditFoodsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EditFoodsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.EditFoodsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditFoodsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EditFoodsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EditFoodsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.EditFoodsDataGrid.ColumnHeadersHeight = 30;
            this.EditFoodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EditFoodsDataGrid.DefaultCellStyle = dataGridViewCellStyle15;
            this.EditFoodsDataGrid.Location = new System.Drawing.Point(12, 56);
            this.EditFoodsDataGrid.MultiSelect = false;
            this.EditFoodsDataGrid.Name = "EditFoodsDataGrid";
            this.EditFoodsDataGrid.ReadOnly = true;
            this.EditFoodsDataGrid.RowHeadersVisible = false;
            this.EditFoodsDataGrid.RowHeadersWidth = 80;
            this.EditFoodsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EditFoodsDataGrid.ShowEditingIcon = false;
            this.EditFoodsDataGrid.Size = new System.Drawing.Size(620, 423);
            this.EditFoodsDataGrid.TabIndex = 7;
            // 
            // EditFoodsLabel
            // 
            this.EditFoodsLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.EditFoodsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFoodsLabel.ForeColor = System.Drawing.Color.White;
            this.EditFoodsLabel.Location = new System.Drawing.Point(12, 9);
            this.EditFoodsLabel.Name = "EditFoodsLabel";
            this.EditFoodsLabel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.EditFoodsLabel.Size = new System.Drawing.Size(149, 34);
            this.EditFoodsLabel.TabIndex = 8;
            this.EditFoodsLabel.Text = "Edit Foods";
            // 
            // EditFoodBtn
            // 
            this.EditFoodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditFoodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditFoodBtn.ForeColor = System.Drawing.Color.Green;
            this.EditFoodBtn.Location = new System.Drawing.Point(497, 12);
            this.EditFoodBtn.Name = "EditFoodBtn";
            this.EditFoodBtn.Size = new System.Drawing.Size(135, 30);
            this.EditFoodBtn.TabIndex = 9;
            this.EditFoodBtn.Text = "Edit Food";
            this.EditFoodBtn.UseVisualStyleBackColor = true;
            // 
            // EditFoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 491);
            this.Controls.Add(this.EditFoodBtn);
            this.Controls.Add(this.EditFoodsLabel);
            this.Controls.Add(this.EditFoodsDataGrid);
            this.MinimumSize = new System.Drawing.Size(660, 530);
            this.Name = "EditFoodsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Foods";
            ((System.ComponentModel.ISupportInitialize)(this.EditFoodsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EditFoodsDataGrid;
        private System.Windows.Forms.Label EditFoodsLabel;
        private System.Windows.Forms.Button EditFoodBtn;
    }
}