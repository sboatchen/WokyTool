﻿using LinqToExcel;
using LinqToExcel.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;

namespace WokyTool.通用
{
    public abstract class 靜態匯入資料 : MyData
    {
        virtual public void 初始化(){;}

        abstract public void 更新();

        static public BindingList<T> 匯入Excel<T>() where T : 靜態匯入資料
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Excel files|*.*";

            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return null;

            ExcelQueryFactory Excel_ = null;

            try
            {
                Excel_ = new ExcelQueryFactory(openFileDialog1.FileName);
                ExcelQueryable<T> Source_ = Excel_.Worksheet<T>();
                BindingList<T> BList_ = new BindingList<T>();

                foreach (var Item_ in Source_)
                {
                    Item_.初始化();
                    BList_.Add(Item_);
                }

                // 備份
                檔案.備份匯入檔案(openFileDialog1.FileName, typeof(T).Name);

                return BList_;
            }
            catch (Exception ex)
            {
                訊息管理器.獨體.Error("開啟檔案失敗", ex);
                return null;
            }
            finally
            {
                if (Excel_ != null)
                    Excel_.Dispose();
            }
        }
    }
}
