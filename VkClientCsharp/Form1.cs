﻿using System;
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

namespace VkClientCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form1 f1 = new Form1();
        Form2 f2 = new Form2();

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vk = new VkApi();
            string email = textBox1.Text;
            string pass = textBox2.Text;
            Settings scope = Settings.All;
            ulong appId = 6159996;
            vk.Authorize(new ApiAuthParams
            {
                ApplicationId = appId,
                Login = email,
                Password = pass,
                Settings = scope
            });
            f2.Show();
            f1.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
