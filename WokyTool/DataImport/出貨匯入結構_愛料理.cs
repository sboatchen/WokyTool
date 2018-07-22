using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.Data;
using WokyTool.DataMgr;
using WokyTool.通用;

namespace WokyTool.DataImport
{
    class 出貨匯入結構_愛料理 : 商品訂單資料
    {
        /***** 資訊格式
        訂單編號
        群組          無
        
        商品序號    無
        數量          無
          
        姓名          
        地址          
        電話          無
        手機       
          
        指配日期     無
        指配時段     無
          
        代收方式     無
        代收金額     無
          
        配送公司     無
        配送單號     無
          
        備註
        *********/
        /* 平台特殊欄位 */
        public string 購買內容 { get; set; }

        /* 平台回單複製用欄位 */
        //public string 無用_XXXX { get; set; }

        // 共用廠商快取
        protected static readonly 廠商資料 _共用廠商快取 = 廠商管理器.Instance.Get("愛料理");

        protected static readonly string[] LINE_SEPERATOR = new string[] {"\n"};
        protected static readonly string[] DATA_SEPERATOR = new string[] {"X"};
        protected static int NEXT_AUTO_GROUP = 10000;

        public 出貨匯入結構_愛料理(){

        }

        public 出貨匯入結構_愛料理(出貨匯入結構_愛料理 from_){
            this.訂單編號 = from_.訂單編號;
            this.群組 = from_.群組;
           
            this.商品序號 = from_.商品序號;
            this.數量 = from_.數量;
            this.商品 = from_.商品;
            
            this.姓名 = from_.姓名;
            this.地址 = from_.地址;
            this.手機 = from_.手機;

            this.備註 = from_.備註;

            this.廠商 = from_.廠商;

            this.指配日期 = from_.指配日期;
            this.指配時段 = from_.指配時段;

            this.代收方式 = from_.代收方式;
            this.代收金額 = from_.代收金額;

            this.配送公司 = from_.配送公司;
            this.配送單號 = from_.配送單號;
        }


        // 是否為需處理物件
        //override public bool IsRead();
       
        // 是否合法
        //override public bool IsLegal();

        // 初始化
        override public void Init()
        {
            群組 = 0;

            廠商 = _共用廠商快取;

            指配日期 = 時間.NULL;
            指配時段 = 列舉.指配時段類型.無;

            代收方式 = 列舉.代收類型.無;
            代收金額 = 0;

            配送公司 = 列舉.配送公司類型.無;
            配送單號 = null;
        }

        // 取得物件列表
        override public IEnumerable<商品訂單資料> ToList()
        {
            /* 格式
            OXO 按壓式蔬菜脫水器（大白） X 1
            OXO 食物壓切器-小 X 1
            */

            String[] dataList_ = 購買內容.Split(LINE_SEPERATOR, StringSplitOptions.RemoveEmptyEntries);
            if(dataList_.Length > 1)
            {
                this.群組 = NEXT_AUTO_GROUP++;
            }

            foreach (String data_ in dataList_)
            {
                int X_ = data_.LastIndexOf('X');
                if (X_ == -1)
                {
                    this.商品序號 = data_;
                    this.數量 = 0;
                    this.商品 = 商品資料.ERROR;
                    yield return new 出貨匯入結構_愛料理(this);
                    continue;
                }

                this.商品序號 = data_.Substring(0, X_).Trim();
                X_++;
                this.數量 = Int32.Parse(data_.Substring(X_, data_.Length - X_).Trim());
                this.商品 = 商品管理器.Instance.GetByName(廠商.編號, 商品序號);

                yield return new 出貨匯入結構_愛料理(this);
            }
        }

        // 準備配送
        //override public void PrepareDiliver();

        // 完成配送
        //override public void SetDiliver(string 配送單號_);

        // 是否已經配送
        //override public bool IsDilivered();
    }
}


