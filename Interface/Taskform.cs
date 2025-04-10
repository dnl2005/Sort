//using ClassLibrary;
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
    public partial class Taskform : Form
    {
        private string taskName;


        public Taskform(string taskName)
        {
            InitializeComponent();
            this.taskName = taskName;
            label4.Text = taskName;
        }
        private void TaskForm_Load(object sender, EventArgs e)
        {
            label1.Anchor = AnchorStyles.None;
            label1.Location = new Point(
                (ClientSize.Width - label1.Width) / 2,
                30
            );
        }
    }
}
