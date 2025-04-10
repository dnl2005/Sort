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
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
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
            textBox1.Location = new Point(241, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(384, 43);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(232, 118);
            label2.Name = "label2";
            label2.Size = new Size(404, 39);
            label2.TabIndex = 3;
            label2.Text = "Введите массив для сортировки";
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(349, 222);
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
            label3.Location = new Point(257, 279);
            label3.Name = "label3";
            label3.Size = new Size(335, 39);
            label3.TabIndex = 6;
            label3.Text = "Отсортированный массив";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(241, 321);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(384, 43);
            textBox2.TabIndex = 7;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(855, 482);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
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
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
    }
}