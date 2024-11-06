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
        public TestButton( int a, int x, int y,int wide, int high)
        {
            //ClickイベントにOnClick関数を登録
            //ボタンをクリックした時に登録した関数を実行します。
            Click += OnClick;

            //ボタンに無い文字を表示させる
            Text = a.ToString();

            Location = new System.Drawing.Point(x,y);

            Size = new System.Drawing.Size(wide,high);
        }

        public void OnClick(object sender, EventArgs s)
        {
            
            
            MessageBox.Show(Text);
        }
    }
}
