namespace Interface
{
    partial class TaskForm
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
            Title = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            arrLength = new TextBox();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Monotype Corsiva", 36F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Title.Location = new Point(369, 21);
            Title.Name = "Title";
            Title.Size = new Size(126, 57);
            Title.TabIndex = 0;
            Title.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(247, 255);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 43);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(350, 304);
            button1.Name = "button1";
            button1.Size = new Size(168, 49);
            button1.TabIndex = 5;
            button1.Text = "Сортировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(266, 360);
            label3.Name = "label3";
            label3.Size = new Size(335, 39);
            label3.TabIndex = 6;
            label3.Text = "Отсортированный массив";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(247, 402);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(384, 43);
            textBox2.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(266, 159);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 9;
            label1.Text = "Длина массива";
            // 
            // arrLength
            // 
            arrLength.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            arrLength.Location = new Point(247, 187);
            arrLength.Name = "arrLength";
            arrLength.Size = new Size(167, 43);
            arrLength.TabIndex = 10;
            // 
            // button2
            // 
            button2.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button2.Location = new Point(454, 187);
            button2.Name = "button2";
            button2.Size = new Size(177, 43);
            button2.TabIndex = 11;
            button2.Text = "Сгенерировать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(310, 96);
            label4.Name = "label4";
            label4.Size = new Size(246, 39);
            label4.TabIndex = 12;
            label4.Text = "Генерация массива";
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(855, 482);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(arrLength);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(Title);
            Name = "TaskForm";
            Text = "TaskForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox textBox1;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
        private Label label1;
        private TextBox arrLength;
        private Button button2;
        private Label label4;
    }
}