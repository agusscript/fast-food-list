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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.foodsDataGrid = new System.Windows.Forms.DataGridView();
            this.ViewFoodsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // foodsDataGrid
            // 
            this.foodsDataGrid.AllowUserToAddRows = false;
            this.foodsDataGrid.AllowUserToDeleteRows = false;
            this.foodsDataGrid.AllowUserToResizeColumns = false;
            this.foodsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.foodsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.foodsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.foodsDataGrid.ColumnHeadersHeight = 30;
            this.foodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foodsDataGrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.foodsDataGrid.Location = new System.Drawing.Point(12, 56);
            this.foodsDataGrid.MultiSelect = false;
            this.foodsDataGrid.Name = "foodsDataGrid";
            this.foodsDataGrid.ReadOnly = true;
            this.foodsDataGrid.RowHeadersVisible = false;
            this.foodsDataGrid.RowHeadersWidth = 80;
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
            // ViewFoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 491);
            this.Controls.Add(this.ViewFoodsLabel);
            this.Controls.Add(this.foodsDataGrid);
            this.MinimumSize = new System.Drawing.Size(660, 530);
            this.Name = "ViewFoodsForm";
            this.Text = "View Foods";
            this.Load += new System.EventHandler(this.ViewFoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView foodsDataGrid;
        private System.Windows.Forms.Label ViewFoodsLabel;
    }
}