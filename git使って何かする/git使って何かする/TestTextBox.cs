using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git使って何かする
{
    internal class TestTextBox : TextBox
    {
        public TestTextBox(string str, int x, int y, int wide, int high)
        {

            //ラベルに文字を表示させる
            Text = str;
            //ボタンの生成場所を指定
            Location = new System.Drawing.Point(x, y);
            //ボタンの大きさを指定
            Size = new System.Drawing.Size(wide, high);
        }


        public string TextUpdate(string str)
        {
            string kara = Text;

            Text = str;

            return kara;
        }


    }
    }

    

