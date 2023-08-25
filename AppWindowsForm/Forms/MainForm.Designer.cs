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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddFoodsBtn = new System.Windows.Forms.Button();
            this.OpenJsonFileBtn = new System.Windows.Forms.Button();
            this.ViewFoodsBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainImgPictureBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.JsonFileToolStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DeleteFoodsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainImgPictureBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddFoodsBtn
            // 
            this.AddFoodsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddFoodsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFoodsBtn.ForeColor = System.Drawing.Color.Black;
            this.AddFoodsBtn.Location = new System.Drawing.Point(379, 215);
            this.AddFoodsBtn.Name = "AddFoodsBtn";
            this.AddFoodsBtn.Size = new System.Drawing.Size(135, 30);
            this.AddFoodsBtn.TabIndex = 2;
            this.AddFoodsBtn.Text = "Add Foods";
            this.AddFoodsBtn.UseVisualStyleBackColor = true;
            this.AddFoodsBtn.Click += new System.EventHandler(this.AddFoodsBtn_Click);
            // 
            // OpenJsonFileBtn
            // 
            this.OpenJsonFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenJsonFileBtn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.OpenJsonFileBtn.Location = new System.Drawing.Point(379, 89);
            this.OpenJsonFileBtn.Name = "OpenJsonFileBtn";
            this.OpenJsonFileBtn.Size = new System.Drawing.Size(135, 30);
            this.OpenJsonFileBtn.TabIndex = 6;
            this.OpenJsonFileBtn.Text = "Select Json File";
            this.OpenJsonFileBtn.UseVisualStyleBackColor = true;
            this.OpenJsonFileBtn.Click += new System.EventHandler(this.OpenJsonFileBtn_Click);
            // 
            // ViewFoodsBtn
            // 
            this.ViewFoodsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewFoodsBtn.ForeColor = System.Drawing.Color.Black;
            this.ViewFoodsBtn.Location = new System.Drawing.Point(379, 153);
            this.ViewFoodsBtn.Name = "ViewFoodsBtn";
            this.ViewFoodsBtn.Size = new System.Drawing.Size(135, 30);
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
            this.TitleLabel.Location = new System.Drawing.Point(343, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(211, 37);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "Fast Food App";
            // 
            // MainImgPictureBox
            // 
            this.MainImgPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MainImgPictureBox.Image")));
            this.MainImgPictureBox.Location = new System.Drawing.Point(0, -3);
            this.MainImgPictureBox.Name = "MainImgPictureBox";
            this.MainImgPictureBox.Size = new System.Drawing.Size(306, 444);
            this.MainImgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainImgPictureBox.TabIndex = 9;
            this.MainImgPictureBox.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JsonFileToolStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(309, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(275, 23);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // JsonFileToolStripLabel
            // 
            this.JsonFileToolStripLabel.Name = "JsonFileToolStripLabel";
            this.JsonFileToolStripLabel.Size = new System.Drawing.Size(116, 18);
            this.JsonFileToolStripLabel.Text = "Json file not selected";
            // 
            // DeleteFoodsBtn
            // 
            this.DeleteFoodsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteFoodsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFoodsBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteFoodsBtn.Location = new System.Drawing.Point(379, 320);
            this.DeleteFoodsBtn.Name = "DeleteFoodsBtn";
            this.DeleteFoodsBtn.Size = new System.Drawing.Size(135, 30);
            this.DeleteFoodsBtn.TabIndex = 11;
            this.DeleteFoodsBtn.Text = "Delete Foods";
            this.DeleteFoodsBtn.UseVisualStyleBackColor = true;
            this.DeleteFoodsBtn.Click += new System.EventHandler(this.DeleteFoodsBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.DeleteFoodsBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainImgPictureBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ViewFoodsBtn);
            this.Controls.Add(this.OpenJsonFileBtn);
            this.Controls.Add(this.AddFoodsBtn);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.MaximumSize = new System.Drawing.Size(600, 480);
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Food App";
            ((System.ComponentModel.ISupportInitialize)(this.MainImgPictureBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddFoodsBtn;
        private System.Windows.Forms.Button OpenJsonFileBtn;
        private System.Windows.Forms.Button ViewFoodsBtn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox MainImgPictureBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel JsonFileToolStripLabel;
        private System.Windows.Forms.Button DeleteFoodsBtn;
    }
}