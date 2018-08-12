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
using WokyTool.通用;

namespace WokyTool.Data
{
    [JsonObject(MemberSerialization.OptIn)]
    public class 商品資料
    {
        [CsvColumn(Name = "編號")]
        [JsonProperty]
        public int 編號 { get; set; }
        
        [CsvColumn(Name = "開啟")]
        [JsonProperty]
        public bool 開啟 { get; set; }

        public 商品大類資料 大類;
        [CsvColumn(Name = "大類編號")]
        [JsonProperty]
        public int 大類編號
        {
            get
            {
                return 大類.編號;
            }
            set
            {
                大類 = 商品大類管理器.Instance.Get(value);
            }
        }

        public 商品小類資料 小類;
        [CsvColumn(Name = "小類編號")]
        [JsonProperty]
        public int 小類編號
        {
            get
            {
                return 小類.編號;
            }
            set
            {
                小類 = 商品小類管理器.Instance.Get(value);
            }
        }

        [JsonProperty]
        [CsvColumn(Name = "品號")]
        public string 品號 { get; set; }  // 對方使用的產品編號
        
        [CsvColumn(Name = "名稱")]
        [JsonProperty]
        public string 名稱 { get; set; }  // 對方使用的產品名稱

        public 公司資料 公司;
        [CsvColumn(Name = "公司編號")]
        [JsonProperty]
        public int 公司編號
        {
            get
            {
                return 公司.編號;
            }
            set
            {
                公司 = 公司管理器.Instance.Get(value);
            }
        }

        public 廠商資料 廠商;
        [CsvColumn(Name = "廠商編號")]
        [JsonProperty]
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

        [CsvColumn(Name = "寄庫")]
        [JsonProperty]
        public int 寄庫 { get; set; }

        //@@ 改用陣列儲存
        public 物品資料 需求1 = 物品資料.NULL;
        [CsvColumn(Name = "需求編號1")]
        [JsonProperty]
        public int 需求編號1
        {
            get
            {
                return 需求1.編號;
            }
            set
            {
                需求1 = 物品管理器.Instance.Get(value);
            }
        }

        public 物品資料 需求2 = 物品資料.NULL;
        [CsvColumn(Name = "需求編號2")]
        [JsonProperty]
        public int 需求編號2
        {
            get
            {
                return 需求2.編號;
            }
            set
            {
                需求2 = 物品管理器.Instance.Get(value);
            }
        }

        public 物品資料 需求3 = 物品資料.NULL;
        [CsvColumn(Name = "需求編號3")]
        [JsonProperty]
        public int 需求編號3
        {
            get
            {
                return 需求3.編號;
            }
            set
            {
                需求3 = 物品管理器.Instance.Get(value);
            }
        }

        public 物品資料 需求4 = 物品資料.NULL;
        [CsvColumn(Name = "需求編號4")]
        [JsonProperty]
        public int 需求編號4
        {
            get
            {
                return 需求4.編號;
            }
            set
            {
                需求4 = 物品管理器.Instance.Get(value);
            }
        }

        public 物品資料 需求5 = 物品資料.NULL;
        [CsvColumn(Name = "需求編號5")]
        [JsonProperty]
        public int 需求編號5
        {
            get
            {
                return 需求5.編號;
            }
            set
            {
                需求5 = 物品管理器.Instance.Get(value);
            }
        }

        [CsvColumn(Name = "數量1")]
        [JsonProperty]
        public int 數量1 { get; set; }

        [CsvColumn(Name = "數量2")]
        [JsonProperty]
        public int 數量2 { get; set; }
        
        [CsvColumn(Name = "數量3")]
        [JsonProperty]
        public int 數量3 { get; set; }
        
        [CsvColumn(Name = "數量4")]
        [JsonProperty]
        public int 數量4 { get; set; }
        
        [CsvColumn(Name = "數量5")]
        [JsonProperty]
        public int 數量5 { get; set; }

        [CsvColumn(Name = "價格")]
        [JsonProperty]
        public int 價格 { get; set; }

        // 成本
        public int 成本
        {
            get
            {
                return 需求1.成本 * 數量1 + 需求2.成本 * 數量2 + 需求3.成本 * 數量3 + 需求4.成本 * 數量4 + 需求5.成本 * 數量5;
            }
        }

