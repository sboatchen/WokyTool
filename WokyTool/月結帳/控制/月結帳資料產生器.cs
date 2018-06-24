using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;
using WokyTool.動態匯入;
using WokyTool.月結帳;
using System.Windows.Forms;

public delegate void 設定商品委派(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_);
public delegate void 設定金額委派(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_);

namespace WokyTool.月結帳
{
    public class 月結帳資料產生器
    {
        private 月結帳匯入檔案設定 _設定;
        
        private int _商品編號索引 = -1;
        private int _商品名稱索引 = -1;
        private int _顏色索引 = -1;

        private int _單價索引 = -1;
        private int _含稅單價索引 = -1;
        private int _總價索引 = -1;
        private int _含稅總價索引 = -1;
        private int _數量索引 = -1;

        private 設定商品委派 設定商品;
        private 設定金額委派 設定金額;

        public 月結帳資料產生器(月結帳匯入檔案設定 設定_)
        {
            this._設定 = 設定_;

            動態匯入資料設定 動態匯入資料設定_;
            if (_設定.名稱映射對應表.TryGetValue(月結帳匯入檔案設定.動態匯入需求欄位_月結帳.商品編號.ToString(), out 動態匯入資料設定_))
            {
                _商品編號索引 = 動態匯入資料設定_.列索引;
            }

            if (_設定.名稱映射對應表.TryGetValue(月結帳匯入檔案設定.動態匯入需求欄位_月結帳.商品名稱.ToString(), out 動態匯入資料設定_))
            {
                _商品名稱索引 = 動態匯入資料設定_.列索引;
            }

            if (_設定.名稱映射對應表.TryGetValue(月結帳匯入檔案設定.動態匯入需求欄位_月結帳.顏色.ToString(), out 動態匯入資料設定_))
            {
                _顏色索引 = 動態匯入資料設定_.列索引;
            }

            if (_設定.名稱映射對應表.TryGetValue(月結帳匯入檔案設定.動態匯入需求欄位_月結帳.單價.ToString(), out 動態匯入資料設定_))
            {
                _單價索引 = 動態匯入資料設定_.列索引;
            }

            if (_設定.名稱映射對應表.TryGetValue(月結帳匯入檔案設定.動態匯入需求欄位_月結帳.含稅單價.ToString(), out 動態匯入資料設定_))
            {
                _含稅單價索引 = 動態匯入資料設定_.列索引;
            }
            
            if (_設定.名稱映射對應表.TryGetValue(月結帳匯入檔案設定.動態匯入需求欄位_月結帳.總價.ToString(), out 動態匯入資料設定_))
            {
                _總價索引 = 動態匯入資料設定_.列索引;
            }

            if (_設定.名稱映射對應表.TryGetValue(月結帳匯入檔案設定.動態匯入需求欄位_月結帳.含稅總價.ToString(), out 動態匯入資料設定_))
            {
                _含稅總價索引 = 動態匯入資料設定_.列索引;
            }

            if (_設定.名稱映射對應表.TryGetValue(月結帳匯入檔案設定.動態匯入需求欄位_月結帳.數量.ToString(), out 動態匯入資料設定_))
            {
                _數量索引 = 動態匯入資料設定_.列索引;
            }

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
                    throw new Exception("月結帳資料產生器:未知的商品識別類型:" + _設定.商品識別);
            }

            if (_單價索引 != -1)
                設定金額 = 設定單價;
            else if(_含稅單價索引 != -1)
                設定金額 = 設定含稅單價;
            else if(_總價索引 != -1)
                設定金額 = 設定總價;
            else if(_含稅總價索引 != -1)
                設定金額 = 設定含稅總價;
            else
                throw new Exception("月結帳資料產生器:未知的金額類型");
        }

        public void 設定商品編號(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            月結帳資料_.商品識別 = 動態資料_.資料[_商品編號索引].ToString();
            月結帳資料_.商品 = 商品管理器.Instance.Get(_設定.廠商.編號, 月結帳資料_.商品識別);
        }

        public void 設定商品編號_顏色(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            String 商品編號 = 動態資料_.資料[_商品編號索引].ToString();
            String 顏色 = 動態資料_.資料[_顏色索引].ToString();
            月結帳資料_.商品識別 = 商品編號 + "@" + 顏色;
            月結帳資料_.商品 = 商品管理器.Instance.Get(_設定.廠商.編號, 月結帳資料_.商品識別);
        }

