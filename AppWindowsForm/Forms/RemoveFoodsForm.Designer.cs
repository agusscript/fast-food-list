namespace AppWindowsForm.Forms
{
    partial class RemoveFoodsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RemoveFoodsDataGrid = new System.Windows.Forms.DataGridView();
            this.ViewFoodsLabel = new System.Windows.Forms.Label();
            this.DeleteFoodBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveFoodsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoveFoodsDataGrid
            // 
            this.RemoveFoodsDataGrid.AllowUserToAddRows = false;
            this.RemoveFoodsDataGrid.AllowUserToDeleteRows = false;
            this.RemoveFoodsDataGrid.AllowUserToResizeColumns = false;
            this.RemoveFoodsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RemoveFoodsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RemoveFoodsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveFoodsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RemoveFoodsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RemoveFoodsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.RemoveFoodsDataGrid.ColumnHeadersHeight = 30;
            this.RemoveFoodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RemoveFoodsDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.RemoveFoodsDataGrid.Location = new System.Drawing.Point(12, 56);
            this.RemoveFoodsDataGrid.MultiSelect = false;
            this.RemoveFoodsDataGrid.Name = "RemoveFoodsDataGrid";
            this.RemoveFoodsDataGrid.ReadOnly = true;
            this.RemoveFoodsDataGrid.RowHeadersVisible = false;
            this.RemoveFoodsDataGrid.RowHeadersWidth = 80;
            this.RemoveFoodsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RemoveFoodsDataGrid.ShowEditingIcon = false;
            this.RemoveFoodsDataGrid.Size = new System.Drawing.Size(620, 423);
            this.RemoveFoodsDataGrid.TabIndex = 6;
            // 
            // ViewFoodsLabel
            // 
            this.ViewFoodsLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.ViewFoodsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewFoodsLabel.ForeColor = System.Drawing.Color.White;
            this.ViewFoodsLabel.Location = new System.Drawing.Point(12, 9);
            this.ViewFoodsLabel.Name = "ViewFoodsLabel";
            this.ViewFoodsLabel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.ViewFoodsLabel.Size = new System.Drawing.Size(205, 34);
            this.ViewFoodsLabel.TabIndex = 7;
            this.ViewFoodsLabel.Text = "Remove Foods";
            // 
            // DeleteFoodBtn
            // 
            this.DeleteFoodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteFoodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFoodBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.DeleteFoodBtn.Location = new System.Drawing.Point(497, 9);
            this.DeleteFoodBtn.Name = "DeleteFoodBtn";
            this.DeleteFoodBtn.Size = new System.Drawing.Size(135, 30);
            this.DeleteFoodBtn.TabIndex = 8;
            this.DeleteFoodBtn.Text = "Delete Food";
            this.DeleteFoodBtn.UseVisualStyleBackColor = true;
            this.DeleteFoodBtn.Click += new System.EventHandler(this.DeleteFoodBtn_Click);
            // 
            // RemoveFoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 491);
            this.Controls.Add(this.DeleteFoodBtn);
            this.Controls.Add(this.ViewFoodsLabel);
            this.Controls.Add(this.RemoveFoodsDataGrid);
            this.MinimumSize = new System.Drawing.Size(660, 530);
            this.Name = "RemoveFoodsForm";
            this.Text = "Remove Foods";
            this.Load += new System.EventHandler(this.RemoveFoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveFoodsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RemoveFoodsDataGrid;
        private System.Windows.Forms.Label ViewFoodsLabel;
        private System.Windows.Forms.Button DeleteFoodBtn;
    }
}