        // 體積
        public int 體積
        {
            get
            {
                return 需求1.體積 * 數量1 + 需求2.體積 * 數量2 + 需求3.體積 * 數量3 + 需求4.體積 * 數量4 + 需求5.體積 * 數量5;
            }
        }

        // 利潤
        public int 利潤
        {
            get
            {
                return 價格 - 成本;
            }
        }

        public 商品資料()
        {
            編號 = -2;
            開啟 = true;

            大類 = 商品大類資料.NULL;
            小類 = 商品小類資料.NULL;

            品號 = string.Empty;
            名稱 = string.Empty;

            公司 = 公司資料.NULL;
            廠商 = 廠商資料.NULL;

            需求1 = 物品資料.NULL;
            需求2 = 物品資料.NULL;
            需求3 = 物品資料.NULL;
            需求4 = 物品資料.NULL;
            需求5 = 物品資料.NULL;
            數量1 = 0;
            數量2 = 0;
            數量3 = 0;
            數量4 = 0;
            數量5 = 0;
            價格 = 0;
        }

        public void Copy(商品資料 From_ )
        {
            //編號 = From_.編號;    這兩個不複製
            //開啟 = From_.開啟;

            大類 = From_.大類;
            小類 = From_.小類;

            品號 = From_.品號;
            名稱 = From_.名稱;

            公司 = From_.公司;
            廠商 = From_.廠商;

            需求1 = From_.需求1;
            需求2 = From_.需求2;
            需求3 = From_.需求3;
            需求4 = From_.需求4;
            需求5 = From_.需求5;
            數量1 = From_.數量1;
            數量2 = From_.數量2;
            數量3 = From_.數量3;
            數量4 = From_.數量4;
            數量5 = From_.數量5;

            價格 = From_.價格;
        }

        public static 商品資料 New()
        {
            商品資料 New_ = new 商品資料();
            New_.編號 = 編碼管理器.Instance.Get(列舉.編號.商品);

            return New_;
        }

        private static readonly 商品資料 _NULL = new 商品資料
        {
            編號 = 常數.空白資料編碼,
            開啟 = false,
            名稱 = 字串.無,

            大類 = 商品大類資料.NULL,
            小類 = 商品小類資料.NULL,

            公司 = 公司資料.NULL,
            廠商 = 廠商資料.NULL,
        };
        public static 商品資料 NULL
        {
            get
            {
                return _NULL;
            }
        }

        private static 商品資料 _ERROR = new 商品資料
        {
            編號 = 常數.錯誤資料編碼,
            開啟 = false,
            名稱 = 字串.錯誤,

            大類 = 商品大類資料.ERROR,
            小類 = 商品小類資料.ERROR,

            公司 = 公司資料.ERROR,
            廠商 = 廠商資料.ERROR,
        };
        public static 商品資料 ERROR
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

        public void GetCombine(Dictionary<String, int> 物品列表_, int 總數量_)
        {
            do
            {
                if (需求編號1 <= 0)
                    break;
                if(物品列表_.ContainsKey(需求1.縮寫))
                    物品列表_[需求1.縮寫] += 數量1 * 總數量_;
                else
                    物品列表_[需求1.縮寫] = 數量1 * 總數量_;

                if (需求編號2 <= 0)
                    break;
                if (物品列表_.ContainsKey(需求2.縮寫))
                    物品列表_[需求2.縮寫] += 數量2 * 總數量_;
                else
                    物品列表_[需求2.縮寫] = 數量2 * 總數量_;

                if (需求編號3 <= 0)
                    break;
                if (物品列表_.ContainsKey(需求3.縮寫))
                    物品列表_[需求3.縮寫] += 數量3 * 總數量_;
                else
                    物品列表_[需求3.縮寫] = 數量3 * 總數量_;

                if (需求編號4 <= 0)
                    break;
                if (物品列表_.ContainsKey(需求4.縮寫))
                    物品列表_[需求4.縮寫] += 數量4 * 總數量_;
                else
                    物品列表_[需求4.縮寫] = 數量4 * 總數量_;

                if (需求編號5 <= 0)
                    break;
                if (物品列表_.ContainsKey(需求5.縮寫))
                    物品列表_[需求5.縮寫] += 數量5 * 總數量_;
                else
                    物品列表_[需求5.縮寫] = 數量5 * 總數量_;

            } while (false);
        }

