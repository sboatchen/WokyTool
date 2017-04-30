using LINQtoCSV;
using Newtonsoft.Json;
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
    public class 進貨資料_暫時 : 進貨資料
    {
        // 是否為新建立的資料(鑒於舊資料讀取時會先以暫時的格式讀入再轉成唯獨，"暫時"的過程中須確保匯率不會遭修改)
        protected bool _IsNew = false;

        protected int _編號;
        [CsvColumn(Name = "編號")]
        override public int 編號
        {
            get
            {
                return _編號;
            }
            set
            {
                _編號 = value;
            }
        }

        protected DateTime _時間;
        [CsvColumn(Name = "時間")]
        override public DateTime 時間
        {
            get
            {
                return _時間;
            }
            set
            {
                _時間 = value;
            }
        }

        protected 列舉.進貨類型 _類型;
        [CsvColumn(Name = "進貨類型")]
        override public 列舉.進貨類型 類型
        {
            get
            {
                return _類型;
            }
            set
            {
                _類型 = value;

                CheckUpdate單價();
            }
        }

        [CsvColumn(Name = "廠商編號")]
        override public int 廠商編號
        {
            get
            {
                return 廠商.編號;
            }
            set
            {
                廠商 = 廠商管理器.Instance.Get(value);
            }
        }

        [CsvColumn(Name = "物品編號")]
        override public int 物品編號
        {
            get
            {
                return 物品.編號;
            }
            set
            {
                物品 = 物品管理器.Instance.Get(value);

                CheckUpdate單價();
            }
        }

        protected int _數量;
        [CsvColumn(Name = "數量")]
        override public int 數量
        {
            get
            {
                return _數量;
            }
            set
            {
                _數量 = value;
            }
        }

        protected double _單價;
        [CsvColumn(Name = "單價")]
        override public double 單價
        {
            get
            {
                return _單價;
            }
            set
            {
                if (_IsNew && 類型.IsAutoPrice())
                {
                    MessageBox.Show("該類型單價自動設定", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _單價 = value;
            }
        }

        [CsvColumn(Name = "幣值編號")]
        override public int 幣值編號
        {
            get
            {
                return 幣值.編號;
            }
            set
            {
                幣值 = 幣值管理器.Instance.Get(value);

                if (_IsNew)
                {
                    匯率 = 幣值.數值;
                }
            }
        }

        protected double _匯率;
        [CsvColumn(Name = "匯率")]
        override public double 匯率
        {
            get
            {
                return _匯率;
            }
            set
            {
                _匯率 = value;
                CheckUpdate單價();
            }
        }

        protected String _備註;
        [CsvColumn(Name = "備註")]
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

        private void CheckUpdate單價()
        {
            if (_IsNew && 類型.IsAutoPrice())
                _單價 = 物品.成本 / 匯率;
        }

        // 是否已經存檔
        override public bool IsSave()
        {
            return false;
        }

        public static 進貨資料_暫時 New()
        {
            return new 進貨資料_暫時
            {
                _IsNew = true,
                _編號 = 常數.新資料編碼,
                _時間 = DateTime.Now,
                _類型 = 列舉.進貨類型.一般,

                廠商 = 廠商資料.NULL,
                物品 = 物品資料.NULL,

                _數量 = 0,
                _單價 = 0,
                
                幣值 = 幣值資料.DEFAULT,
                _匯率 = 幣值資料.DEFAULT.數值,
                _備註 = 字串.空,
            };
        }

        // 紀錄
        override public 進貨資料 Save()
        {
            if (物品 == null || _數量 == 0)
            {
                MessageBox.Show(string.Format("資料編號{0} 不合法 不予處理", _編號), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return this;
            }

            if (類型.IsAutoPrice())
            {
                單價 = 物品.成本 / 匯率;
            }
            else
            {
                物品.最後進貨成本 = (int)(單價 * 匯率);
            }

            物品.內庫數量 += 數量;
            物品.庫存總成本 += 總金額;

            物品管理器.Instance.IsDirty = true;

            編號 = 編碼管理器.Instance.Get(列舉.編碼類型.支出);
            return 進貨資料_唯讀.New(this);
        }

        // 存檔
        override public void Delete()
        {
            // 為尚未記錄的資料，直接刪除
        }


        public static 進貨資料_暫時 New(進貨匯入結構 From_)
        {
            return new 進貨資料_暫時
            {
                _時間 = From_.時間,
                _類型 = From_.類型,

                廠商 = From_.廠商,
                物品 = From_.物品,

                _數量 = From_.數量,
                _單價 = From_.單價,

                幣值 = From_._幣值,
                _匯率 = From_._幣值.數值,

                _備註 = From_.備註,
            };
        }
    }
}
