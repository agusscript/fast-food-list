﻿namespace AppWindowsForm
{
    partial class ViewFoodsForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.foodsDataGrid = new System.Windows.Forms.DataGridView();
            this.titleViewFoodLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // foodsDataGrid
            // 
            this.foodsDataGrid.AllowUserToAddRows = false;
            this.foodsDataGrid.AllowUserToDeleteRows = false;
            this.foodsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foodsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.foodsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foodsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.foodsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodsDataGrid.Location = new System.Drawing.Point(12, 51);
            this.foodsDataGrid.Name = "foodsDataGrid";
            this.foodsDataGrid.ReadOnly = true;
            this.foodsDataGrid.RowHeadersVisible = false;
            this.foodsDataGrid.Size = new System.Drawing.Size(538, 314);
            this.foodsDataGrid.TabIndex = 3;
            // 
            // titleViewFoodLbl
            // 
            this.titleViewFoodLbl.AutoSize = true;
            this.titleViewFoodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleViewFoodLbl.Location = new System.Drawing.Point(12, 9);
            this.titleViewFoodLbl.Name = "titleViewFoodLbl";
            this.titleViewFoodLbl.Size = new System.Drawing.Size(141, 29);
            this.titleViewFoodLbl.TabIndex = 4;
            this.titleViewFoodLbl.Text = "View Foods";
            // 
            // ViewFoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 377);
            this.Controls.Add(this.titleViewFoodLbl);
            this.Controls.Add(this.foodsDataGrid);
            this.Name = "ViewFoodsForm";
            this.Text = "View Foods List";
            this.Load += new System.EventHandler(this.ViewFoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView foodsDataGrid;
        private System.Windows.Forms.Label titleViewFoodLbl;
    }
}

