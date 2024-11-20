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
    {　//ローカル変数、メンバ変数を保存
        TestLabel _testLabel;
        TestTextBox _textBox;
        public Form1()
        {
            InitializeComponent();
          
            for (int i = 0; i < 10; i++)
            {

                TestButton testbutton = new TestButton (this,i,(i % 3) * 100, (i / 3) * 100, 100, 100) ;
                Controls.Add(testbutton);
            }
            
               _testLabel =  new TestLabel("ラベルです。", 400, 300, 100, 500);
            Controls.Add(_testLabel);

            _textBox = new TestTextBox("", 10, 400, 500, 100);
            Controls.Add(_textBox);

            /*Label label = new Label();
            label. Location = new Point(400,400);
            label. Text = "ラベルです";
            Controls.Add(label);*/

            }
        /// <summary>
        /// ラベルの文字を更新する
        /// </summary>
        /// <param name="str"></param>
        public void LabelTextUpdate(string str)
        {
            _testLabel.TextUpdate(str);
        }
        /// <summary>  
        /// テキストボックスのテキストを更新する
        /// </summary>
        /// <param name="str"></param>
        public string UpdateTextBox(string str)
        {
            string s = _textBox.TextUpdate(str);

            return s;
            
        }


    }
}
