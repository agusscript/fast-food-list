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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ShowFoodsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(233, 28);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(216, 31);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Faast Food App";
            // 
            // ShowFoodsBtn
            // 
            this.ShowFoodsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowFoodsBtn.ForeColor = System.Drawing.Color.Black;
            this.ShowFoodsBtn.Location = new System.Drawing.Point(256, 126);
            this.ShowFoodsBtn.Name = "ShowFoodsBtn";
            this.ShowFoodsBtn.Size = new System.Drawing.Size(136, 23);
            this.ShowFoodsBtn.TabIndex = 1;
            this.ShowFoodsBtn.Text = "Show Foods";
            this.ShowFoodsBtn.UseVisualStyleBackColor = true;
            this.ShowFoodsBtn.Click += new System.EventHandler(this.ShowFoodsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 371);
            this.Controls.Add(this.ShowFoodsBtn);
            this.Controls.Add(this.TitleLabel);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ShowFoodsBtn;
    }
}