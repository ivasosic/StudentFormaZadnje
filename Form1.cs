﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormaStudent
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            DialogResult rez = frm.ShowDialog();

            if (rez == DialogResult.OK)
            {
                listBox1.Items.Add(frm.Student1.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }
}
