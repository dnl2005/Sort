namespace Interface
{
    partial class Taskform
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
            label3 = new Label();
            button2 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 27F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(145, 107);
            label3.Name = "label3";
            label3.Size = new Size(661, 54);
            label3.TabIndex = 3;
            label3.Text = "Введите массив чисел для сортировки";
            // 
            // button2
            // 
            button2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button2.Location = new Point(326, 264);
            button2.Name = "button2";
            button2.Size = new Size(270, 106);
            button2.TabIndex = 6;
            button2.Text = "Выполнить\r\nсортировку\r\n";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 27F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(187, 383);
            label1.Name = "label1";
            label1.Size = new Size(566, 54);
            label1.TabIndex = 7;
            label1.Text = "Отсортированный массив чисел";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 440);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Horizontal;
            textBox2.Size = new Size(639, 103);
            textBox2.TabIndex = 8;
            textBox2.WordWrap = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 176);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.Size = new Size(639, 62);
            textBox1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 27F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(145, 34);
            label2.Name = "label2";
            label2.Size = new Size(0, 54);
            label2.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 27F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(183, 34);
            label4.Name = "label4";
            label4.Size = new Size(584, 54);
            label4.TabIndex = 11;
            label4.Text = "*Выбранный споосб сортировки*";
            // 
            // Taskform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(982, 553);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(label3);
            Name = "Taskform";
            Text = "Taskform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button button2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
    }
}