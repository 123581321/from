﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git使って何かする
{
    internal class TestButton : Button 
    {
        public TestButton()
        {
            //ClickイベントにOnClick関数を登録
            //ボタンをクリックした時に登録した関数を実行します。
            Click += OnClick;
        }

        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show("勉強中");
        }
    }
}
