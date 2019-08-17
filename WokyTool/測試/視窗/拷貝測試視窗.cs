using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WokyTool.客戶;
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

        private void 位元組_Click(object sender, EventArgs e)
        {
            DateTime 現在時間_ = DateTime.Now;

            讀寫測試資料 讀寫測試資料_ = new 讀寫測試資料
            {
                字串 = "1",
                整數 = 1,
                浮點數 = 1,
                倍精準浮點數 = 1,
                時間 = 現在時間_,
                列舉 = (列舉.編號)1,
                整數列 = new int[] { 1, 2, 3, 4 }.ToList(),
                整數2 = 1,
            };
            讀寫測試資料_.書 = new Dictionary<int, string>();
            讀寫測試資料_.書.Add(1, "1");

            Console.WriteLine(讀寫測試資料_.ToString(false));

            var 第一個資料位元組_ = 讀寫測試資料_.轉成位元組();

            var 轉回來_ = 第一個資料位元組_.轉成物件<讀寫測試資料>();

            Console.WriteLine(轉回來_.ToString(false));


            讀寫測試資料_ = new 讀寫測試資料
            {
                字串 = "1",
                整數 = 1,
                浮點數 = 1,
                倍精準浮點數 = 1,
                時間 = 現在時間_,
                列舉 = (列舉.編號)1,
                整數列 = new int[] { 1, 2, 3, 4 }.ToList(),
                整數2 = 1,
            };
            讀寫測試資料_.書 = new Dictionary<int, string>();
            讀寫測試資料_.書.Add(1, "1");

            var 第二個資料位元組_ = 讀寫測試資料_.轉成位元組();

            Console.WriteLine(第一個資料位元組_.是否相等(第二個資料位元組_));


            讀寫測試資料_.整數 = 2;
            var 第三個資料位元組_ = 讀寫測試資料_.轉成位元組();

            Console.WriteLine(第一個資料位元組_.是否相等(第三個資料位元組_));
        }

        private void 完全拷貝_Click(object sender, EventArgs e)
        {
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

            讀寫測試資料 讀寫測試資料2_ = new 讀寫測試資料();
            讀寫測試資料2_.完全拷貝(讀寫測試資料_);

            Console.WriteLine(讀寫測試資料_.ToString(false));
        }

        private void 編輯測試_Click(object sender, EventArgs e)
        {
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

            讀寫測試資料_.BeginEdit();

            讀寫測試資料_.整數 = 2;

            Console.WriteLine("應該為 true :" + 讀寫測試資料_.是否編輯中);

            讀寫測試資料_.BeginEdit();

            讀寫測試資料_.整數 = 1;
            讀寫測試資料_.字串 = "1";

            Console.WriteLine("應該為 false :" + 讀寫測試資料_.是否編輯中);

            讀寫測試資料_.BeginEdit();

            讀寫測試資料_.書 = new Dictionary<int, string>();
            讀寫測試資料_.書.Add(1, "1");

            Console.WriteLine("應該為 false :" + 讀寫測試資料_.是否編輯中);

            讀寫測試資料_.BeginEdit();

            讀寫測試資料_.書.Add(2, "2");

            Console.WriteLine("應該為 true :" + 讀寫測試資料_.是否編輯中);

            讀寫測試資料_.取消編輯();

            Console.WriteLine(讀寫測試資料_.ToString(false));

            讀寫測試資料_.BeginEdit();

            讀寫測試資料_.書 = new Dictionary<int, string>();
            讀寫測試資料_.書.Add(1, "9999");

            讀寫測試資料_.紀錄編輯(true);
        }

        private void 序列化_Click(object sender, EventArgs e)
        {
            /*序列化測試資料 資料_ = new 序列化測試資料
            {
                整數 = 12345,
                字串 = "感林洋",
                浮點數 = 1.2345f,
                客戶 = 客戶資料.空白,
                客戶2 = 客戶資料.錯誤,
            };

            訊息管理器.獨體.通知(JsonConvert.SerializeObject(資料_, Formatting.Indented));

            {
                var 第一個資料位元組_ = 資料_.轉成位元組();

                object 轉回來_ = 第一個資料位元組_.轉成物件<object>();

                訊息管理器.獨體.通知(JsonConvert.SerializeObject(轉回來_, Formatting.Indented));
            }

            SaveFileDialog SFD_ = new SaveFileDialog();
            SFD_.DefaultExt = ".xml";
            SFD_.Filter = "xml files (.xml)|*.xml";
            if (SFD_.ShowDialog() != DialogResult.OK)
                return;

            int index = SFD_.FileName.IndexOf(".");
            string fileName = SFD_.FileName.Substring(0, index + 1);
            Console.WriteLine(fileName);
            
            {
                FileStream stream = new FileStream(fileName + "xml", FileMode.Create);
                XmlSerializer xmlserilize = new XmlSerializer(typeof(序列化測試資料));
                xmlserilize.Serialize(stream, 資料_);
                stream.Close();
            }*/

            子客戶資料 資料_ = new 子客戶資料
            {
                編號 = 12345,
                名稱 = "感林洋",
                客戶 = 客戶資料管理器.獨體.取得(3),
            };

            訊息管理器.獨體.通知(JsonConvert.SerializeObject(資料_, Formatting.Indented));

            {
                var 第一個資料位元組_ = 資料_.轉成位元組();

                子客戶資料 轉回來_ = 第一個資料位元組_.轉成物件<子客戶資料>();

                訊息管理器.獨體.通知(JsonConvert.SerializeObject(轉回來_, Formatting.Indented));
            }
        }

        private void 序列化時間_Click(object sender, EventArgs e)
        {
            List<讀寫測試資料> 資料列_ = new List<讀寫測試資料>();

            Random 隨機_ = new Random();
            for (int i = 1; i <= 100000; i++)
            {
                讀寫測試資料 讀寫測試資料_ = new 讀寫測試資料
                {
                    字串 = "字串" + i,
                    整數 = i,
                    浮點數 = (float)隨機_.NextDouble(),
                    倍精準浮點數 = 隨機_.NextDouble(),
                    時間 = DateTime.Now.AddMinutes(i),
                    列舉 = (列舉.編號)(i % 10 + 1),
                };

                資料列_.Add(讀寫測試資料_);
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();

            List<byte[]> 中繼資料列_ = new List<byte[]>();
            foreach (讀寫測試資料 資料_ in 資料列_)
            {
                中繼資料列_.Add(資料_.轉成位元組());
            }

            watch.Stop();
            Console.WriteLine("建立資料花費:" + watch.ElapsedMilliseconds);
            watch.Restart();

            byte[] 比較範例_ = 中繼資料列_.First();
            foreach (byte[] 資料_ in 中繼資料列_)
            {
                資料_.是否相等(比較範例_);
            }

            watch.Stop();
            Console.WriteLine("比較資料花費:" + watch.ElapsedMilliseconds);
            watch.Restart();

            foreach (byte[] 資料_ in 中繼資料列_)
            {
                var x = 資料_.轉成物件<讀寫測試資料>();
            }

            watch.Stop();
            Console.WriteLine("轉換資料花費:" + watch.ElapsedMilliseconds);
            Console.WriteLine("------------------");
            watch.Restart();

            List<string> 中繼資料列2_ = new List<string>();
            foreach (讀寫測試資料 資料_ in 資料列_)
            {
                中繼資料列2_.Add(資料_.ToString(false));
            }

            watch.Stop();
            Console.WriteLine("建立資料花費:" + watch.ElapsedMilliseconds);
            watch.Restart();

            string 比較範例2_ = 中繼資料列2_.First();
            foreach (string 資料_ in 中繼資料列2_)
            {
                資料_.Equals(比較範例_);
            }

            watch.Stop();
            Console.WriteLine("比較資料花費:" + watch.ElapsedMilliseconds);
            watch.Restart();

            foreach (string 資料_ in 中繼資料列2_)
            {
                var x = JsonConvert.DeserializeObject<讀寫測試資料>(資料_);
            }

            watch.Stop();
            Console.WriteLine("轉換資料花費:" + watch.ElapsedMilliseconds);
        }
    }
}
