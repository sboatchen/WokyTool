using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WokyTool.Common;
using WokyTool.通用;

namespace WokyTool.測試
{
    public class 讀寫測試轉換 : 可寫入介面_CSV, 可讀出介面_CSV<讀寫測試資料>, 可寫入介面_EXCEL, 可讀出介面_EXCEL<讀寫測試資料>
    {
        private static int 測試編號_ = 0;

        public string 分類 { get; set; }

        public string 分格號 
        {
            get 
            {
                return ",";  
            }
        }

        public int 分頁索引 { get { return 1; } }

        public int 標頭索引 { get { return 1; } }

        public bool 是否有標頭 { get { return true; } }

        public int 資料開始索引 { get { return 2; } }

        public int 資料結尾忽略行數 { get { return 0; } }

        public string 樣板 { get; set; }

        public XlFileFormat 格式 { get; set; }

        public string 密碼 { get; set; }

        public Encoding 編碼{ get { return Encoding.UTF8; } }

        private IEnumerable<讀寫測試資料> _資料列;

        public 讀寫測試轉換()
        {
            測試編號_++;
            分類 = "測試編號" + 測試編號_;

            List<讀寫測試資料> 資料列_ = new List<讀寫測試資料>();
            for(int i = 0 ; i < 5 ; i++){
                資料列_.Add(new 讀寫測試資料{
                    字串 = 分類 + "," + i,
                    整數 = i,
                    浮點數 = (float)(i / 1000.0),
                    倍精準浮點數 = (float)(i / 1000.0),
                    時間 = DateTime.Now,
                    列舉 = (列舉.編號)i,
                });
            }

            // 空資料
            資料列_.Add(new 讀寫測試資料());

            _資料列 = 資料列_;
        }

        public void 寫入(CSVBuilder Builder_)
        {
            Builder_.加入標頭("字串", "整數", "浮點數", "倍精準浮點數", "時間", "列舉");

            foreach (讀寫測試資料 資料_ in _資料列)
            {
                Builder_.加入(資料_.字串, 資料_.整數, 資料_.浮點數, 資料_.倍精準浮點數, 資料_.時間, 資料_.列舉);
            }
        }

        public void 寫入(Application App_)
        {
            App_.Cells[1, 1] = "字串";
            App_.Cells[1, 2] = "整數";
            App_.Cells[1, 3] = "浮點數";
            App_.Cells[1, 4] = "倍精準浮點數";
            App_.Cells[1, 5] = "時間";
            App_.Cells[1, 6] = "列舉";

            int 目前行數_ = 2;
            foreach (讀寫測試資料 資料_ in _資料列)
            {
                App_.Cells[目前行數_, 1] = 資料_.字串;
                App_.Cells[目前行數_, 2] = 資料_.整數;
                App_.Cells[目前行數_, 3] = 資料_.浮點數;
                App_.Cells[目前行數_, 4] = 資料_.倍精準浮點數;
                App_.Cells[目前行數_, 5] = 資料_.時間;
                App_.Cells[目前行數_, 6] = 資料_.列舉;

                目前行數_++;
            }
        }

        public void 讀出標頭(string[] 標頭列_)
        {
            foreach (string 標頭_ in 標頭列_)
                Console.WriteLine(標頭_);
            Console.WriteLine("-----------");
        }

        public IEnumerable<讀寫測試資料> 讀出資料(string[] 資料列_)
        {
            讀寫測試資料 新資料 = new 讀寫測試資料
            {
                字串 = 資料列_[0].轉成字串(),
                整數 = 資料列_[1].轉成整數(),
                浮點數 = 資料列_[2].轉成浮點數(),
                倍精準浮點數 = 資料列_[3].轉成倍精準浮點數(),
                時間 = 資料列_[4].轉成時間(),
                列舉 = 資料列_[5].轉成列舉<列舉.編號>()
            };

            yield return 新資料;
        }
    }
}
