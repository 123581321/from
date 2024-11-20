using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git使って何かする
{
    internal class TestButton : Button 
    {
        Form1 _form1;
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="wide"></param>
        /// <param name="high"></param>
        public TestButton(Form1 form1, int a, int x, int y, int wide, int high)
        {

            _form1 = form1;
            


           //ClickイベントにOnClick関数を登録
           //ボタンをクリックした時に登録した関数を実行します。
           Click += OnClick;

            //ボタンに無い文字を表示させる
            if (a == 0)
            {
                Text = "ち";
            }
            if (a == 1)
            {
                Text = "か";
            }
            if (a == 2)
            {
                Text = "ら";
            }
            if (a == 3)
            {
                Text = "わ";
            }
            if (a == 4)
            {
                Text = "ざ";
            }
            if (a == 5)
            {
                Text = "で";
            }
            if (a == 6)
            {
                Text = "と";
            }
            if (a == 7)
            {
                Text = "き";
            }
            if (a == 8)
            {
                Text = "ま";
            }
            if (a == 9)
            {
                Text = "す";
            }

           

            Location = new System.Drawing.Point(x,y);

            Size = new System.Drawing.Size(wide,high);
        }

        public void OnClick(object sender, EventArgs s)
        {
            string t = _form1.UpdateTextBox(Text);

            Text = t;

            _form1.LabelTextUpdate(Text);
            
          
         
        }
    }
}
