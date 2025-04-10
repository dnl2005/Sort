﻿namespace Interface
{
    partial class ProjectSort
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label7 = new Label();
            button6 = new Button();
            label8 = new Label();
            button9 = new Button();
            button1 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(357, 9);
            label2.Name = "label2";
            label2.Size = new Size(709, 72);
            label2.TabIndex = 0;
            label2.Text = "Проект \"Методы сортировки\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 24.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(420, 129);
            label3.Name = "label3";
            label3.Size = new Size(569, 51);
            label3.TabIndex = 2;
            label3.Text = "Способы сортировки по сложности";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 24.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(127, 202);
            label4.Name = "label4";
            label4.Size = new Size(116, 51);
            label4.TabIndex = 2;
            label4.Text = "O(N² )";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Monotype Corsiva", 24.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.Location = new Point(1096, 202);
            label5.Name = "label5";
            label5.Size = new Size(243, 51);
            label5.TabIndex = 2;
            label5.Text = "O(N × Log(N))";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Monotype Corsiva", 24.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(655, 201);
            label6.Name = "label6";
            label6.Size = new Size(96, 51);
            label6.TabIndex = 2;
            label6.Text = "O(N)";
            // 
            // button2
            // 
            button2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button2.Location = new Point(44, 275);
            button2.Name = "button2";
            button2.Size = new Size(270, 109);
            button2.TabIndex = 1;
            button2.Text = "Сортировка\r\nпузырьком";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button3.Location = new Point(1068, 275);
            button3.Name = "button3";
            button3.Size = new Size(270, 109);
            button3.TabIndex = 1;
            button3.Text = "Сортировка\r\nслиянием\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button4.Location = new Point(44, 421);
            button4.Name = "button4";
            button4.Size = new Size(270, 109);
            button4.TabIndex = 1;
            button4.Text = "Сортировка\r\nвставкой\r\n";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button5.Location = new Point(1068, 421);
            button5.Name = "button5";
            button5.Size = new Size(270, 109);
            button5.TabIndex = 1;
            button5.Text = "Быстрая сортировка";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Monotype Corsiva", 27F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(487, 252);
            label7.Name = "label7";
            label7.Size = new Size(418, 54);
            label7.TabIndex = 2;
            label7.Text = "Сортировка черпаками";
            // 
            // button6
            // 
            button6.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            button6.Location = new Point(357, 371);
            button6.Name = "button6";
            button6.Size = new Size(189, 52);
            button6.TabIndex = 1;
            button6.Text = "2";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Monotype Corsiva", 24.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label8.Location = new Point(320, 306);
            label8.Name = "label8";
            label8.Size = new Size(727, 51);
            label8.TabIndex = 2;
            label8.Text = "Число различных элементов для сортировки";
            // 
            // button9
            // 
            button9.BackColor = SystemColors.Highlight;
            button9.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(1337, 619);
            button9.Name = "button9";
            button9.Size = new Size(43, 49);
            button9.TabIndex = 1;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button5_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            button1.Location = new Point(599, 371);
            button1.Name = "button1";
            button1.Size = new Size(189, 52);
            button1.TabIndex = 3;
            button1.Text = "3";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic);
            button7.Location = new Point(842, 371);
            button7.Name = "button7";
            button7.Size = new Size(189, 52);
            button7.TabIndex = 4;
            button7.Text = "4";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // ProjectSort
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(1382, 669);
            Controls.Add(button7);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button9);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button6);
            Controls.Add(label2);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Name = "ProjectSort";
            Text = "ProjectSort";
            Load += ProjectSort_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label7;
        private Button button6;
        private Label label8;
        private Button button9;
        private Button button1;
        private Button button7;
    }
}
