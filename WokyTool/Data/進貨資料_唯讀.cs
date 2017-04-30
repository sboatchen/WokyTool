using LINQtoCSV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataImport;
using WokyTool.DataMgr;

namespace WokyTool.Data
{
    public class 進貨資料_唯讀 : 進貨資料
    {
        protected int _編號;
        override public int 編號 
        {
            get
            {
                return _編號;
            }
            set
            {
                BlockSetData();
            }
        }

        protected DateTime _時間;
        override public DateTime 時間
        {
            get
            {
                return _時間;
            }
            set
            {
                BlockSetData();
            }
        }

        protected 列舉.進貨類型 _類型;
        override public 列舉.進貨類型 類型
        {
            get
            {
                return _類型;
            }
            set
            {
                BlockSetData();
            }
        }

        override public int 廠商編號
        {
            get
            {
                return 廠商.編號;
            }
            set
            {
                BlockSetData();
            }
        }

        override public int 物品編號
        {
            get
            {
                return 物品.編號;
            }
            set
            {
                BlockSetData();
            }
        }

        protected int _數量;
        override public int 數量
        {
            get
            {
                return _數量;
            }
            set
            {
                BlockSetData();
            }
        }

        protected double _單價;
        override public double 單價
        {
            get
            {
                return _單價;
            }
            set
            {
                BlockSetData();
            }
        }

        override public int 幣值編號
        {
            get
            {
                return 幣值.編號;
            }
            set
            {
                BlockSetData();
            }
        }

        protected double _匯率;
        override public double 匯率
        {
            get
            {
                return _匯率;
            }
            set
            {
                BlockSetData();
            }
        }

        protected String _備註;
        override public String 備註
        {
            get
            {
                return _備註;
            }
            set
            {
                _備註 = value;
            }
        }

        protected void BlockSetData() 
        {
            MessageBox.Show("進貨資料_唯讀 不允許進行修改", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // 是否已經存檔
        override public bool IsSave()
        {
            return true;
        }

        public static 進貨資料 New(進貨資料_暫時 From_)
        {
            return new 進貨資料_唯讀
            {
                _編號 = From_.編號,
                _時間 = From_.時間,
                _類型 = From_.類型,

                廠商 = From_.廠商,
                物品 = From_.物品,

                _數量 = From_.數量,
                _單價 = From_.單價,

                幣值 = From_.幣值,
                _匯率 = From_.匯率,

                _備註 = From_.備註,
            };
        }

        public static readonly 進貨資料 _NULL = new 進貨資料_唯讀
        {
            _編號 = 常數.空白資料編碼,
            _時間 = new DateTime(0),
            _類型 = 列舉.進貨類型.一般,

            廠商 = 廠商資料.NULL,
            物品 = 物品資料.NULL,

            _數量 = 0,
            _單價 = 0,

            幣值 = 幣值資料.DEFAULT,
            _匯率 = 幣值資料.DEFAULT.數值,

            _備註 = 字串.空,
        };

        public static 進貨資料 _ERROR = new 進貨資料_唯讀
        {
            _編號 = 常數.錯誤資料編碼,
            _時間 = new DateTime(0),
            _類型 = 列舉.進貨類型.一般,

            廠商 = 廠商資料.ERROR,
            物品 = 物品資料.ERROR,

            _數量 = 0,
            _單價 = 0,

            幣值 = 幣值資料.ERROR,
            _匯率 = 幣值資料.ERROR.數值,

            _備註 = 字串.空,
        };

        // 紀錄
        override public 進貨資料 Save()
        {
            // 已記錄，直接回傳自己
            return this;
        }
        
        // 存檔
        override public void Delete()
        {
            物品.內庫數量 -= 數量;
            物品.庫存總成本 -= 總金額;

            物品管理器.Instance.IsDirty = true;
        }
    }
}



        

