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
          
            for (int i = 0; i < 10; i++)
            {

                TestButton testbutton = new TestButton (i,(i % 3) * 100, (i / 3) * 100, 100, 100) ;
                Controls.Add(testbutton);
            }
            
            TestLabel testlabel =
                new TestLabel("ラベルです。", 400, 300, 100, 500);
            Controls.Add(testlabel);

            /*Label label = new Label();
            label. Location = new Point(400,400);
            label. Text = "ラベルです";
            Controls.Add(label);*/

            }
        private void button1_Click(object sender,EventArgs e)
        {

        }

}
}
