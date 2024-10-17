using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loader
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            TextBox.Enabled = false; // true
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            int pid = Process.GetCurrentProcess().Id;
            Process process = Process.GetProcessById(pid);
            process.Kill();
        }
    }
}
