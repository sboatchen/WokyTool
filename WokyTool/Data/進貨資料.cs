using LINQtoCSV;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.DataMgr;

namespace WokyTool.Data
{
    class 進貨資料
    {
        // 是否為新物件
        public bool IsNew = false;
        // 是否已存檔
        public bool IsSave = false;

        [CsvColumn(Name = "編號")]
        public int 編號 { get; set; }

        [CsvColumn(Name = "時間")]
        public DateTime 時間 { get; set; }

        public 廠商資料 廠商;
        [CsvColumn(Name = "廠商編號")]
        public int 廠商編號
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

        public 物品資料 物品;
        [CsvColumn(Name = "物品編號")]
        public int 物品編號
        {
            get
            {
                return 物品.編號;
            }
            set
            {
                if (IsSave)
                {
                    MessageBox.Show("進貨資料紀錄後不可再進行修改", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    物品 = 物品管理器.Instance.Get(value);
                }
            }
        }

        protected int _數量;
        [CsvColumn(Name = "數量")]
        public int 數量 
        {
            get
            {
                return _數量;
            }
            set
            {
                if (IsSave)
                {
                    MessageBox.Show("進貨資料紀錄後不可再進行修改", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _數量 = value;
                }
            }
        }

        protected double _單價;
        [CsvColumn(Name = "單價")]
        public double 單價
        {
            get
            {
                return _單價;
            }
            set
            {
                if (IsSave)
                {
                    MessageBox.Show("進貨資料紀錄後不可再進行修改", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _單價 = value;
                }
            }
        }

        public 幣值資料 幣值;
        [CsvColumn(Name = "幣值編號")]
        public int 幣值編號
        {
            get
            {
                return 幣值.編號;
            }
            set
            {
                if (IsSave)
                {
                    MessageBox.Show("進貨資料紀錄後不可再進行修改", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    幣值 = 幣值管理器.Instance.Get(value);

                    if (IsNew)
                    {
                        _匯率 = 幣值.數值;
                    }
                }
            }
        }

        protected double _匯率;
        [CsvColumn(Name = "匯率")]
        public double 匯率
        {
            get
            {
                return _匯率;
            }
            set
            {
                if (IsSave)
                {
                    MessageBox.Show("進貨資料紀錄後不可再進行修改", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _匯率 = value;
                }
            }
        }


        [CsvColumn(Name = "備註")]
        public String 備註 { get; set; }

        public double 總價
        {
            get
            {
                return 數量 * 單價;
            }
        }

        // 換算台幣
        public int 總金額
        {
            get
            {
                return (int)(總價 * _匯率);
            }
        }

        public static 進貨資料 New()
        {
            return new 進貨資料
            {
                IsNew = true,
                IsSave = false,
                編號 = 編碼管理器.Instance.Get(列舉.編碼類型.支出),
                時間 = DateTime.Now,
                廠商 = 廠商資料.NULL,
                物品 = 物品資料.NULL,
                _數量 = 0,
                _單價 = 0,
                幣值 = 幣值資料.DEFAULT,
                _匯率 = 幣值資料.DEFAULT.數值,
                備註 = 字串.空,
            };
        }

        private static readonly 進貨資料 _NULL = new 進貨資料
        {
            IsNew = false,
            IsSave = true,
            編號 = 0,
            時間 = new DateTime(0),
            廠商 = 廠商資料.NULL,
            物品 = 物品資料.NULL,
            _數量 = 0,
            _單價 = 0,
            幣值 = 幣值資料.DEFAULT,
            _匯率 = 幣值資料.DEFAULT.數值,
            備註 = 字串.空,
        };
        public static 進貨資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 進貨資料 _ERROR = new 進貨資料
        {
            IsNew = false,
            IsSave = true,
            編號 = -1,
            時間 = new DateTime(0),
            廠商 = 廠商資料.ERROR,
            物品 = 物品資料.ERROR,
            _數量 = 0,
            _單價 = 0,
            幣值 = 幣值資料.ERROR,
            _匯率 = 幣值資料.ERROR.數值,
            備註 = 字串.空,
        };
        public static 進貨資料 ERROR
        {
            get
            {
                return _ERROR;
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        public 支出資料 ToOutlay()
        {
            return new 支出資料
            {
                結算時間 = DateTime.Now,
                類型 = 字串.進貨,
                編號 = this.編號,
                建立時間 = this.時間,
                廠商 = this.廠商.名稱,
                物品 = this.物品.名稱,
                數量 = this.數量,
                單價 = this.單價,
                幣值 = this.幣值.名稱,
                匯率 = this.匯率,
                總價 = this.總價,
                總金額 = this.總金額,
                備註 = this.備註,
            };
        }

        // 匯入紀錄
        public void Import()
        {
            IsSave = true;
        }

        // 存檔
        public void Save()
        {
            if (IsSave == false)
                StockAdd();
        }

        // 新增庫存
        public void StockAdd()
        {
            if (IsSave == true)
            {
                MessageBox.Show("進貨資料::StockAdd already done, 編號 = " + 編號.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (物品編號 <= 0 || 數量 == 0)
            {
                String Message_ = string.Format("進貨資料::Add 不合法, 編號 = {0}, 物品編號 = {1}, 數量 = {2}", 編號, 物品編號, 數量);
                MessageBox.Show(Message_, 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IsNew = false;
            IsSave = true;
            物品.數量 += 數量;
            物品.最後進貨成本 = (int)(單價 * 匯率);
            物品.庫存總成本 += 總金額;

            物品管理器.Instance.IsDirty = true;
        }

        // 刪除庫存
        public void StockDel()
        {
            if (IsSave == true)
            {
                IsNew = false;
                IsSave = false;
                物品.數量 -= 數量;
                物品.庫存總成本 -= 總金額;

                物品管理器.Instance.IsDirty = true;
            }
        }
    }
}
