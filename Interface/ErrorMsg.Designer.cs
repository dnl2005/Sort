﻿namespace Interface
{
    partial class ErrorMsg
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 178);
            label1.MaximumSize = new Size(650, 1100);
            label1.Name = "label1";
            label1.Size = new Size(116, 39);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            //label1.Click += label1_Click;
            // 
            // ErrorMsg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(797, 453);
            Controls.Add(label1);
            MaximumSize = new Size(1080, 1200);
            MinimumSize = new Size(815, 500);
            Name = "ErrorMsg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ошибка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}