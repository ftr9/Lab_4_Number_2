﻿namespace Lab_4_Number_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TextInput = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(254, 47);
            label1.Name = "label1";
            label1.Size = new Size(217, 28);
            label1.TabIndex = 0;
            label1.Text = "Find Factors of Number";
            // 
            // TextInput
            // 
            TextInput.Location = new Point(254, 122);
            TextInput.Name = "TextInput";
            TextInput.PlaceholderText = "Enter the number";
            TextInput.Size = new Size(198, 27);
            TextInput.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(271, 191);
            button1.Name = "button1";
            button1.Size = new Size(137, 44);
            button1.TabIndex = 2;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(TextInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TextInput;
        private Button button1;
    }
}