using System;
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
            int a;
            for (int i = 0; i < 10; i++)
            {

                TestButton testbutton = new TestButton(a,(i % 3)* 100, (i / 3)* 100, 100, 100);
                Controls.Add(testbutton);

                a += 1;
            }
       

            }


}
}
