﻿namespace dbd_evo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.resetButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.generateButton = new System.Windows.Forms.Button();
            this.characterLabel = new System.Windows.Forms.Label();
            this.addon1 = new System.Windows.Forms.Label();
            this.addon2 = new System.Windows.Forms.Label();
            this.perk1 = new System.Windows.Forms.Label();
            this.perk2 = new System.Windows.Forms.Label();
            this.perk3 = new System.Windows.Forms.Label();
            this.perk4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.commitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(610, 415);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(119, 23);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "Reset evolution";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(735, 415);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(53, 22);
            this.numericUpDown1.TabIndex = 1;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(13, 13);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(110, 23);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate test";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // characterLabel
            // 
            this.characterLabel.AutoSize = true;
            this.characterLabel.Location = new System.Drawing.Point(24, 54);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(44, 16);
            this.characterLabel.TabIndex = 3;
            this.characterLabel.Text = "label1";
            // 
            // addon1
            // 
            this.addon1.AutoSize = true;
            this.addon1.Location = new System.Drawing.Point(145, 54);
            this.addon1.Name = "addon1";
            this.addon1.Size = new System.Drawing.Size(44, 16);
            this.addon1.TabIndex = 4;
            this.addon1.Text = "label2";
            // 
            // addon2
            // 
            this.addon2.AutoSize = true;
            this.addon2.Location = new System.Drawing.Point(148, 74);
            this.addon2.Name = "addon2";
            this.addon2.Size = new System.Drawing.Size(44, 16);
            this.addon2.TabIndex = 5;
            this.addon2.Text = "label3";
            // 
            // perk1
            // 
            this.perk1.AutoSize = true;
            this.perk1.Location = new System.Drawing.Point(267, 54);
            this.perk1.Name = "perk1";
            this.perk1.Size = new System.Drawing.Size(44, 16);
            this.perk1.TabIndex = 6;
            this.perk1.Text = "label4";
            // 
            // perk2
            // 
            this.perk2.AutoSize = true;
            this.perk2.Location = new System.Drawing.Point(270, 74);
            this.perk2.Name = "perk2";
            this.perk2.Size = new System.Drawing.Size(44, 16);
            this.perk2.TabIndex = 7;
            this.perk2.Text = "label5";
            // 
            // perk3
            // 
            this.perk3.AutoSize = true;
            this.perk3.Location = new System.Drawing.Point(273, 94);
            this.perk3.Name = "perk3";
            this.perk3.Size = new System.Drawing.Size(44, 16);
            this.perk3.TabIndex = 8;
            this.perk3.Text = "label6";
            // 
            // perk4
            // 
            this.perk4.AutoSize = true;
            this.perk4.Location = new System.Drawing.Point(276, 114);
            this.perk4.Name = "perk4";
            this.perk4.Size = new System.Drawing.Size(44, 16);
            this.perk4.TabIndex = 9;
            this.perk4.Text = "label7";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(69, 156);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 10;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(13, 158);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(43, 16);
            this.scoreLabel.TabIndex = 11;
            this.scoreLabel.Text = "Score";
            // 
            // commitButton
            // 
            this.commitButton.Location = new System.Drawing.Point(211, 158);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(75, 23);
            this.commitButton.TabIndex = 12;
            this.commitButton.Text = "Commit";
            this.commitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.commitButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.perk4);
            this.Controls.Add(this.perk3);
            this.Controls.Add(this.perk2);
            this.Controls.Add(this.perk1);
            this.Controls.Add(this.addon2);
            this.Controls.Add(this.addon1);
            this.Controls.Add(this.characterLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.resetButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.Label addon1;
        private System.Windows.Forms.Label addon2;
        private System.Windows.Forms.Label perk1;
        private System.Windows.Forms.Label perk2;
        private System.Windows.Forms.Label perk3;
        private System.Windows.Forms.Label perk4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button commitButton;
    }
}

