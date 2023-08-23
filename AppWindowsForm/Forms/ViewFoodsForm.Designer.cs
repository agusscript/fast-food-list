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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.foodsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.foodsDataGrid.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.foodsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.foodsDataGrid.ColumnHeadersHeight = 30;
            this.foodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkBlue;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foodsDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.foodsDataGrid.Location = new System.Drawing.Point(12, 66);
            this.foodsDataGrid.MultiSelect = false;
            this.foodsDataGrid.Name = "foodsDataGrid";
            this.foodsDataGrid.ReadOnly = true;
            this.foodsDataGrid.RowHeadersVisible = false;
            this.foodsDataGrid.RowHeadersWidth = 80;
            this.foodsDataGrid.ShowEditingIcon = false;
            this.foodsDataGrid.Size = new System.Drawing.Size(576, 372);
            this.foodsDataGrid.TabIndex = 5;
            // 
            // ViewFoodsLabel
            // 
            this.ViewFoodsLabel.AutoSize = true;
            this.ViewFoodsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewFoodsLabel.Location = new System.Drawing.Point(12, 18);
            this.ViewFoodsLabel.Name = "ViewFoodsLabel";
            this.ViewFoodsLabel.Size = new System.Drawing.Size(141, 29);
            this.ViewFoodsLabel.TabIndex = 6;
            this.ViewFoodsLabel.Text = "View Foods";
            // 
            // ViewFoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.ViewFoodsLabel);
            this.Controls.Add(this.foodsDataGrid);
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