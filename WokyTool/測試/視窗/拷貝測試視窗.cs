﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.通用;

namespace WokyTool.測試
{
    public partial class 拷貝測試視窗 : Form
    {
        public 拷貝測試視窗()
        {
            InitializeComponent();
        }

        private void 拷貝_Click(object sender, EventArgs e)
        {
            Random 隨機_ = new Random();
            讀寫測試資料 讀寫測試資料_ = new 讀寫測試資料
            {
                字串 = "1",
                整數 = 1,
                浮點數 = 1,
                倍精準浮點數 = 1,
                時間 = DateTime.Now,
                列舉 = (列舉.編號)1,
                整數列 = new int[] { 1, 2, 3, 4 }.ToList(),
                整數2 = 1,
            };

            讀寫測試資料_.書 = new Dictionary<int, string>();
            讀寫測試資料_.書.Add(1, "1");

            Console.WriteLine(讀寫測試資料_.ToString(false));
            讀寫測試資料 淺複製_ = 讀寫測試資料_.淺複製() as 讀寫測試資料;
            讀寫測試資料 深複製_ = 讀寫測試資料_.深複製();

            // 修改資料

            讀寫測試資料_.字串 = "modify";
            讀寫測試資料_.整數 = -1;
            讀寫測試資料_.浮點數 = -1;
            讀寫測試資料_.倍精準浮點數 = -1;
            讀寫測試資料_.時間 = new DateTime();
            讀寫測試資料_.列舉 = (列舉.編號)(0);
            讀寫測試資料_.整數列[0] = -1;
            讀寫測試資料_.書[1] = "modify";
            讀寫測試資料_.整數2 = -1;

            Console.WriteLine(讀寫測試資料_.ToString(false));
            Console.WriteLine(淺複製_.ToString(false));
            Console.WriteLine(深複製_.ToString(false));
        }

        private void 屬性_Click(object sender, EventArgs e)
        {
            Type myType = typeof(讀寫測試資料);
            foreach (PropertyInfo prop in myType.GetProperties())
            {
                Console.WriteLine(prop);

                foreach (var x in prop.GetCustomAttributes())
                {
                    Console.WriteLine(x);
                }

                Console.WriteLine("-------------");
            }
        }
    }
}
