﻿namespace AppWindowsForm
{
    partial class AddFoodForm
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
            this.titleAddFoodLbl = new System.Windows.Forms.Label();
            this.NameFoodTextBox = new System.Windows.Forms.TextBox();
            this.NameFoodLabel = new System.Windows.Forms.Label();
            this.TimeFoodLabel = new System.Windows.Forms.Label();
            this.PriceFoodLabel = new System.Windows.Forms.Label();
            this.CaloriesFoodLabel = new System.Windows.Forms.Label();
            this.VeganFoodGroupBox = new System.Windows.Forms.GroupBox();
            this.VeganFoodNoRadioBtn = new System.Windows.Forms.RadioButton();
            this.VeganFoodYesRadioBtn = new System.Windows.Forms.RadioButton();
            this.PriceFoodTextBox = new System.Windows.Forms.TextBox();
            this.AddFoodBtn = new System.Windows.Forms.Button();
            this.TimeFoodText = new System.Windows.Forms.TextBox();
            this.CaloriesFoodText = new System.Windows.Forms.TextBox();
            this.IdFoodLabel = new System.Windows.Forms.Label();
            this.IdFoodTextBox = new System.Windows.Forms.TextBox();
            this.VeganFoodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleAddFoodLbl
            // 
            this.titleAddFoodLbl.AutoSize = true;
            this.titleAddFoodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleAddFoodLbl.Location = new System.Drawing.Point(12, 9);
            this.titleAddFoodLbl.Name = "titleAddFoodLbl";
            this.titleAddFoodLbl.Size = new System.Drawing.Size(131, 29);
            this.titleAddFoodLbl.TabIndex = 5;
            this.titleAddFoodLbl.Text = "Add Foods";
            // 
            // NameFoodTextBox
            // 
            this.NameFoodTextBox.Location = new System.Drawing.Point(239, 99);
            this.NameFoodTextBox.Name = "NameFoodTextBox";
            this.NameFoodTextBox.Size = new System.Drawing.Size(170, 20);
            this.NameFoodTextBox.TabIndex = 2;
            // 
            // NameFoodLabel
            // 
            this.NameFoodLabel.AutoSize = true;
            this.NameFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFoodLabel.Location = new System.Drawing.Point(177, 100);
            this.NameFoodLabel.Name = "NameFoodLabel";
            this.NameFoodLabel.Size = new System.Drawing.Size(45, 17);
            this.NameFoodLabel.TabIndex = 7;
            this.NameFoodLabel.Text = "Name";
            // 
            // TimeFoodLabel
            // 
            this.TimeFoodLabel.AutoSize = true;
            this.TimeFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFoodLabel.Location = new System.Drawing.Point(120, 147);
            this.TimeFoodLabel.Name = "TimeFoodLabel";
            this.TimeFoodLabel.Size = new System.Drawing.Size(102, 17);
            this.TimeFoodLabel.TabIndex = 8;
            this.TimeFoodLabel.Text = "Time (minutes)";
            // 
            // PriceFoodLabel
            // 
            this.PriceFoodLabel.AutoSize = true;
            this.PriceFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceFoodLabel.Location = new System.Drawing.Point(177, 195);
            this.PriceFoodLabel.Name = "PriceFoodLabel";
            this.PriceFoodLabel.Size = new System.Drawing.Size(40, 17);
            this.PriceFoodLabel.TabIndex = 10;
            this.PriceFoodLabel.Text = "Price";
            // 
            // CaloriesFoodLabel
            // 
            this.CaloriesFoodLabel.AutoSize = true;
            this.CaloriesFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaloriesFoodLabel.Location = new System.Drawing.Point(163, 238);
            this.CaloriesFoodLabel.Name = "CaloriesFoodLabel";
            this.CaloriesFoodLabel.Size = new System.Drawing.Size(59, 17);
            this.CaloriesFoodLabel.TabIndex = 12;
            this.CaloriesFoodLabel.Text = "Calories";
            // 
            // VeganFoodGroupBox
            // 
            this.VeganFoodGroupBox.Controls.Add(this.VeganFoodNoRadioBtn);
            this.VeganFoodGroupBox.Controls.Add(this.VeganFoodYesRadioBtn);
            this.VeganFoodGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VeganFoodGroupBox.Location = new System.Drawing.Point(166, 282);
            this.VeganFoodGroupBox.Name = "VeganFoodGroupBox";
            this.VeganFoodGroupBox.Size = new System.Drawing.Size(243, 55);
            this.VeganFoodGroupBox.TabIndex = 6;
            this.VeganFoodGroupBox.TabStop = false;
            this.VeganFoodGroupBox.Text = "Vegan";
            // 
            // VeganFoodNoRadioBtn
            // 
            this.VeganFoodNoRadioBtn.AutoSize = true;
            this.VeganFoodNoRadioBtn.Checked = true;
            this.VeganFoodNoRadioBtn.Location = new System.Drawing.Point(159, 19);
            this.VeganFoodNoRadioBtn.Name = "VeganFoodNoRadioBtn";
            this.VeganFoodNoRadioBtn.Size = new System.Drawing.Size(44, 21);
            this.VeganFoodNoRadioBtn.TabIndex = 9;
            this.VeganFoodNoRadioBtn.TabStop = true;
            this.VeganFoodNoRadioBtn.Text = "No";
            this.VeganFoodNoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // VeganFoodYesRadioBtn
            // 
            this.VeganFoodYesRadioBtn.AutoSize = true;
            this.VeganFoodYesRadioBtn.Location = new System.Drawing.Point(87, 19);
            this.VeganFoodYesRadioBtn.Name = "VeganFoodYesRadioBtn";
            this.VeganFoodYesRadioBtn.Size = new System.Drawing.Size(50, 21);
            this.VeganFoodYesRadioBtn.TabIndex = 8;
            this.VeganFoodYesRadioBtn.Text = "Yes";
            this.VeganFoodYesRadioBtn.UseVisualStyleBackColor = true;
            // 
            // PriceFoodTextBox
            // 
            this.PriceFoodTextBox.Location = new System.Drawing.Point(239, 194);
            this.PriceFoodTextBox.Name = "PriceFoodTextBox";
            this.PriceFoodTextBox.Size = new System.Drawing.Size(170, 20);
            this.PriceFoodTextBox.TabIndex = 4;
            // 
            // AddFoodBtn
            // 
            this.AddFoodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFoodBtn.Location = new System.Drawing.Point(239, 364);
            this.AddFoodBtn.Name = "AddFoodBtn";
            this.AddFoodBtn.Size = new System.Drawing.Size(135, 30);
            this.AddFoodBtn.TabIndex = 7;
            this.AddFoodBtn.Text = "Add Food";
            this.AddFoodBtn.UseVisualStyleBackColor = true;
            this.AddFoodBtn.Click += new System.EventHandler(this.AddFoodBtn_Click);
            // 
            // TimeFoodText
            // 
            this.TimeFoodText.Location = new System.Drawing.Point(239, 146);
            this.TimeFoodText.Name = "TimeFoodText";
            this.TimeFoodText.Size = new System.Drawing.Size(170, 20);
            this.TimeFoodText.TabIndex = 3;
            // 
            // CaloriesFoodText
            // 
            this.CaloriesFoodText.Location = new System.Drawing.Point(239, 237);
            this.CaloriesFoodText.Name = "CaloriesFoodText";
            this.CaloriesFoodText.Size = new System.Drawing.Size(170, 20);
            this.CaloriesFoodText.TabIndex = 5;
            // 
            // IdFoodLabel
            // 
            this.IdFoodLabel.AutoSize = true;
            this.IdFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdFoodLabel.Location = new System.Drawing.Point(203, 56);
            this.IdFoodLabel.Name = "IdFoodLabel";
            this.IdFoodLabel.Size = new System.Drawing.Size(19, 17);
            this.IdFoodLabel.TabIndex = 13;
            this.IdFoodLabel.Text = "Id";
            // 
            // IdFoodTextBox
            // 
            this.IdFoodTextBox.Location = new System.Drawing.Point(239, 55);
            this.IdFoodTextBox.Name = "IdFoodTextBox";
            this.IdFoodTextBox.Size = new System.Drawing.Size(170, 20);
            this.IdFoodTextBox.TabIndex = 1;
            // 
            // AddFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 421);
            this.Controls.Add(this.IdFoodTextBox);
            this.Controls.Add(this.IdFoodLabel);
            this.Controls.Add(this.CaloriesFoodText);
            this.Controls.Add(this.TimeFoodText);
            this.Controls.Add(this.AddFoodBtn);
            this.Controls.Add(this.PriceFoodTextBox);
            this.Controls.Add(this.VeganFoodGroupBox);
            this.Controls.Add(this.CaloriesFoodLabel);
            this.Controls.Add(this.PriceFoodLabel);
            this.Controls.Add(this.TimeFoodLabel);
            this.Controls.Add(this.NameFoodLabel);
            this.Controls.Add(this.NameFoodTextBox);
            this.Controls.Add(this.titleAddFoodLbl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(624, 460);
            this.MinimumSize = new System.Drawing.Size(624, 460);
            this.Name = "AddFoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Foods";
            this.VeganFoodGroupBox.ResumeLayout(false);
            this.VeganFoodGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleAddFoodLbl;
        private System.Windows.Forms.TextBox NameFoodTextBox;
        private System.Windows.Forms.Label NameFoodLabel;
        private System.Windows.Forms.Label TimeFoodLabel;
        private System.Windows.Forms.Label PriceFoodLabel;
        private System.Windows.Forms.Label CaloriesFoodLabel;
        private System.Windows.Forms.GroupBox VeganFoodGroupBox;
        private System.Windows.Forms.RadioButton VeganFoodNoRadioBtn;
        private System.Windows.Forms.RadioButton VeganFoodYesRadioBtn;
        private System.Windows.Forms.TextBox PriceFoodTextBox;
        private System.Windows.Forms.Button AddFoodBtn;
        private System.Windows.Forms.TextBox TimeFoodText;
        private System.Windows.Forms.TextBox CaloriesFoodText;
        private System.Windows.Forms.Label IdFoodLabel;
        private System.Windows.Forms.TextBox IdFoodTextBox;
    }
}