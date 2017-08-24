using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Exception;

namespace VkClientCsharp
{
    public partial class Form2 : Form
    {
        Form1 f1 = new Form1();
        public Form2()
        {           
            InitializeComponent();
            f1.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            auth Auth = new auth();
            Auth.SignIn(f1.textBox1.Text, f1.textBox2.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
