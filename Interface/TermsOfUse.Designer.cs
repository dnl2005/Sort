namespace Interface
{
    partial class TermsOfUse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsOfUse));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic);
            label1.Location = new Point(-5, 49);
            label1.Name = "label1";
            label1.Size = new Size(1296, 74);
            label1.TabIndex = 0;
            label1.Text = "1)Сортировка пузырьком — это простой алгоритм сортировки, который последовательно\r\n сравнивает пары соседних элементов в массиве и обменивает их местами.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic);
            label2.Location = new Point(-5, 123);
            label2.Name = "label2";
            label2.Size = new Size(1415, 74);
            label2.TabIndex = 1;
            label2.Text = "2)Сортировка вставками— этоалгоритмов сортировки, который строит отсортированный массив \r\nпоэтапно, добавляя один элемент за раз.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic);
            label3.Location = new Point(-5, 197);
            label3.Name = "label3";
            label3.Size = new Size(1329, 111);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic);
            label4.Location = new Point(-5, 318);
            label4.Name = "label4";
            label4.Size = new Size(1308, 74);
            label4.TabIndex = 3;
            label4.Text = "4)Сортировка «черпаками» с N = 3 Мы можем проанализировать массив элементов, и в \r\nзависимости от их факторов размещать в соответствующее  части ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic);
            label5.Location = new Point(-5, 392);
            label5.Name = "label5";
            label5.Size = new Size(1217, 74);
            label5.TabIndex = 4;
            label5.Text = "5)Сортировка «черпаками» с N = 4 по сути тоже самое что сортировки n=3 и n=2 \r\nпросто больше услови";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic);
            label6.Location = new Point(-5, 466);
            label6.Name = "label6";
            label6.Size = new Size(1443, 111);
            label6.TabIndex = 5;
            label6.Text = "6)Сортировка слиянием— это алгоритм разделяет массив на две половины,рекурсивно сортирует \r\nкаждую из половин, а затем объединяет (сливает) отсортированные \r\nполовины в один отсортированный массив.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Italic);
            label7.Location = new Point(-5, 577);
            label7.Name = "label7";
            label7.Size = new Size(1355, 37);
            label7.TabIndex = 6;
            label7.Text = "7)Быстрая сортровка это процесс которыйповторяется, пока массив не будет отсортирован.";
            // 
            // TermsOfUse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(1414, 691);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Italic);
            Name = "TermsOfUse";
            Text = "TermsOfUse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}