        // 物品販賣
        public bool Sell(bool 寄庫出貨_, int 總數量_)
        {
            //@@ 是否檢查為合法商品 編號>0
            if (總數量_ <= 0)
            {
                MessageBox.Show("商品資料::Sell 總數量參數不合法，請通知苦逼程式,", 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            do
            {
                //@@ should not direct control flag
                物品管理器.Instance.SetDirty();
                商品管理器.Instance.SetDirty();

                if (寄庫出貨_)
                {
                    寄庫 -= 總數量_;

                    //@@ 這裡改成小於庫存警戒值
                    //@@ 目前不處理庫存不族
                    if (寄庫 < 0)
                        MessageBox.Show(this.名稱 + " 寄庫數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (需求編號1 <= 0)
                    break;
                if(寄庫出貨_)
                {
                    需求1.外庫數量 -= 數量1 * 總數量_;
                }
                else
                {
                    需求1.內庫數量 -= 數量1 * 總數量_;
                    if(需求1.內庫數量 < 0)
                        MessageBox.Show(this.名稱 + " 庫存數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (需求編號2 <= 0)
                    break;
                if (寄庫出貨_)
                {
                    需求2.外庫數量 -= 數量2 * 總數量_;
                }
                else
                {
                    需求2.內庫數量 -= 數量2 * 總數量_;
                    if (需求2.內庫數量 < 0)
                        MessageBox.Show(this.名稱 + " 庫存數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (需求編號3 <= 0)
                    break;
                if (寄庫出貨_)
                {
                    需求3.外庫數量 -= 數量3 * 總數量_;
                }
                else
                {
                    需求3.內庫數量 -= 數量3 * 總數量_;
                    if (需求3.內庫數量 < 0)
                        MessageBox.Show(this.名稱 + " 庫存數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (需求編號4 <= 0)
                    break;
                if (寄庫出貨_)
                {
                    需求4.外庫數量 -= 數量4 * 總數量_;
                }
                else
                {
                    需求4.內庫數量 -= 數量4 * 總數量_;
                    if (需求4.內庫數量 < 0)
                        MessageBox.Show(this.名稱 + " 庫存數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (需求編號5 <= 0)
                    break;
                if (寄庫出貨_)
                {
                    需求5.外庫數量 -= 數量5 * 總數量_;
                }
                else
                {
                    需求5.內庫數量 -= 數量5 * 總數量_;
                    if (需求5.內庫數量 < 0)
                        MessageBox.Show(this.名稱 + " 庫存數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } while (false);

            return true;
        }

        // 商品寄庫
        public bool Borrow(int 總數量_)
        {
            //@@ 是否檢查為合法商品 編號>0
            if (總數量_ == 0)
                return true;

            do
            {
                //@@ 這裡改成小於庫存警戒值
                //@@ 目前不處理庫存不族
                寄庫 += 總數量_;
                if (寄庫 < 0)
                    MessageBox.Show(this.名稱 + " 寄庫數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (需求編號1 <= 0)
                    break;
                需求1.外庫數量 += 數量1 * 總數量_;
                需求1.內庫數量 -= 數量1 * 總數量_;
                if (需求1.內庫數量 < 0)
                    MessageBox.Show(this.名稱 + " 庫存數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (需求編號2 <= 0)
                    break;
                需求2.外庫數量 += 數量2 * 總數量_;
                需求2.內庫數量 -= 數量2 * 總數量_;
                if (需求2.內庫數量 < 0)
                    MessageBox.Show(this.名稱 + " 庫存數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (需求編號3 <= 0)
                    break;
                需求3.外庫數量 += 數量3 * 總數量_;
                需求3.內庫數量 -= 數量3 * 總數量_;
                if (需求3.內庫數量 < 0)
                    MessageBox.Show(this.名稱 + " 庫存數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (需求編號4 <= 0)
                    break;
                需求4.外庫數量 += 數量4 * 總數量_;
                需求4.內庫數量 -= 數量4 * 總數量_;
                if (需求4.內庫數量 < 0)
                    MessageBox.Show(this.名稱 + " 庫存數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (需求編號5 <= 0)
                    break;
                需求5.外庫數量 += 數量5 * 總數量_;
                需求5.內庫數量 -= 數量5 * 總數量_;
                if (需求5.內庫數量 < 0)
                    MessageBox.Show(this.名稱 + " 庫存數量不足", 字串.警告, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } while (false);

            return true;
        }
    }
}
