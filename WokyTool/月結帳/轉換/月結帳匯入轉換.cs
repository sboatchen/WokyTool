using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WokyTool.Common;
using WokyTool.公司;
using WokyTool.月結帳;
using WokyTool.客戶;
using WokyTool.商品;
using WokyTool.通用;

public delegate void 設定商品委派(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_);
public delegate void 設定金額委派(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_);

namespace WokyTool.月結帳
{
    public class 月結帳匯入轉換 : 檔案匯入轉換介面<月結帳資料>
    {
        private 月結帳匯入設定資料 _設定;
        private 設定商品委派 設定商品;
        private 設定金額委派 設定金額;

        private void 設定商品編號(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            月結帳資料_.商品識別 = 動態資料_.Get<String>(月結帳列舉.匯入需求欄位.商品編號.ToString());
            月結帳資料_.商品 = 商品資料管理器.獨體.Get(_設定.客戶.編號, 月結帳資料_.商品識別);
        }

        private void 設定商品編號_顏色(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            String 商品編號 = 動態資料_.Get<String>(月結帳列舉.匯入需求欄位.商品編號.ToString());
            String 顏色 = 動態資料_.Get<String>(月結帳列舉.匯入需求欄位.顏色.ToString());
            月結帳資料_.商品識別 = 商品編號 + "@" + 顏色;

            月結帳資料_.商品 = 商品資料管理器.獨體.Get(_設定.客戶.編號, 月結帳資料_.商品識別);
        }

        private void 設定商品名稱(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            月結帳資料_.商品識別 = 動態資料_.Get<String>(月結帳列舉.匯入需求欄位.商品名稱.ToString()); 
            月結帳資料_.商品 = 商品資料管理器.獨體.GetByName(_設定.客戶.編號, 月結帳資料_.商品識別);
        }

        private void 設定數量_單價(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            月結帳資料_.單價 = 動態資料_.Get<Decimal>(月結帳列舉.匯入需求欄位.單價.ToString()); 
            月結帳資料_.含稅單價 = 月結帳資料_.單價 * 1.05m;
            月結帳資料_.數量 = 動態資料_.Get<Int32>(月結帳列舉.匯入需求欄位.數量.ToString()); 
        }

        private void 設定數量_含稅單價(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            月結帳資料_.含稅單價 = 動態資料_.Get<Decimal>(月結帳列舉.匯入需求欄位.含稅單價.ToString()); 
            月結帳資料_.單價 = 月結帳資料_.含稅單價 / 1.05m;
            月結帳資料_.數量 = 動態資料_.Get<Int32>(月結帳列舉.匯入需求欄位.數量.ToString()); 
        }

        private void 設定數量_總價(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            月結帳資料_.數量 = 動態資料_.Get<Int32>(月結帳列舉.匯入需求欄位.數量.ToString());

            if (月結帳資料_.數量 == 0)
                月結帳資料_.單價 = 0;
            else
            {
                decimal 總價 = 動態資料_.Get<Decimal>(月結帳列舉.匯入需求欄位.總價.ToString());
                月結帳資料_.單價 = 總價 / 月結帳資料_.數量;
            }

            月結帳資料_.含稅單價 = 月結帳資料_.單價 * 1.05m;
        }

        private void 設定數量_含稅總價(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            月結帳資料_.數量 = 動態資料_.Get<Int32>(月結帳列舉.匯入需求欄位.數量.ToString());

            if (月結帳資料_.數量 == 0)
                月結帳資料_.含稅單價 = 0;
            else
            {
                decimal 含稅總價 = 動態資料_.Get<Decimal>(月結帳列舉.匯入需求欄位.含稅總價.ToString());
                月結帳資料_.含稅單價 = 含稅總價 / 月結帳資料_.數量;
            }

            月結帳資料_.單價 = 月結帳資料_.含稅單價 / 1.05m;
        }

        public BindingList<月結帳資料> 轉換綁定陣列(動態匯入檔案結構 檔案_)
        {
            try
            {
                _設定 = (月結帳匯入設定資料)(檔案_.設定);

                switch (_設定.商品識別)
                {
                    case 列舉.商品識別類型.商品編號:
                        設定商品 = 設定商品編號;
                        break;
                    case 列舉.商品識別類型.商品編號_顏色:
                        設定商品 = 設定商品編號_顏色;
                        break;
                    case 列舉.商品識別類型.商品名稱:
                        設定商品 = 設定商品名稱;
                        break;
                    default:
                        throw new Exception("月結帳匯入轉換:未知的商品識別類型:" + _設定.商品識別);
                }

                if (_設定.名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.單價.ToString()))
                    設定金額 = 設定數量_單價;
                else if(_設定.名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.含稅單價.ToString()))
                    設定金額 = 設定數量_含稅單價;
                else if (_設定.名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.總價.ToString()))
                    設定金額 = 設定數量_總價;
                else if (_設定.名稱映射對應表.ContainsKey(月結帳列舉.匯入需求欄位.含稅總價.ToString()))
                    設定金額 = 設定數量_含稅總價;
                else
                    throw new Exception("月結帳匯入轉換:未知的金額設定" + _設定.ToString());

                公司資料 公司_ = _設定.公司;
                客戶資料 客戶_ = _設定.客戶;

                BindingList<月結帳資料> Result_ = new BindingList<月結帳資料>();
                foreach (var 動態資料_ in 檔案_.內容)
                {
                    var 月結帳資料_ = new 月結帳資料
                    {
                        公司 = 公司_,
                        客戶 = 客戶_,
                    };

                    設定商品(動態資料_, 月結帳資料_);
                    設定金額(動態資料_, 月結帳資料_);

                    Result_.Add(月結帳資料_);
                }

                return Result_;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
