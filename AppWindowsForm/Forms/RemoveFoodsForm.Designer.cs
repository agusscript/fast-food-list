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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RemoveFoodsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RemoveFoodsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveFoodsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RemoveFoodsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RemoveFoodsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RemoveFoodsDataGrid.ColumnHeadersHeight = 30;
            this.RemoveFoodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RemoveFoodsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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