        public void 設定商品名稱(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            月結帳資料_.商品識別 = 動態資料_.資料[_商品名稱索引].ToString();
            月結帳資料_.商品 = 商品管理器.Instance.GetByName(_設定.廠商.編號, 月結帳資料_.商品識別);
        }

        public void 設定單價(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            //月結帳資料_.單價 = Convert.ToDecimal((double)動態資料_.資料[_單價索引]);
            月結帳資料_.單價 = Convert.ToDecimal(動態資料_.資料[_單價索引].ToString());
            月結帳資料_.含稅單價 = 月結帳資料_.單價 * 1.05m;
            //月結帳資料_.數量 = Convert.ToInt32((double)動態資料_.資料[_數量索引]);
            月結帳資料_.數量 = Convert.ToInt32(動態資料_.資料[_數量索引].ToString());
        }

        public void 設定含稅單價(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            //月結帳資料_.含稅單價 = Convert.ToDecimal((double)動態資料_.資料[_含稅單價索引]);
            月結帳資料_.含稅單價 = Convert.ToDecimal(動態資料_.資料[_含稅單價索引].ToString());
            月結帳資料_.單價 = 月結帳資料_.含稅單價 / 1.05m;
            //月結帳資料_.數量 = Convert.ToInt32((double)動態資料_.資料[_數量索引]);
            月結帳資料_.數量 = Convert.ToInt32(動態資料_.資料[_數量索引].ToString());
        }

        public void 設定總價(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            //月結帳資料_.數量 = Convert.ToInt32((double)動態資料_.資料[_數量索引]);
            月結帳資料_.數量 = Convert.ToInt32(動態資料_.資料[_數量索引].ToString());

            if (月結帳資料_.數量 == 0)
                月結帳資料_.單價 = 0;
            else
            {
                //月結帳資料_.單價 = Convert.ToDecimal((double)動態資料_.資料[_總價索引]) / 月結帳資料_.數量;
                月結帳資料_.單價 = Convert.ToDecimal(動態資料_.資料[_總價索引].ToString()) / 月結帳資料_.數量;
            }

            月結帳資料_.含稅單價 = 月結帳資料_.單價 * 1.05m;
        }

        public void 設定含稅總價(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            //月結帳資料_.數量 = Convert.ToInt32((double)動態資料_.資料[_數量索引]);
            月結帳資料_.數量 = Convert.ToInt32(動態資料_.資料[_數量索引].ToString());

            if (月結帳資料_.數量 == 0)
                月結帳資料_.含稅單價 = 0;
            else
            {
                //月結帳資料_.含稅單價 = Convert.ToDecimal((double)動態資料_.資料[_含稅總價索引]) / 月結帳資料_.數量;
                月結帳資料_.含稅單價 = Convert.ToDecimal(動態資料_.資料[_含稅總價索引].ToString()) / 月結帳資料_.數量;
            }

            月結帳資料_.單價 = 月結帳資料_.含稅單價 / 1.05m;
        }

        public void 設定數量(動態匯入資料結構 動態資料_, 月結帳資料 月結帳資料_)
        {
            //月結帳資料_.數量 = Convert.ToInt32((double)動態資料_.資料[_數量索引]);
            月結帳資料_.數量 = Convert.ToInt32(動態資料_.資料[_數量索引].ToString());
        }

        public List<月結帳資料> Create(動態匯入檔案結構 檔案_)
        {
            if(this._設定 != 檔案_.設定)
                throw new Exception("月結帳資料產生器:設定不一致");

            公司資料 公司_ = _設定.公司;
            廠商資料 廠商_ = _設定.廠商;

            try
            {
                List<月結帳資料> Result_ = new List<月結帳資料>();
                foreach (var 動態資料_ in 檔案_.內容)
                {
                    var 月結帳資料_ = new 月結帳資料
                    {
                        公司 = 公司_,
                        廠商 = 廠商_,
                    };

                    設定商品(動態資料_, 月結帳資料_);
                    設定金額(動態資料_, 月結帳資料_);
                    設定數量(動態資料_, 月結帳資料_);

                    Result_.Add(月結帳資料_);
                }

                return Result_;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), 字串.錯誤, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
