using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class TermsOfUse : Form
    {
        public TermsOfUse()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(TermsOfUse));
            label8 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Monotype Corsiva", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label8.Location = new Point(350, 30);
            label8.Name = "label8";
            label8.Size = new Size(333, 46);
            label8.TabIndex = 7;
            label8.Text = "Методы сортировки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 102);
            label1.Name = "label1";
            label1.Size = new Size(882, 195);
            label1.TabIndex = 8;
            label1.Text = resources.GetString("label1.Text");
            // 
            // TermsOfUse
            // 
            BackColor = Color.FromArgb(199, 210, 242);
            ClientSize = new Size(1149, 337);
            Controls.Add(label1);
            Controls.Add(label8);
            Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            Name = "TermsOfUse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кликнули по label1!"); // Простейший код для проверки
        }

        private Label label1;
        private Label label8;
    }
}
