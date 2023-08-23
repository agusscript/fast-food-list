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
            this.AddFoodsBtn = new System.Windows.Forms.Button();
            this.OpenJsonFileBtn = new System.Windows.Forms.Button();
            this.ViewFoodsBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddFoodsBtn
            // 
            this.AddFoodsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFoodsBtn.ForeColor = System.Drawing.Color.Black;
            this.AddFoodsBtn.Location = new System.Drawing.Point(249, 225);
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
            this.OpenJsonFileBtn.Location = new System.Drawing.Point(249, 100);
            this.OpenJsonFileBtn.Name = "OpenJsonFileBtn";
            this.OpenJsonFileBtn.Size = new System.Drawing.Size(136, 23);
            this.OpenJsonFileBtn.TabIndex = 6;
            this.OpenJsonFileBtn.Text = "Select Json File";
            this.OpenJsonFileBtn.UseVisualStyleBackColor = true;
            this.OpenJsonFileBtn.Click += new System.EventHandler(this.OpenJsonFileBtn_Click);
            // 
            // ViewFoodsBtn
            // 
            this.ViewFoodsBtn.ForeColor = System.Drawing.Color.Black;
            this.ViewFoodsBtn.Location = new System.Drawing.Point(249, 162);
            this.ViewFoodsBtn.Name = "ViewFoodsBtn";
            this.ViewFoodsBtn.Size = new System.Drawing.Size(136, 23);
            this.ViewFoodsBtn.TabIndex = 7;
            this.ViewFoodsBtn.Text = "View Foods";
            this.ViewFoodsBtn.UseVisualStyleBackColor = true;
            this.ViewFoodsBtn.Click += new System.EventHandler(this.ViewFoodsBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.TitleLabel.Location = new System.Drawing.Point(213, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(211, 37);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "Fast Food App";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 431);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ViewFoodsBtn);
            this.Controls.Add(this.OpenJsonFileBtn);
            this.Controls.Add(this.AddFoodsBtn);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Food App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddFoodsBtn;
        private System.Windows.Forms.Button OpenJsonFileBtn;
        private System.Windows.Forms.Button ViewFoodsBtn;
        private System.Windows.Forms.Label TitleLabel;
    }
}