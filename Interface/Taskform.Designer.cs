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
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Monotype Corsiva", 24.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(197, 32);
            label3.Name = "label3";
            label3.Size = new Size(613, 51);
            label3.TabIndex = 3;
            label3.Text = "Введите массив чисел для сортировки";
            // 
            // Taskform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(982, 553);
            Controls.Add(label3);
            Name = "Taskform";
            Text = "Taskform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
    }
}