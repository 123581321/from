﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git使って何かする
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TestButton testbutton = new TestButton();

            Controls.Add(testbutton);

        }

       
    }
}
